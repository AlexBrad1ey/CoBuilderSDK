// ***********************************************************************
// Assembly         : CoBuilder.Navisworks
// Author           : Alex Bradley
// Created          : 09-09-2016
//
// Last Modified By : Alex Bradley
// Last Modified On : 11-08-2016
// ***********************************************************************
// <copyright file="CoBuilderNavisworksCommandHandler.cs" company="AB Consulting">
//     Copyright (c) AB Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Diagnostics;
using System.Linq;
using Autodesk.Navisworks.Api;
using Autodesk.Navisworks.Api.Plugins;
using CoBuilder.Service;
using CoBuilder.Service.Commands;
using CoBuilder.Service.Helpers;

namespace CoBuilder.Navisworks.Plugins
{
    /// <summary>
    /// Class CoBuilderNavisworksCommandHandler.
    /// </summary>
    /// <seealso cref="Autodesk.Navisworks.Api.Plugins.CommandHandlerPlugin" />
    [Plugin("CoBuilderNavisworksCommandHandler", "ABc", DisplayName = "CoBuilder Navisworks")]
    [RibbonLayout("CoBuilderRibbon.xaml")]
    [RibbonTab("CoBuilderStartTab", DisplayName = "CoBuilder")]
    [RibbonTab("CoBuilderMainTab", DisplayName = "CoBuilder Pro", LoadForCanExecute = true)]
    [Command("WebsiteCommand", DisplayName = "CoBuilder Website", LargeIcon = "Resources//CoBuilder_loginSmall.png")]
    [Command("WebsiteCommand2", DisplayName = "CoBuilder Website", LargeIcon = "Resources//CoBuilder_loginSmall.png")]
    [Command("WorkplaceCommand", DisplayName = "Set Workplace", LargeIcon = "Resources//Globe-icon_Small.png")]
    [Command("LoginCommand", DisplayName = "CoBuilder Login", LargeIcon = "Resources//logIn-icon-Small.png")]
    [Command("LogOutCommand", DisplayName = "CoBuilder Logout", LargeIcon = "Resources//logout-icon-Small.png")]
    [Command("ConnectCommand", DisplayName = "Link Product to Elements", LargeIcon = "Resources//Select_Arrow.bmp")]
    [Command("RemoveCommand", DisplayName = "Remove Products from Elements",
        LargeIcon = "Resources//Remove.png")]
    [Command("ConfigurationCommand", DisplayName = "CoBuilder Configuration", LargeIcon = "Resources//Setting-Small.png")]
    [Command("RefreshCommand", DisplayName = "Refresh Products", LargeIcon = "Resources//Globe-icon_Small.png")]
    public class CoBuilderNavisworksCommandHandler : CommandHandlerPlugin
    {
        /// <summary>
        /// The _co builder service
        /// </summary>
        private readonly CoBuilderService _coBuilderService;

        /// <summary>
        /// The _logged in
        /// </summary>
        private bool _loggedIn;

        /// <summary>
        /// Initializes a new instance of the <see cref="CoBuilderNavisworksCommandHandler"/> class.
        /// </summary>
        public CoBuilderNavisworksCommandHandler()
        {
            var serviceConfig = new ServiceConfiguration
            {
                AppConfig = new NavisworksAppConfig(),
                ContainerConfig = new NavisworksRegistry(),
                UseDefinedContainerConfig = true
            };

            _coBuilderService = CoBuilderService.Initiate(serviceConfig);
            Debug.WriteLine(_coBuilderService.whatDoIHave());
            if (_coBuilderService.Session != null) _loggedIn = _coBuilderService.Session.LoggedIn;
        }

        /// <summary>
        /// Called when a command is executed
        /// </summary>
        /// <param name="name">The name of the command</param>
        /// <param name="parameters">Paramaters to be passed to the command</param>
        /// <returns>System.Int32.</returns>
        public override int ExecuteCommand(string name, params string[] parameters)
        {
            try
            {
                switch (name)
                {
                    case "WebsiteCommand":
                    case "WebsiteCommand2":
                    {
                        Settings.CoBuilderSite();
                        break;
                    }
                    case "LoginCommand":
                    {
                        _loggedIn = new LoginCommand<ModelItem>().Execute();
                        break;
                    }
                    case "LogOutCommand":
                    {
                        new LogOutCommand().Execute();
                        _loggedIn = false;
                        break;
                    }
                    case "WorkplaceCommand":
                    {
                        var command = new ChangeWorkplaceCommand();
                        command.Execute();
                        break;
                    }
                    case "ConnectCommand":
                    {
                        var command = new ConnectCommand<ModelItem>();
                        command.Execute();
                        break;
                    }

                    case "RemoveCommand":
                    {
                        var command = new RemoveCommand<ModelItem>();
                        command.Execute();
                        var result = command.RemovalResult;
                        break;
                    }
                    case "ConfigurationCommand":
                    {
                        var command = new ConfigurationCommand();
                        command.Execute();
                        break;
                    }
                    case "RefreshCommand":
                    {
                        var command = new RefreshCommand<ModelItem>();
                        command.Execute();
                        break;
                    }
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
            }

            return 0;
        }

        /// <summary>
        /// Called to determine if a ribbon tab can be executed
        /// </summary>
        /// <param name="name">The name of the ribbon tab</param>
        /// <returns><c>true</c> if this instance [can execute ribbon tab] the specified name; otherwise, <c>false</c>.</returns>
        public override bool CanExecuteRibbonTab(string name)
        {
            if (!_loggedIn)
            {
                return name == "CoBuilderStartTab";
            }
            return name == "CoBuilderMainTab";
        }

        /// <summary>
        /// Called to determine if a command can be executed
        /// </summary>
        /// <param name="name">The name of the command</param>
        /// <returns>CommandState.</returns>
        public override CommandState CanExecuteCommand(string name)
        {
            switch (name)
            {
                case "LoginCommand":
                {
                    return new CommandState(!Application.ActiveDocument.IsClear);
                }
                case "ConnectCommand":
                case "RemoveCommand":
                {
                    return new CommandState(!Application.ActiveDocument.CurrentSelection.IsEmpty && _coBuilderService.Session.WorkplaceSet);
                }
                default:
                {
                    return base.CanExecuteCommand(name);
                }
            }
        }
    }
}