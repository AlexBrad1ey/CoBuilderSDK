// ***********************************************************************
// Assembly         : CoBuilderV2
// Author           : Alex Bradley
// Created          : 08-09-2016
//
// Last Modified By : Alex Bradley
// Last Modified On : 08-09-2016
// ***********************************************************************
// <copyright file="AppConfig.cs" company="AB Consulting">
//     Copyright (c) AB Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using CoBuilder.Core.Enums;
using CoBuilder.Core.Interfaces;

namespace CoBuilder.Core
{
    /// <summary>
    /// Class AppConfig.
    /// </summary>
    /// <seealso cref="CoBuilder.Core.Interfaces.IAppConfig" />
    public class AppConfig : IAppConfig
    {
        /// <summary>
        /// Gets or sets the application identifier.
        /// </summary>
        /// <value>The application identifier.</value>
        public PluginApp AppId { get; set; }
        /// <summary>
        /// Gets or sets the program version.
        /// </summary>
        /// <value>The program version.</value>
        public string ProgramVersion { get; set; }
        /// <summary>
        /// Gets or sets the client identifier.
        /// </summary>
        /// <value>The client identifier.</value>
        public string ClientId { get; set; }
    }
}