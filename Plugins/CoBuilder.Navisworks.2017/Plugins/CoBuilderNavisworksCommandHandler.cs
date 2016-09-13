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
    [Command("ConnectCommand", DisplayName = "Link Product to Elements", LargeIcon = "Resources//logIn-icon-Small.png")]
    [Command("RemoveCommand", DisplayName = "Remove Products from Elements",
        LargeIcon = "Resources//logIn-icon-Small.png")]
    [Command("ConfigurationCommand", DisplayName = "CoBuilder Configuration", LargeIcon = "Resources//Setting-Small.png")]
    public class CoBuilderNavisworksCommandHandler : CommandHandlerPlugin
    {
        private readonly CoBuilderService _coBuilderService;

        private bool _loggedIn = false;

        public CoBuilderNavisworksCommandHandler()
        {
            var serviceConfig = new ServiceConfiguration()
            {
                AppConfig = new NavisworksAppConfig(),
                ContainerConfig = new NavisworksRegistry(),
                UseDefinedContainerConfig = true
            };

            _coBuilderService = CoBuilderService.Initiate(serviceConfig);
            Debug.WriteLine(_coBuilderService.whatDoIHave());
            if (_coBuilderService.Session != null) _loggedIn = _coBuilderService.Session.LoggedIn;
        }

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
                        _loggedIn = _coBuilderService.Session?.LoggedIn ?? false;
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
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
            }

            return 0;
        }

        public override bool CanExecuteRibbonTab(string name)
        {
            if (!_loggedIn)
            {
                return name == "CoBuilderStartTab";
            }
            return name == "CoBuilderMainTab";
        }

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
                    return new CommandState(!Application.ActiveDocument.CurrentSelection.IsEmpty || _coBuilderService.Session.WorkplaceSet);
                }
                default:
                {
                    return base.CanExecuteCommand(name);
                }
            }
        }
    }
}