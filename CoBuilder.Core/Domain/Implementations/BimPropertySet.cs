// ***********************************************************************
// Assembly         : CoBuilderV2
// Author           : Alex Bradley
// Created          : 08-09-2016
//
// Last Modified By : Alex Bradley
// Last Modified On : 08-09-2016
// ***********************************************************************
// <copyright file="BimPropertySet.cs" company="AB Consulting">
//     Copyright (c) AB Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace CoBuilder.Core.Domain
{
    /// <summary>
    /// Class BimPropertySet.
    /// </summary>
    /// <seealso cref="CoBuilder.Core.Domain.IBimPropertySet" />
    public class BimPropertySet : IBimPropertySet
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
        /// Gets or sets the tag identifier.
        /// </summary>
        /// <value>The tag identifier.</value>
        public int TagId { get; set; }
        /// <summary>
        /// Gets or sets the name of the tag.
        /// </summary>
        /// <value>The name of the tag.</value>
        public string TagName { get; set; }
    }
}