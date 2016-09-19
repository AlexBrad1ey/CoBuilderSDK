using System;
using System.Diagnostics;
using CoBuilder.Navisworks;
using CoBuilder.Service;
using CoBuilder.Service.Commands;

namespace ServiceTester
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceConfig = new ServiceConfiguration()
            {
                AppConfig = new NavisworksAppConfig(),
                ContainerConfig = new NavisworksRegistry(),
                UseDefinedContainerConfig = true
            };

            try
            {
                var coBuilderService = CoBuilderService.Initiate(serviceConfig);

                var Login = new LoginCommand<MockItem>().Execute();

                var Workplace = new ChangeWorkplaceCommand().Execute();

                var Config = new ConfigurationCommand().Execute();
            }
            catch (Exception e)
            {
                
                Debug.WriteLine(e.ToString());
            }
        }
    }

    internal class MockItem
    {
    }
}
