// ***********************************************************************
// Assembly         : CoBuilderV2
// Author           : Alex Bradley
// Created          : 08-09-2016
//
// Last Modified By : Alex Bradley
// Last Modified On : 08-09-2016
// ***********************************************************************
// <copyright file="IBimProperty.cs" company="AB Consulting">
//     Copyright (c) AB Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace CoBuilder.Core.Domain
{
    /// <summary>
    /// Interface IBimProperty
    /// </summary>
    public interface IBimProperty
    {
        /// <summary>
        /// Gets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        string Id { get; }
        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>The name.</value>
        string Name { get; }
        /// <summary>
        /// Gets the value.
        /// </summary>
        /// <value>The value.</value>
        string Value { get; }
        /// <summary>
        /// Gets the unit.
        /// </summary>
        /// <value>The unit.</value>
        string Unit { get; }
    }
}