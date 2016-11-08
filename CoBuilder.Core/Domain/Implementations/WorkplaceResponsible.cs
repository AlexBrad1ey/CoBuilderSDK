// ***********************************************************************
// Assembly         : CoBuilderV2
// Author           : Alex Bradley
// Created          : 08-09-2016
//
// Last Modified By : Alex Bradley
// Last Modified On : 08-09-2016
// ***********************************************************************
// <copyright file="WorkplaceResponsible.cs" company="AB Consulting">
//     Copyright (c) AB Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace CoBuilder.Core.Domain
{
    /// <summary>
    /// Class WorkplaceResponsible.
    /// </summary>
    public class WorkplaceResponsible
    {
        /// <summary>
        /// Gets or sets the name of the responsible.
        /// </summary>
        /// <value>The name of the responsible.</value>
        public string ResponsibleName { get; set; }
        /// <summary>
        /// Gets or sets the responsible email.
        /// </summary>
        /// <value>The responsible email.</value>
        public string ResponsibleEmail { get; set; }
        /// <summary>
        /// Gets or sets the responsible mobile.
        /// </summary>
        /// <value>The responsible mobile.</value>
        public string ResponsibleMobile { get; set; }
    }
}