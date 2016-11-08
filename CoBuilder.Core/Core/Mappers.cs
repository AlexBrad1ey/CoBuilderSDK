// ***********************************************************************
// Assembly         : CoBuilderV2
// Author           : Alex Bradley
// Created          : 08-09-2016
//
// Last Modified By : Alex Bradley
// Last Modified On : 08-09-2016
// ***********************************************************************
// <copyright file="Mappers.cs" company="AB Consulting">
//     Copyright (c) AB Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Collections.Generic;
using System.Linq;
using CoBuilder.Core.Domain;

namespace CoBuilder.Core
{
    /// <summary>
    /// Class Mappers.
    /// </summary>
    public static class Mappers
    {
        /// <summary>
        /// Maps the property set ids.
        /// </summary>
        /// <param name="propertySetTags">The property set tags.</param>
        /// <returns>IList&lt;System.Int32&gt;.</returns>
        public static IList<int> MapPropertySetIds(IList<IBimPropertySetTag> propertySetTags)
        {
            return propertySetTags.Select(pSetTag => pSetTag.Id).ToList();
        }
    }
}