// ***********************************************************************
// Assembly         : CoBuilderV2
// Author           : Alex Bradley
// Created          : 08-09-2016
//
// Last Modified By : Alex Bradley
// Last Modified On : 08-09-2016
// ***********************************************************************
// <copyright file="PropertiesCollection.cs" company="AB Consulting">
//     Copyright (c) AB Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using CoBuilder.Core.Domain;
using CoBuilder.Core.Interfaces;

namespace CoBuilder.Core.Collections
{
    /// <summary>
    /// Class PropertiesCollection.
    /// </summary>
    /// <seealso cref="System.Collections.ObjectModel.ReadOnlyCollection{CoBuilder.Core.Domain.BimProperty}" />
    /// <seealso cref="CoBuilder.Core.Interfaces.IPropertiesCollection" />
    public class PropertiesCollection : ReadOnlyCollection<BimProperty>, IPropertiesCollection
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PropertiesCollection"/> class.
        /// </summary>
        /// <param name="properties">The properties.</param>
        /// <param name="productId">The product identifier.</param>
        public PropertiesCollection(IList<BimProperty> properties, int productId) : base(properties)
        {
ProductId = productId;

        }

        /// <summary>
        /// Gets or sets the product identifier.
        /// </summary>
        /// <value>The product identifier.</value>
        public int ProductId {get; set; }

    }
}