using System;
using System.Collections.Generic;
using CoBuilder.Core.Authentication;
using CoBuilder.Core.Enums;
using CoBuilder.Core.Interfaces;
using CoBuilder.Core.Requests;

namespace CoBuilder.Core
{
    public class CoBuilderClient : BaseClient, ICoBuilderClient
    {
        private IList<int> _propertySetIds;

        public CoBuilderClient(
            IAppConfig appConfig,
            IHttpProvider httpProvider,
            IServiceInfoProvider serviceInfoProvider)
            : base(appConfig, httpProvider, serviceInfoProvider)
        {
        }

        public IList<int> PropertySetIds
        {
            get
            {
                return _propertySetIds ??
                       (PropertySetIds = Mappers.MapPropertySetIds(PropertySetTags.Request().GetAsync().Result));
            }
            set { _propertySetIds = value; }
        }

        public IWorkplacesCollectionRequestBuilder Workplaces
        {
            get
            {
                return new WorkplacesCollectionRequestBuilder(Constants.Url.Workplaces, this, CurrentSession.ContactId);
            }
        }

        public IPropertySetTagsCollectionRequestBuilder PropertySetTags
        {
            get
            {
                return new PropertySetTagsCollectionRequestBuilder(Constants.Url.PropertySetTags, this,
                    CurrentSession.AppId);
            }
        }

        public IProductsCollectionRequestBuilder ProductsByCountryIndex(int countryIndex)
        {
            if (countryIndex <= 0) throw new ArgumentOutOfRangeException(nameof(countryIndex));

            return new ProductsCollectionRequestBuilder(Constants.Url.Products, this, ProductRequestType.CountryIndex,
                CountryIndex: countryIndex);
        }
    }
}