// ***********************************************************************
// Assembly         : CoBuilderV2
// Author           : Alex Bradley
// Created          : 08-09-2016
//
// Last Modified By : Alex Bradley
// Last Modified On : 11-08-2016
// ***********************************************************************
// <copyright file="CoBuilderClient.cs" company="AB Consulting">
//     Copyright (c) AB Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using CoBuilder.Core.Authentication;
using CoBuilder.Core.Enums;
using CoBuilder.Core.Interfaces;
using CoBuilder.Core.Requests;

namespace CoBuilder.Core
{
    /// <summary>
    /// Class CoBuilderClient.
    /// </summary>
    /// <seealso cref="CoBuilder.Core.BaseClient" />
    /// <seealso cref="CoBuilder.Core.Interfaces.ICoBuilderClient" />
    public class CoBuilderClient : BaseClient, ICoBuilderClient
    {
        /// <summary>
        /// The _property set ids
        /// </summary>
        private IList<int> _propertySetIds;

        /// <summary>
        /// Initializes a new instance of the <see cref="CoBuilderClient"/> class.
        /// </summary>
        /// <param name="appConfig">The application configuration.</param>
        /// <param name="httpProvider">The HTTP provider.</param>
        /// <param name="authenticationProvider">The authentication provider.</param>
        public CoBuilderClient(
            IAppConfig appConfig,
            IHttpProvider httpProvider,
            IAuthenticationProvider authenticationProvider)
            : base(appConfig,httpProvider,authenticationProvider)
        {
        }

        /// <summary>
        /// Gets or sets the property set ids.
        /// </summary>
        /// <value>The property set ids.</value>
        public IList<int> PropertySetIds
        {
            get
            {
                return _propertySetIds ??
                       (PropertySetIds = Mappers.MapPropertySetIds(PropertySetTags.Request().GetAsync().Result));
            }
            set { _propertySetIds = value; }
        }

        /// <summary>
        /// Gets the workplaces.
        /// </summary>
        /// <value>The workplaces.</value>
        public IWorkplacesCollectionRequestBuilder Workplaces
        {
            get
            {
                return new WorkplacesCollectionRequestBuilder(Constants.Url.Workplaces, this, CurrentSession.ContactId);
            }
        }

        /// <summary>
        /// Gets the property set tags.
        /// </summary>
        /// <value>The property set tags.</value>
        public IPropertySetTagsCollectionRequestBuilder PropertySetTags
        {
            get
            {
                return new PropertySetTagsCollectionRequestBuilder(Constants.Url.PropertySetTags, this,
                    CurrentSession.AppId);
            }
        }

        /// <summary>
        /// Gets the products.
        /// </summary>
        /// <value>The products.</value>
        public IProductsCollectionRequestBuilder Products
        {
            get
            {
                return new ProductsCollectionRequestBuilder(Constants.Url.Products, this);
            }
        }

        /// <summary>
        /// Productses the index of the by country.
        /// </summary>
        /// <param name="countryIndex">Index of the country.</param>
        /// <returns>IProductsCollectionRequestBuilder.</returns>
        /// <exception cref="System.ArgumentOutOfRangeException"></exception>
        public IProductsCollectionRequestBuilder ProductsByCountryIndex(int countryIndex)
        {
            if (countryIndex <= 0) throw new ArgumentOutOfRangeException(nameof(countryIndex));

            return new ProductsCollectionRequestBuilder(Constants.Url.Products, this, ProductRequestType.CountryIndex,
                countryIndex: countryIndex);
        }


    }
}