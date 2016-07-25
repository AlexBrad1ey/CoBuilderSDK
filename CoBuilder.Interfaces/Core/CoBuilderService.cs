using System;
using System.Diagnostics;
using System.Reflection;

namespace CoBuilder.Service
{
    public class CoBuilderService
    {
        public CoBuilderService()
        {
        }



        public static void Close()
        {
            Factory<ISession>().Close();
        }

        #region Private Fields

        private static Registry _configuration;
        
        private static bool _initialised;

        #endregion

        #region Constructors

        static CoBuilderService()
        {
            _configuration = new CoBuilderConfig();
        }

        

        public CoBuilderService(CoBuilderConfig appConfig) : this(appConfig, false)
        {
        }

        public CoBuilderService(CoBuilderConfig appConfig, bool autoInitialise)
        {
            SetConfiguration(appConfig);
            if (autoInitialise) Initialise();
        }

        #endregion

        #region Public Properties

        public bool Initialised => _initialised;

        public ProductStore Products
        {
            get { return Factory<ProductStore>(); }
        }

        public WorkPlaceStore WorkPlaces => Factory<WorkPlaceStore>();
        public ICoBuilderUser User => Factory<ICoBuilderUser>();
        public ISession Session => Factory<ISession>();

        #endregion

        #region Public Events

#pragma warning disable RECS0154 // Parameter is never used
        public void App_DocumentLoadEventHandler<TElement>(object sender, EventArgs e) where TElement : class
#pragma warning restore RECS0154 // Parameter is never used
        {
            InterrogateModel<TElement>();
        }

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

        #endregion

        #region Startup Methods

        public void SetConfiguration(CoBuilderConfig appConfig)
        {
            _configuration = appConfig;
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

        #endregion

        #region Static Factories for object generation

        public static T Factory<T>()
        {
            if (_initialised)
            {
                return _diContainer.GetInstance<T>();
            }
            throw new Exception("Service Uninitialised");
        }

        public static T Factory<T>(ExplicitArguments args)
        {
            if (_initialised)
            {
                return _diContainer.GetInstance<T>(args);
            }
            throw new Exception("Service Uninitialized");
        }

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

        #endregion

        #region DI Testing Methods

        internal static string WhatDoIHave()
        {
            return _diContainer.WhatDoIHave();
        }

        internal static string BuildPlan<T>()
        {
            return _diContainer.Model.For<T>().Default.DescribeBuildPlan(5);
        }

        #endregion
    }
}