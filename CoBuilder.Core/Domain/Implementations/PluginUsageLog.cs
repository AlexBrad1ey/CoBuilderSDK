// ***********************************************************************
// Assembly         : CoBuilderV2
// Author           : Alex Bradley
// Created          : 08-09-2016
//
// Last Modified By : Alex Bradley
// Last Modified On : 08-09-2016
// ***********************************************************************
// <copyright file="PluginUsageLog.cs" company="AB Consulting">
//     Copyright (c) AB Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using CoBuilder.Core.Enums;

namespace CoBuilder.Core.Domain
{
    /// <summary>
    /// Class PluginUsageLog.
    /// </summary>
    public class PluginUsageLog
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public PluginApp Id { get; set; }
        /// <summary>
        /// Gets or sets the program version.
        /// </summary>
        /// <value>The program version.</value>
        public string ProgramVersion { get; set; }
        /// <summary>
        /// Gets or sets the username.
        /// </summary>
        /// <value>The username.</value>
        public string Username { get; set; }
        /// <summary>
        /// Gets or sets the project identifier.
        /// </summary>
        /// <value>The project identifier.</value>
        public string ProjectId { get; set; }
        /// <summary>
        /// Gets or sets the object identifier.
        /// </summary>
        /// <value>The object identifier.</value>
        public string ObjectId { get; set; }
        /// <summary>
        /// Gets or sets the element room bounding.
        /// </summary>
        /// <value>The element room bounding.</value>
        public string ElementRoomBounding { get; set; }
        /// <summary>
        /// Gets or sets the element area.
        /// </summary>
        /// <value>The element area.</value>
        public string ElementArea { get; set; }
        /// <summary>
        /// Gets or sets the element level.
        /// </summary>
        /// <value>The element level.</value>
        public string ElementLevel { get; set; }
        /// <summary>
        /// Gets or sets the site coordinates.
        /// </summary>
        /// <value>The site coordinates.</value>
        public string SiteCoordinates { get; set; }
        /// <summary>
        /// Gets or sets the project address.
        /// </summary>
        /// <value>The project address.</value>
        public string ProjectAddress { get; set; }
        /// <summary>
        /// Gets or sets the name of the building.
        /// </summary>
        /// <value>The name of the building.</value>
        public string BuildingName { get; set; }
        /// <summary>
        /// Gets or sets the name of the project.
        /// </summary>
        /// <value>The name of the project.</value>
        public string ProjectName { get; set; }
        /// <summary>
        /// Gets or sets the project location.
        /// </summary>
        /// <value>The project location.</value>
        public string ProjectLocation { get; set; }
        /// <summary>
        /// Gets or sets the client identifier.
        /// </summary>
        /// <value>The client identifier.</value>
        public string ClientId { get; set; }
        /// <summary>
        /// Gets or sets the product identifier.
        /// </summary>
        /// <value>The product identifier.</value>
        public string ProductId { get; set; }
        /// <summary>
        /// Gets or sets the workplace identifier.
        /// </summary>
        /// <value>The workplace identifier.</value>
        public string WorkplaceId { get; set; }
    }
}