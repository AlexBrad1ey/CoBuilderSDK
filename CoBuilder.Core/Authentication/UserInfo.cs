// ***********************************************************************
// Assembly         : CoBuilderV2
// Author           : Alex Bradley
// Created          : 08-09-2016
//
// Last Modified By : Alex Bradley
// Last Modified On : 08-09-2016
// ***********************************************************************
// <copyright file="UserInfo.cs" company="AB Consulting">
//     Copyright (c) AB Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace CoBuilder.Core.Authentication
{
    /// <summary>
    /// Class UserInfo.
    /// </summary>
    public class UserInfo
    {
        /// <summary>
        /// Gets or sets a value indicating whether this instance can write.
        /// </summary>
        /// <value><c>true</c> if this instance can write; otherwise, <c>false</c>.</value>
        public bool CanWrite { get; set; }
        /// <summary>
        /// Gets or sets the name of the admin.
        /// </summary>
        /// <value>The name of the admin.</value>
        public string AdminName { get; set; }
        /// <summary>
        /// Gets or sets the name of the company.
        /// </summary>
        /// <value>The name of the company.</value>
        public string CompanyName { get; set; }
    }
}