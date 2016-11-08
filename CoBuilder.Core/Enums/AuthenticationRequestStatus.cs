// ***********************************************************************
// Assembly         : CoBuilderV2
// Author           : Alex Bradley
// Created          : 08-09-2016
//
// Last Modified By : Alex Bradley
// Last Modified On : 08-09-2016
// ***********************************************************************
// <copyright file="AuthenticationRequestStatus.cs" company="AB Consulting">
//     Copyright (c) AB Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace CoBuilder.Core.Enums
{
    /// <summary>
    /// Enum AuthenticationRequestStatus
    /// </summary>
    public enum AuthenticationRequestStatus
    {
        /// <summary>
        /// The ok
        /// </summary>
        Ok = 0,
        /// <summary>
        /// The authentication failed
        /// </summary>
        AuthenticationFailed = 1,
        /// <summary>
        /// The token expired
        /// </summary>
        TokenExpired = 2,
        /// <summary>
        /// The token not provided
        /// </summary>
        TokenNotProvided = 3,
        /// <summary>
        /// The server failed
        /// </summary>
        ServerFailed = 4,
        /// <summary>
        /// The no such token
        /// </summary>
        NoSuchToken = 5,
        /// <summary>
        /// The contact identifier missing or wrong
        /// </summary>
        ContactIdMissingOrWrong = 6,
        /// <summary>
        /// The error
        /// </summary>
        Error = 7
    }
}