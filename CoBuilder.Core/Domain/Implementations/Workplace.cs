// ***********************************************************************
// Assembly         : CoBuilderV2
// Author           : Alex Bradley
// Created          : 08-09-2016
//
// Last Modified By : Alex Bradley
// Last Modified On : 08-09-2016
// ***********************************************************************
// <copyright file="Workplace.cs" company="AB Consulting">
//     Copyright (c) AB Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using CoBuilder.Core.Enums;

namespace CoBuilder.Core.Domain
{
    /// <summary>
    /// Class Workplace.
    /// </summary>
    /// <seealso cref="CoBuilder.Core.Domain.IWorkplace" />
    public class Workplace : IWorkplace
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public int Id { get; set; }
        /// <summary>
        /// Gets or sets the MSDS identifier.
        /// </summary>
        /// <value>The MSDS identifier.</value>
        public Guid? MsdsId { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether this instance is non compliant with filters.
        /// </summary>
        /// <value><c>true</c> if this instance is non compliant with filters; otherwise, <c>false</c>.</value>
        public bool IsNonCompliantWithFilters { get; set; }
        /// <summary>
        /// Gets or sets the parent identifier.
        /// </summary>
        /// <value>The parent identifier.</value>
        public int ParentId { get; set; }
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get; set; }
        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>The type.</value>
        public WorkplaceDataType Type { get; set; }
        /// <summary>
        /// Gets or sets the data.
        /// </summary>
        /// <value>The data.</value>
        public string Data { get; set; }
        /// <summary>
        /// Gets or sets the coordinates.
        /// </summary>
        /// <value>The coordinates.</value>
        public GeoAddress Coordinates { get; set; }
        /// <summary>
        /// Gets or sets the full address.
        /// </summary>
        /// <value>The full address.</value>
        public string FullAddress { get; set; }
        /// <summary>
        /// Gets or sets the name of the workplace.
        /// </summary>
        /// <value>The name of the workplace.</value>
        public string WorkplaceName { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether this instance is imported.
        /// </summary>
        /// <value><c>true</c> if this instance is imported; otherwise, <c>false</c>.</value>
        public bool IsImported { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="Workplace"/> is expired.
        /// </summary>
        /// <value><c>true</c> if expired; otherwise, <c>false</c>.</value>
        public bool Expired { get; set; }
        /// <summary>
        /// Gets or sets the distance.
        /// </summary>
        /// <value>The distance.</value>
        public double Distance { get; set; }
        /// <summary>
        /// Gets or sets the address.
        /// </summary>
        /// <value>The address.</value>
        public string Address { get; set; }
        /// <summary>
        /// Gets or sets the city.
        /// </summary>
        /// <value>The city.</value>
        public string City { get; set; }
        /// <summary>
        /// Gets or sets the post code.
        /// </summary>
        /// <value>The post code.</value>
        public string PostCode { get; set; }
    }
}