// ***********************************************************************
// Assembly         : CoBuilderV2
// Author           : Alex Bradley
// Created          : 08-09-2016
//
// Last Modified By : Alex Bradley
// Last Modified On : 08-09-2016
// ***********************************************************************
// <copyright file="IBimPropertySet.cs" company="AB Consulting">
//     Copyright (c) AB Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace CoBuilder.Core.Domain
{
    /// <summary>
    /// Interface IBimPropertySet
    /// </summary>
    public interface IBimPropertySet
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
        /// Gets the tag identifier.
        /// </summary>
        /// <value>The tag identifier.</value>
        int TagId { get; }
        /// <summary>
        /// Gets the name of the tag.
        /// </summary>
        /// <value>The name of the tag.</value>
        string TagName { get; }
    }
}