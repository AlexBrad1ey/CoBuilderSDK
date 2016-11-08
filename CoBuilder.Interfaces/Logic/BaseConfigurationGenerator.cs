using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using CoBuilder.Service.Domain;
using CoBuilder.Service.Helpers;
using CoBuilder.Service.Infrastructure.Config;
using CoBuilder.Service.Interfaces;
using CoBuilder.Service.Sets;

namespace CoBuilder.Service.Logic
{
    public class BaseConfigurationGenerator
    {
        private readonly ICoBuilderContext _ctx;

        public BaseConfigurationGenerator(ICoBuilderContext ctx)
        {
            _ctx = ctx;
        }

        public IConfiguration Process(IConfiguration baseIn)
        {
            var workplaceId = CoBuilderService.CurrentService.Session.CurrentWorkplaceId;

            try
            {
                BaseAdd(baseIn);
                foreach (var product in _ctx.Products(workplaceId))
                {
                    Debug.WriteLine($"{product.Id} - {product.Name}");
                    
                    

                    foreach (var set in product.PropertySets)
                    {

                        var identifier = string.Join(".", "CoBuilderProduct", set.Name);

                        IPropertySetDefinition pSetDef;

                        if (baseIn.Root.PropertySets.Any(kvp => kvp.Key == identifier))
                        {
                            pSetDef =
                                baseIn.Root.PropertySets.FirstOrDefault(kvp => kvp.Key == identifier).Value;
                            Debug.WriteLine($"\t{set.Id} - {set.Name}");
                        }
                        else
                        {
                            pSetDef = new PropertySetDefinition {DisplayName = set.Name, Identifier = identifier, PSetId = set.Id, Visible = true};
                            baseIn.AddPropertySet(pSetDef);
                            Debug.WriteLine($"\t{set.Id} - {set.Name} - ADDED");
                        }


                        foreach (var property in set.Properties)
                        {
                            var propId = string.Join(".", identifier, property.Name);

                            IPropertyDefinition propDef;

                            if (pSetDef.Properties.Any(kvp => kvp.Key == propId))
                            {
                                propDef =
                                    pSetDef.Properties.FirstOrDefault(kvp => kvp.Key == identifier).Value;
                                Debug.WriteLine($"\t\t{property.Id} - {property.Name} - {property.Value} {property.Unit}");
                            }
                            else
                            {
                                var connectedProperty = string.Join(".", "CoBUilderProduct", pSetDef.PSetId, property.Id);

                                propDef = new PropertyDefinition { DisplayName = property.Name, Identifier = propId,ConnectedProperty = connectedProperty, Visible = true };
                                pSetDef.AddProperty(propDef);
                                Debug.WriteLine($"\t\t{property.Id} - {property.Name} - {property.Value} {property.Unit} - ADDED");
                            }
                        }

                    }

                }

            }
            catch (Exception e)
            {
                Debug.WriteLine(e.ToString());
                return baseIn;
            }

            return baseIn;
        }

        private void BaseAdd(IConfiguration baseIn)
        {
            var type = typeof(BimProduct);

            var pSetDef = new PropertySetDefinition { DisplayName = "BimProduct", Identifier = Constants.Identifiers.PropertySets.Base, Visible = true };
            try
            {
                baseIn.AddPropertySet(pSetDef);
            }
            catch (Exception)
            {
                return;
            }
            

            foreach (var property in type.GetProperties())
            {
                if (property.Name != "PropertySets" && property.Name != "Context")
                {
                    var connectedProperty = string.Join(".", Constants.Identifiers.PropertySets.Base, property.Name);

                    var propDef = new PropertyDefinition
                    {
                        DisplayName = property.Name,
                        Identifier = connectedProperty,
                        ConnectedProperty = connectedProperty,
                        Visible = true
                    };
                    pSetDef.AddProperty(propDef);
                }
            }
        }
    }
}
