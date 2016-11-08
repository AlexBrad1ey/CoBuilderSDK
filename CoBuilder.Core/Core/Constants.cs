// ***********************************************************************
// Assembly         : CoBuilderV2
// Author           : Alex Bradley
// Created          : 08-09-2016
//
// Last Modified By : Alex Bradley
// Last Modified On : 08-09-2016
// ***********************************************************************
// <copyright file="Constants.cs" company="AB Consulting">
//     Copyright (c) AB Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace CoBuilder.Core
{
    /// <summary>
    /// Class Constants.
    /// </summary>
    public static class Constants
    {
        /// <summary>
        /// Class Authentication.
        /// </summary>
        public static class Authentication
        {
            /// <summary>
            /// The access token key name
            /// </summary>
            public const string AccessTokenKeyName = "access_token";
            /// <summary>
            /// The co builder base URL
            /// </summary>
            public const string CoBuilderBaseUrl = "https://services.cobuilder.com/Plugin/PluginService.svc/REST";
        }

        /// <summary>
        /// Class Headers.
        /// </summary>
        public static class Headers
        {
            /// <summary>
            /// The bearer
            /// </summary>
            public const string Bearer = "Bearer";
        }

        /// <summary>
        /// Class Url.
        /// </summary>
        public static class Url
        {
            /// <summary>
            /// The login
            /// </summary>
            public const string Login = "Login";
            /// <summary>
            /// The workplaces
            /// </summary>
            public const string Workplaces = "GetWorkplaceHierarchy";
            /// <summary>
            /// The property set tags
            /// </summary>
            public const string PropertySetTags = "PSetTags";
            /// <summary>
            /// The products
            /// </summary>
            public const string Products = "Products";
            /// <summary>
            /// The property sets
            /// </summary>
            public const string PropertySets = "ProductPSets";
            /// <summary>
            /// The properties
            /// </summary>
            public const string Properties = "ProductProperties";
        }

        /// <summary>
        /// Class Parameters.
        /// </summary>
        public static class Parameters
        {
            /// <summary>
            /// The username
            /// </summary>
            public const string Username = "username";
            /// <summary>
            /// The password
            /// </summary>
            public const string Password = "password";
            /// <summary>
            /// The contact identifier
            /// </summary>
            public const string ContactId = "contactId";
            /// <summary>
            /// The application identifier
            /// </summary>
            public const string AppId = "appId";
            /// <summary>
            /// The workplace identifier
            /// </summary>
            public const string WorkplaceId = "workplaceId";
            /// <summary>
            /// The country index
            /// </summary>
            public const string CountryIndex = "countryIndex";
            /// <summary>
            /// The product identifier
            /// </summary>
            public const string ProductId = "productId";
            /// <summary>
            /// The property set identifier
            /// </summary>
            public const string PropertySetId = "pSetId";
            /// <summary>
            /// The property set ids
            /// </summary>
            public const string PropertySetIds = "pSetIds";
        }
    }
}