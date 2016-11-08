// ***********************************************************************
// Assembly         : CoBuilderV2
// Author           : Alex Bradley
// Created          : 08-09-2016
//
// Last Modified By : Alex Bradley
// Last Modified On : 08-09-2016
// ***********************************************************************
// <copyright file="ProductsCollection.cs" company="AB Consulting">
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
    /// Class ProductsCollection.
    /// </summary>
    /// <seealso cref="System.Collections.ObjectModel.ReadOnlyCollection{CoBuilder.Core.Domain.BimProduct}" />
    /// <seealso cref="CoBuilder.Core.Interfaces.IProductsCollection" />
    public class ProductsCollection : ReadOnlyCollection<BimProduct>, IProductsCollection
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductsCollection"/> class.
        /// </summary>
        /// <param name="products">The products.</param>
        public ProductsCollection(IList<BimProduct> products): base(products)
        { 
        }
    }
}