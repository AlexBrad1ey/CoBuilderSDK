// ***********************************************************************
// Assembly         : CoBuilderV2
// Author           : Alex Bradley
// Created          : 08-09-2016
//
// Last Modified By : Alex Bradley
// Last Modified On : 08-09-2016
// ***********************************************************************
// <copyright file="PropertySetCollection.cs" company="AB Consulting">
//     Copyright (c) AB Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Collections.Generic;
using System.Collections.ObjectModel;
using CoBuilder.Core.Domain;
using CoBuilder.Core.Interfaces;

namespace CoBuilder.Core.Collections
{
    /// <summary>
    /// Class PropertySetCollection.
    /// </summary>
    /// <seealso cref="System.Collections.ObjectModel.ReadOnlyCollection{CoBuilder.Core.Domain.BimPropertySet}" />
    /// <seealso cref="CoBuilder.Core.Interfaces.IPropertySetCollection" />
    public class PropertySetCollection : ReadOnlyCollection<BimPropertySet>, IPropertySetCollection
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PropertySetCollection"/> class.
        /// </summary>
        /// <param name="propertySets">The property sets.</param>
        public PropertySetCollection(IList<BimPropertySet> propertySets) : base(propertySets)
        {
        }
    }
}