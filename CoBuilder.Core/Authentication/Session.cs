// ***********************************************************************
// Assembly         : CoBuilderV2
// Author           : Alex Bradley
// Created          : 08-09-2016
//
// Last Modified By : Alex Bradley
// Last Modified On : 11-08-2016
// ***********************************************************************
// <copyright file="Session.cs" company="AB Consulting">
//     Copyright (c) AB Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Threading.Tasks;
using CoBuilder.Core.Enums;
using CoBuilder.Core.Interfaces;
using CoBuilder.Core.RestModels;

namespace CoBuilder.Core.Authentication
{

    /// <summary>
    /// Class Session.
    /// </summary>
    /// <seealso cref="CoBuilder.Core.Interfaces.ISession" />
    public class Session : ISession
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Session"/> class.
        /// </summary>
        public Session() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="Session"/> class.
        /// </summary>
        /// <param name="loginResult">The login result.</param>
        /// <param name="username">The username.</param>
        /// <param name="pass">The pass.</param>
        public Session(LoginResult loginResult, string username, string pass)
        {
            UserId = username;
            Pass = pass;
            AccessToken = loginResult.TokenData;
            ContactId = loginResult.ContactId;
            UserInfo = new UserInfo
            {
                AdminName = loginResult.AdminName,
                CanWrite = loginResult.CanWrite,
                CompanyName = loginResult.CompanyName
            };
        }

        /// <summary>
        /// Gets or sets the user identifier.
        /// </summary>
        /// <value>The user identifier.</value>
        public string UserId { get; set; }
        /// <summary>
        /// Gets or sets the pass.
        /// </summary>
        /// <value>The pass.</value>
        public string Pass { get; set; }
        /// <summary>
        /// Gets or sets the access token.
        /// </summary>
        /// <value>The access token.</value>
        public string AccessToken { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether this instance can sign out.
        /// </summary>
        /// <value><c>true</c> if this instance can sign out; otherwise, <c>false</c>.</value>
        public bool CanSignOut { get; set; }
        /// <summary>
        /// Gets or sets the application identifier.
        /// </summary>
        /// <value>The application identifier.</value>
        public PluginApp AppId { get; set; }
        /// <summary>
        /// Gets or sets the contact identifier.
        /// </summary>
        /// <value>The contact identifier.</value>
        public Guid ContactId { get; set; }
        /// <summary>
        /// Gets or sets the user information.
        /// </summary>
        /// <value>The user information.</value>
        public UserInfo UserInfo { get; set; }

        /// <summary>
        /// Clears this instance.
        /// </summary>
        public virtual void Clear()
        {
            UserId = null;
            AccessToken = null;
            CanSignOut = false;
            AppId = PluginApp.Unknown;
            ContactId = Guid.Empty;
            UserInfo = null;
        }

        /// <summary>
        /// Updates the specified result.
        /// </summary>
        /// <param name="result">The result.</param>
        /// <param name="username">The username.</param>
        /// <param name="pass">The pass.</param>
        /// <param name="canSignOut">if set to <c>true</c> [can sign out].</param>
        public void Update(LoginResult result, string username, string pass, bool canSignOut)
        {
            UserId = username;
            AccessToken = result.TokenData;
            ContactId = result.ContactId;
            UserInfo = new UserInfo
            {
                AdminName = result.AdminName,
                CanWrite = result.CanWrite,
                CompanyName = result.CompanyName
            };
            Pass = pass;
            CanSignOut = canSignOut;
        }

        /// <summary>
        /// Updates the specified session.
        /// </summary>
        /// <param name="session">The session.</param>
        public void Update(ISession session)
        {
            UserId = session.UserId;
            AccessToken = session.AccessToken;
            CanSignOut = session.CanSignOut;
            AppId = session.AppId;
            ContactId = session.ContactId;
            UserInfo = session.UserInfo;
            Pass = session.Pass;
        }
    }
}