// ***********************************************************************
// Assembly         : CoBuilder.Navisworks
// Author           : Alex Bradley
// Created          : 09-09-2016
//
// Last Modified By : Alex Bradley
// Last Modified On : 11-08-2016
// ***********************************************************************
// <copyright file="NavisworksAppConfig.cs" company="AB Consulting">
//     Copyright (c) AB Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using CoBuilder.Core;
using System;
using CoBuilder.Core.Enums;

namespace CoBuilder.Navisworks
{
    /// <summary>
    /// Class NavisworksAppConfig.
    /// </summary>
    /// <seealso cref="CoBuilder.Core.AppConfig" />
    public class NavisworksAppConfig : AppConfig
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NavisworksAppConfig" /> class.
        /// </summary>
        public NavisworksAppConfig()
        {
            AppId = PluginApp.PXCNavisworks;
            ClientId = Guid.NewGuid().ToString();
            ProgramVersion = "2017";
        }
    }
}
