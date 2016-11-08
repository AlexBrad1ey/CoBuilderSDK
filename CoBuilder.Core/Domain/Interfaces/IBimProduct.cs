// ***********************************************************************
// Assembly         : CoBuilderV2
// Author           : Alex Bradley
// Created          : 08-09-2016
//
// Last Modified By : Alex Bradley
// Last Modified On : 08-09-2016
// ***********************************************************************
// <copyright file="IBimProduct.cs" company="AB Consulting">
//     Copyright (c) AB Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace CoBuilder.Core.Domain
{
    /// <summary>
    /// Interface IBimProduct
    /// </summary>
    public interface IBimProduct
    {
        /// <summary>
        /// Gets the delivered by.
        /// </summary>
        /// <value>The delivered by.</value>
        string DeliveredBy { get; }
        /// <summary>
        /// Gets a value indicating whether this <see cref="IBimProduct"/> is dop.
        /// </summary>
        /// <value><c>null</c> if [dop] contains no value, <c>true</c> if [dop]; otherwise, <c>false</c>.</value>
        bool? DOP { get;}
        /// <summary>
        /// Gets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        int Id { get; }
        /// <summary>
        /// Gets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        string Identifier { get; }
        /// <summary>
        /// Gets a value indicating whether this instance is created from scan.
        /// </summary>
        /// <value><c>true</c> if this instance is created from scan; otherwise, <c>false</c>.</value>
        bool IsCreatedFromScan { get; }
        /// <summary>
        /// Gets a value indicating whether this instance is risk assessed.
        /// </summary>
        /// <value><c>true</c> if this instance is risk assessed; otherwise, <c>false</c>.</value>
        bool IsRiskAssessed { get; }
        /// <summary>
        /// Gets the link.
        /// </summary>
        /// <value>The link.</value>
        string Link { get; }
        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>The name.</value>
        string Name { get; }
        /// <summary>
        /// Gets the product types.
        /// </summary>
        /// <value>The product types.</value>
        string ProductTypes { get; }
        /// <summary>
        /// Gets the name of the supplier.
        /// </summary>
        /// <value>The name of the supplier.</value>
        string SupplierName { get; }
    }
}