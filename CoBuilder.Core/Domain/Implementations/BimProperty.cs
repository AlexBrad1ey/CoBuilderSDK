// ***********************************************************************
// Assembly         : CoBuilderV2
// Author           : Alex Bradley
// Created          : 08-09-2016
//
// Last Modified By : Alex Bradley
// Last Modified On : 08-09-2016
// ***********************************************************************
// <copyright file="BimProperty.cs" company="AB Consulting">
//     Copyright (c) AB Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace CoBuilder.Core.Domain
{
    /// <summary>
    /// Class BimProperty.
    /// </summary>
    /// <seealso cref="CoBuilder.Core.Domain.IBimProperty" />
    public class BimProperty : IBimProperty
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public string Id { get; set; }
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get; set; }
        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>The value.</value>
        public string Value { get; set; }
        /// <summary>
        /// Gets or sets the unit.
        /// </summary>
        /// <value>The unit.</value>
        public string Unit { get; set; }
    }
}