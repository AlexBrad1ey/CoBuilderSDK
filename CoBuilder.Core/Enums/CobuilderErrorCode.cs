// ***********************************************************************
// Assembly         : CoBuilderV2
// Author           : Alex Bradley
// Created          : 08-09-2016
//
// Last Modified By : Alex Bradley
// Last Modified On : 08-09-2016
// ***********************************************************************
// <copyright file="CobuilderErrorCode.cs" company="AB Consulting">
//     Copyright (c) AB Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace CoBuilder.Core.Enums
{
    /// <summary>
    /// Enum CoBuilderErrorCode
    /// </summary>
    public enum CoBuilderErrorCode
    {
        /// <summary>
        /// The invalid request
        /// </summary>
        InvalidRequest,
        /// <summary>
        /// The authentication failure
        /// </summary>
        AuthenticationFailure,
        /// <summary>
        /// The HTTP exception
        /// </summary>
        HttpException,
        /// <summary>
        /// The general exception
        /// </summary>
        GeneralException,
        /// <summary>
        /// The un initiated service
        /// </summary>
        UnInitiatedService,
        /// <summary>
        /// The invalid configuration
        /// </summary>
        InvalidConfiguration
    }
}