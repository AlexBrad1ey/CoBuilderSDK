// ***********************************************************************
// Assembly         : CoBuilderV2
// Author           : Alex Bradley
// Created          : 08-09-2016
//
// Last Modified By : Alex Bradley
// Last Modified On : 08-09-2016
// ***********************************************************************
// <copyright file="IWorkplace.cs" company="AB Consulting">
//     Copyright (c) AB Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using CoBuilder.Core.Enums;

namespace CoBuilder.Core.Domain
{
    /// <summary>
    /// Interface IWorkplace
    /// </summary>
    public interface IWorkplace
    {
        /// <summary>
        /// Gets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        int Id { get; }
        /// <summary>
        /// Gets the MSDS identifier.
        /// </summary>
        /// <value>The MSDS identifier.</value>
        Guid? MsdsId { get; }
        /// <summary>
        /// Gets a value indicating whether this instance is non compliant with filters.
        /// </summary>
        /// <value><c>true</c> if this instance is non compliant with filters; otherwise, <c>false</c>.</value>
        bool IsNonCompliantWithFilters { get; }
        /// <summary>
        /// Gets the parent identifier.
        /// </summary>
        /// <value>The parent identifier.</value>
        int ParentId { get; }
        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>The name.</value>
        string Name { get; }
        /// <summary>
        /// Gets the type.
        /// </summary>
        /// <value>The type.</value>
        WorkplaceDataType Type { get; }
        /// <summary>
        /// Gets the data.
        /// </summary>
        /// <value>The data.</value>
        string Data { get; }
        /// <summary>
        /// Gets the coordinates.
        /// </summary>
        /// <value>The coordinates.</value>
        GeoAddress Coordinates { get; }
        /// <summary>
        /// Gets the full address.
        /// </summary>
        /// <value>The full address.</value>
        string FullAddress { get; }
        /// <summary>
        /// Gets the name of the workplace.
        /// </summary>
        /// <value>The name of the workplace.</value>
        string WorkplaceName { get; }
        /// <summary>
        /// Gets a value indicating whether this instance is imported.
        /// </summary>
        /// <value><c>true</c> if this instance is imported; otherwise, <c>false</c>.</value>
        bool IsImported { get; }
        /// <summary>
        /// Gets a value indicating whether this <see cref="IWorkplace"/> is expired.
        /// </summary>
        /// <value><c>true</c> if expired; otherwise, <c>false</c>.</value>
        bool Expired { get; }
        /// <summary>
        /// Gets the distance.
        /// </summary>
        /// <value>The distance.</value>
        double Distance { get; }
        /// <summary>
        /// Gets the address.
        /// </summary>
        /// <value>The address.</value>
        string Address { get; }
        /// <summary>
        /// Gets the city.
        /// </summary>
        /// <value>The city.</value>
        string City { get; }
        /// <summary>
        /// Gets the post code.
        /// </summary>
        /// <value>The post code.</value>
        string PostCode { get; }
    }
}