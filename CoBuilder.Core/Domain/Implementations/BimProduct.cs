// ***********************************************************************
// Assembly         : CoBuilderV2
// Author           : Alex Bradley
// Created          : 08-09-2016
//
// Last Modified By : Alex Bradley
// Last Modified On : 08-09-2016
// ***********************************************************************
// <copyright file="BimProduct.cs" company="AB Consulting">
//     Copyright (c) AB Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using CoBuilder.Core.Collections;

namespace CoBuilder.Core.Domain
{
    /// <summary>
    /// Class BimProduct.
    /// </summary>
    /// <seealso cref="CoBuilder.Core.Domain.IBimProduct" />
    public class BimProduct : IBimProduct
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public int Id { get; set; }
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get; set; }
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public string Identifier { get; set; }
        /// <summary>
        /// Gets or sets the link.
        /// </summary>
        /// <value>The link.</value>
        public string Link { get; set; }
        /// <summary>
        /// Gets or sets the product types.
        /// </summary>
        /// <value>The product types.</value>
        public string ProductTypes { get; set; }
        /// <summary>
        /// Gets or sets the name of the supplier.
        /// </summary>
        /// <value>The name of the supplier.</value>
        public string SupplierName { get; set; }
        /// <summary>
        /// Gets or sets the delivered by.
        /// </summary>
        /// <value>The delivered by.</value>
        public string DeliveredBy { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether this instance is risk assessed.
        /// </summary>
        /// <value><c>true</c> if this instance is risk assessed; otherwise, <c>false</c>.</value>
        public bool IsRiskAssessed { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="BimProduct"/> is dop.
        /// </summary>
        /// <value><c>null</c> if [dop] contains no value, <c>true</c> if [dop]; otherwise, <c>false</c>.</value>
        public bool? DOP { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether this instance is created from scan.
        /// </summary>
        /// <value><c>true</c> if this instance is created from scan; otherwise, <c>false</c>.</value>
        public bool IsCreatedFromScan { get; set; }
    }
}