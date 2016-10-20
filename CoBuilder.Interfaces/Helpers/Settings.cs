// ***********************************************************************
// Assembly         : CoBuilder.Common
// Author           : Alex Bradley
// Created          : 04-19-2016
//
// Last Modified By : Alex Bradley
// Last Modified On : 07-20-2016
// ***********************************************************************
// <copyright file="CommonSettings.cs" company="AB Consulting">
//     Copyright © AB Consulting 2016
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using CoBuilder.Service.Properties;
using Microsoft.Win32;
using OCSLRevitUtils.OCSL;

namespace CoBuilder.Service.Helpers
{
    /// <summary>
    /// Class CommonSettings. Common Values used throughout the SDK and eerror reporting methods
    /// </summary>
    public class Settings
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Settings"/> class.
        /// </summary>
        public Settings()
        {
            _utils = new OCADUtils();
            UpdateErrorPath(Properties.Settings.Default.ErrorPath);

            _logging = true;
            _fixed = true;

        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Updates the error path.
        /// </summary>
        /// <param name="value">The value.</param>
        private void UpdateErrorPath(string value)
        {
            Properties.Settings.Default.ErrorPath = value;
            SettingsCache[_logPath] = value;
            _utils.SortHKCURegKey(ref _path, ref _logPath, ref value, RegistryValueKind.String);
        }

        #endregion

        #region Private Fields

        /// <summary>
        /// The settings cache
        /// </summary>
        private static readonly Dictionary<string, string> SettingsCache = new Dictionary<string, string>();

        /// <summary>
        /// The _code
        /// </summary>
        private static string _code = "Code";
        /// <summary>
        /// The _do built in
        /// </summary>
        private static string _doBuiltIn = "DoBuiltIn";
        /// <summary>
        /// The _false
        /// </summary>
        private static string _false = false.ToString();
        /// <summary>
        /// The _true
        /// </summary>
        private static readonly string _true = true.ToString();
        /// <summary>
        /// The _log path
        /// </summary>
        private static string _logPath = "LogPath";
        /// <summary>
        /// The _N5350
        /// </summary>
        private static string _n5350 = "5350";
        /// <summary>
        /// The _name
        /// </summary>
        private static string _name = "Name";
        /// <summary>
        /// The _password
        /// </summary>
        private static string _password = "Password*";
        /// <summary>
        /// The _path
        /// </summary>
        private static string _path = "Software\\cobuilder";
        /// <summary>
        /// The _save code
        /// </summary>
        private static string _saveCode = "SaveCode";
        /// <summary>
        /// The _user
        /// </summary>
        private static string _user = "User";
        /// <summary>
        /// The _work place
        /// </summary>
        private static string _workPlace = "WorkPlace";

        /// <summary>
        /// The _utils
        /// </summary>
        private readonly OCADUtils _utils;
        /// <summary>
        /// The _fixed
        /// </summary>
#pragma warning disable 414
        private bool _fixed;
#pragma warning restore 414
        /// <summary>
        /// The _logging
        /// </summary>
        private bool _logging;

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets the username.
        /// </summary>
        /// <value>The username.</value>
        public string Username
        {
            get
            {
                return SettingsCache.ContainsKey(_user)
                    ? SettingsCache[_user]
                    : SettingsCache[_user] = _utils.ReadHKCUReg(ref _path, ref _user, ref _name);
            }
            set
            {
                _utils.SortHKCURegKey(ref _path, ref _user, ref value, RegistryValueKind.String);
                SettingsCache[_user] = value;
            }
        }

        /// <summary>
        /// Gets the password.
        /// </summary>
        /// <value>The password.</value>
        public string Password
        {
            get
            {
                return SettingsCache.ContainsKey(_code)
                    ? SettingsCache[_code]
                    : SettingsCache[_code] = _utils.ReadHKCUReg(ref _path, ref _code, ref _password);
            }
            private set
            {
                _utils.SortHKCURegKey(ref _path, ref _code, ref value, RegistryValueKind.String);
                SettingsCache[_code] = value;
            }
        }

        /// <summary>
        /// Gets or sets the work place.
        /// </summary>
        /// <value>The work place.</value>
        public string WorkPlace
        {
            get
            {
                return SettingsCache.ContainsKey(_workPlace)
                    ? SettingsCache[_workPlace]
                    : SettingsCache[_workPlace] = _utils.ReadHKCUReg(ref _path, ref _workPlace, ref _n5350);
            }
            set
            {
                _utils.SortHKCURegKey(ref _path, ref _workPlace, ref value, RegistryValueKind.String);
                SettingsCache[_workPlace] = value;
            }
        }

        /// <summary>
        /// Gets or sets the error path.
        /// </summary>
        /// <value>The error path.</value>
        public string ErrorPath
        {
            get
            {
                return SettingsCache.ContainsKey(_logPath)
                    ? SettingsCache[_logPath]
                    : SettingsCache[_logPath] = _utils.ReadHKCUReg(ref _path, ref _logPath, ref _false);
            }
            set { UpdateErrorPath(value); }
        }

        /// <summary>
        /// Gets a value indicating whether [use built in].
        /// </summary>
        /// <value><c>true</c> if [use built in]; otherwise, <c>false</c>.</value>
        public bool UseBuiltIn
        {
            get { return DoBuiltIn == _true; }
            private set { DoBuiltIn = value.ToString(); }
        }

        /// <summary>
        /// Gets a value indicating whether [password saved].
        /// </summary>
        /// <value><c>true</c> if [password saved]; otherwise, <c>false</c>.</value>
        public bool PasswordSaved => SaveCode == "True";

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="Settings"/> is logging.
        /// </summary>
        /// <value><c>true</c> if logging; otherwise, <c>false</c>.</value>
        public bool Logging
        {
            get { return _logging; }
#pragma warning disable RECS0029 // Warns about property or indexer setters and event adders or removers that do not use the value parameter
            set
            {
#if !DEBUG
                _logging = value;
#endif
#pragma warning restore RECS0029 // Warns about property or indexer setters and event adders or removers that do not use the value parameter
            }
        }

        #endregion

        #region Private Properties

        /// <summary>
        /// Gets or sets the save code.
        /// </summary>
        /// <value>The save code.</value>
        private string SaveCode
        {
            get
            {
                return SettingsCache.ContainsKey(_saveCode)
                    ? SettingsCache[_saveCode]
                    : SettingsCache[_saveCode] = _utils.ReadHKCUReg(ref _path, ref _saveCode, ref _false);
            }
            set
            {
                _utils.SortHKCURegKey(ref _path, ref _saveCode, ref value, RegistryValueKind.String);
                SettingsCache[_saveCode] = value;
            }
        }

        /// <summary>
        /// Gets or sets the do built in.
        /// </summary>
        /// <value>The do built in.</value>
        private string DoBuiltIn
        {
            get
            {
                return SettingsCache.ContainsKey(_doBuiltIn)
                    ? SettingsCache[_doBuiltIn]
                    : SettingsCache[_doBuiltIn] = _utils.ReadHKCUReg(ref _path, ref _doBuiltIn, ref _false);
            }
            set
            {
                _utils.SortHKCURegKey(ref _path, ref _doBuiltIn, ref value, RegistryValueKind.String);
                SettingsCache[_doBuiltIn] = value;
            }
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Coes the builder site.
        /// </summary>
        public static void CoBuilderSite()
        {
            WebLaunch(Resources.CoBuilderHome);
        }

        /// <summary>
        /// Webs the launch.
        /// </summary>
        /// <param name="uri">The URI.</param>
        public static void WebLaunch(string uri)
        {
            try
            {
                Process.Start(uri);
            }
            catch (Exception)
            {
                try
                {
                    Process.Start(uri);
                }
                catch (Exception)
                {
                    MessageBox.Show("Web Launch Error", "Cobuilder", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        /// <summary>
        /// Removes the password.
        /// </summary>
        public void RemovePassword()
        {
            Password = "";
            SaveCode = false.ToString();
        }

        /// <summary>
        /// Saves the password.
        /// </summary>
        /// <param name="password">The password.</param>
        public void SavePassword(string password)
        {
            Password = password;
            SaveCode = true.ToString();
        }

        /// <summary>
        /// Sets the built in.
        /// </summary>
        /// <param name="value">if set to <c>true</c> [value].</param>
        /// <param name="saveToReg">if set to <c>true</c> [save to reg].</param>
        public void SetBuiltIn(bool value, bool saveToReg)
        {
            if (saveToReg)
            {
                UseBuiltIn = value;
            }
            else
            {
                SettingsCache[_doBuiltIn] = value.ToString();
            }
        }

        /// <summary>
        /// Writes the log file.
        /// </summary>
        /// <param name="exception">The exception.</param>
        /// <param name="callingClass">The calling class.</param>
        /// <param name="callingMember">The calling member.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public bool WriteLogFile(Exception exception, string callingClass, string callingMember)
        {
            if (Logging)
            {
                try
                {
                    _utils.WriteLogFile(exception, $"{callingClass} {callingMember}");
                    return true;
                }
                catch
                {
                    return false;
                }
            }

            return false;
        }

        #endregion
    }
}