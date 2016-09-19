using System;
using CoBuilder.Core;
using CoBuilder.Core.Authentication;
using CoBuilder.Core.Enums;

namespace BuildTester
{
    public class Program
    {
        static void Main(string[] args)
        {

            var appConfig = new AppConfig()
            {
                AppId = PluginApp.PXCNavisworks,
                ClientId = Guid.NewGuid().ToString(),
                ProgramVersion = "16.0"
            };
            var http = new RestSharpHttpProvider();

            var client = new CoBuilderClient(appConfig, http,
                new CoBuilderServiceInfoProvider(new CoBuilderAuthenticationProvider(new CredentialCache(), http)));

            var result = client.AuthenticateAsync("cobuilderuk@gmail.com", "Sgl0dion");

            var workplaces = client.Workplaces.Request().GetAsync().Result;
            var products = client.Workplaces[162789].Products.Request().GetAsync().Result;
            
            //var r4 = client.Workplaces[162789].Products[13845155].PropertySets
            foreach (var BP in products)
            {
                Console.WriteLine($"{BP.Id} - {BP.Name}");
                Console.WriteLine($"\tIdentifier - {BP.Identifier}");
                Console.WriteLine($"\tSupplier - {BP.SupplierName}");
                Console.WriteLine($"\t Type - {BP.ProductTypes}");

                var pSets = client.Workplaces[162789].Products[BP.Id].PropertySets.Request().PostAsync().Result;

                foreach (var pSet in pSets)
                {
                    Console.WriteLine($"\t\t{pSet.Id} - {pSet.Name}");

                    var properties = client.Workplaces[162789].Products[BP.Id].PropertySets[pSet.Id].Properties.Request().PostAsync().Result;

                    foreach (var prop in properties)
                    {
                        Console.WriteLine($"\t\t\t{prop.Id} - {prop.Name} - {prop.Value} {prop.Unit}");
                    }
                }
            }

            

        }
    }
}