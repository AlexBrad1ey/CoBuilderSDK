using System;
using CoBuilder.Core.Enums;
using CoBuilder.Core.Exceptions;
using CoBuilder.Service.Domain;
using CoBuilder.Service.Infrastructure;
using CoBuilder.Service.Interfaces;
using StructureMap.Pipeline;

namespace CoBuilder.Service
{
    public class CoBuilderService : IDisposable
    {
        private const string InvalidOperationMessage =
            "CoBuilder Service not initiated. Call Initiate with appropriate configuration. This applies to both the static service API and the Instance API";

        private const string InvalidConfigurationMessage =
            "CoBuilder Service Configuration is invalid. a Application Configuration (AppConfig) is Required";

        private static IServiceConfiguration _config;
        private static CoBuilderService _instance;

        #region Static API

        public static CoBuilderService CurrentService
        {
            get
            {
                if (_instance == null)
                    throw new CoBuilderException(new Error()
                    {
                        Code = CoBuilderErrorCode.UnInitiatedService.ToString(),
                        Message = InvalidOperationMessage
                    }, new InvalidOperationException(InvalidOperationMessage));

                return _instance;

            }
            private set { _instance = value; }
        }

        public static IServiceConfiguration Config
        {
            get {
                if (_config == null)
                    throw new CoBuilderException(new Error()
                    {
                        Code = CoBuilderErrorCode.UnInitiatedService.ToString(),
                        Message = InvalidOperationMessage
                    }, new InvalidOperationException(InvalidOperationMessage));

                return _config;
            }
            private set { _config = value; }
        }

        public static CoBuilderService Initiate(IServiceConfiguration serviceConfiguration)
        {
            if (serviceConfiguration == null) throw new ArgumentNullException(nameof(serviceConfiguration));
            if (serviceConfiguration.AppConfig == null)
                throw new CoBuilderException(new Error()
                {
                    Code = CoBuilderErrorCode.InvalidConfiguration.ToString(),
                    Message = InvalidConfigurationMessage
                }, new InvalidOperationException(InvalidConfigurationMessage));

            _config = serviceConfiguration;
            var serviceBuilder = new ServiceBuilder(serviceConfiguration);

            _instance = serviceBuilder.Build();
            return CurrentService;
        }
        #endregion

        #region Instance API

        private readonly IContainerProvider _containerProvider;
        private IServiceSession _serviceSession;


        internal CoBuilderService(IContainerProvider containerProvider)
        {
            if (containerProvider == null) throw new ArgumentNullException(nameof(containerProvider));
            _containerProvider = containerProvider;
        }

        public ProductsRepository Products => ServiceFactory<ProductsRepository>();

        public WorkPlacesRepository WorkPlaces => ServiceFactory<WorkPlacesRepository>();
        
        public CommandsCollection Commands => new CommandsCollection();


        public ICoBuilderUser User { get { return Session.User; } }

        public IServiceSession Session
        {
            get { return _serviceSession ?? InitiateSession(); }
        }

        private IServiceSession InitiateSession()
        {
            throw new NotImplementedException();
        }


        public void Close()
        {
            _serviceSession = null;
            _containerProvider.Reset();
        }

        #region DI Methods

        public T ServiceFactory<T>()
        {
           return  _containerProvider.Container.GetInstance<T>();
        }

        public T ServiceFactory<T>(ExplicitArguments args)
        {
            return _containerProvider.Container.GetInstance<T>(args);
        }

#endregion

        

        public void Dispose()
        {
            _containerProvider.Dispose();
            _config.Dispose();
        }

        #endregion
        /*
       

        public void InterrogateModel<TElement>() where TElement : class
        {
            try
            {
                Factory<ConnectionStore<TElement>>().Clear();
                var interrogator = Factory<ModelInterrogator<TElement>>();
                var hasData = interrogator.Interrogate();

                var command = new LoginCommand();
                command.Execute();

                if (hasData)
                {
                    if (Session.LoginStatus == LoginStatus.LoggedInWithWorkplace)
                    {
                        var connections = Factory<ConnectionStore<TElement>>();
                        var products = Factory<ProductStore>();
                        foreach (var connection in connections.GetAll())
                        {
                            connection.BimProduct = products.First(p => p.Id == connection.BimProductId);
                        }
                    }
                }
            }
            catch
                (Exception exception)
            {
                var commonSettings = new CommonSettings();
                commonSettings.WriteLogFile(exception, GetType().Name, MethodBase.GetCurrentMethod().Name);
                Session.LoginStatus = LoginStatus.NotLoggedIn;
            }
        }

        public void Initialise()
        {
            if (_configuration != null)
            {
                _diContainer = new Container(_configuration);
                _initialised = true;
                var configset = Factory<IConfiguration>();
                baseconfig(configset);
                var eventRegister = Factory<IAppEventRegister>();
                eventRegister.Register();
            }
            else
            {
                throw new ApplicationException("Configuration Error");
            }
        }

        private void baseconfig(IConfiguration config)
        {
            config.SetPropertyName("CBProduct.Name", "cbr_Product_Name");
            config.SetPropertyName("CBProduct.SupplierName", "cbr_Supplier_Name");
            config.SetPropertyName("CBProduct.Link", "cbr_Product_Link");
            config.SetPropertyName("CBProduct.Identifier", "cbr_Product_Identifier");
            config.SetPropertyName("CBProduct.Id", "cbr_product_Id");

            config.SetPropertyInclusion("CBProduct.ProductTypes", false);
            config.SetPropertyInclusion("CBProduct.DOP", false);
            config.SetPropertyInclusion("CBProduct.IsCreatedFromScan", false);
        }

        #endregion Startup Methods

        #region Static Factories for object generation


        public static T Factory<T>(string key)
        {
            if (_initialised)
            {
                return _diContainer.GetInstance<T>(key);
            }
            throw new Exception("Service Uninitialized");
        }

        public static T Factory<T>(Instance instance)
        {
            if (_initialised)
            {
                return _diContainer.GetInstance<T>(instance);
            }
            throw new Exception("Service Uninitialized");
        }

        public static T Factory<T>(ExplicitArguments args, string key)
        {
            if (_initialised)
            {
                return _diContainer.GetInstance<T>(args, key);
            }
            throw new Exception("Service Uninitialized");
        }

        public static void EjectSingleton(Type type)
        {
            if (type == null) throw new ArgumentNullException(nameof(type));
            try
            {
                _diContainer.Model.For(type).Default.EjectObject();
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
            }
        }

        #endregion Static Factories for object generation

        #region DI Testing Methods

        internal static string WhatDoIHave()
        {
            return _diContainer.WhatDoIHave();
        }

        internal static string BuildPlan<T>()
        {
            return _diContainer.Model.For<T>().Default.DescribeBuildPlan(5);
        }

        #endregion DI Testing Methods */

    }

    public class CommandsCollection
    {
    }

    public class WorkPlacesRepository
    {
    }

    public class ProductsRepository
    {
    }

    public interface IServiceSession
    {
        ICoBuilderUser User { get; set; }
    }
}