using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using CoBuilder.Service.Domain;
using CoBuilder.Service.Infrastructure.Config;
using CoBuilder.Service.Infrastructure.PTO;
using CoBuilder.Service.Interfaces;

namespace CoBuilder.Service.Logic
{
    public class Mapper : IMapper
    {
        private readonly IConfiguration _config;

        public Mapper(IConfiguration config)
        {
            _config = config;
        }


        public IEnumerable<PropertySetInfo> Map(IBimProduct bimProduct)
        {
            var root = _config.Root;
            var presult = new List<PropertySetInfo>();
            foreach (var pSetDefinition in root.PropertySets.Values)
            {
                var pSetInfo = MapPSet(pSetDefinition, bimProduct);
                if (pSetInfo == null) continue;


                foreach (var propertyDefinition in pSetDefinition.Properties.Values)
                {
                    var propertyInfo = MapProperty(propertyDefinition, bimProduct);
                    if (propertyInfo == null) continue;
                    pSetInfo.AddProperty(propertyInfo);
                }

                if (pSetInfo.Properties.Count > 0)
                {
                    if (
                        pSetDefinition.Properties.Values.All(
                            d => d.Identifier != Constants.Identifiers.Properties.ProductId))
                    {
                        var value = BuildValue(bimProduct, Constants.Identifiers.Properties.ProductId);

                        var result = new PropertyInfo
                        {
                            DisplayName = "ProductId",
                            Identifier = Constants.Identifiers.Properties.ProductId,
                            Value = value.Value,
                            Units = null,
                            Visible = false
                        };

                        pSetInfo.AddProperty(result);
                    }

                    if (
                        pSetDefinition.Properties.Values.All(
                            d => d.Identifier != Constants.Identifiers.Properties.BaseWorkplaceId))
                    {
                        var value = BuildValue(bimProduct, Constants.Identifiers.Properties.BaseWorkplaceId);

                        var result = new PropertyInfo
                        {
                            DisplayName = "WorkplaceId",
                            Identifier = Constants.Identifiers.Properties.WorkplaceId,
                            Value = value.Value,
                            Units = null,
                            Visible = false
                        };

                        pSetInfo.AddProperty(result);

                    }

                    presult.Add(pSetInfo);
                }
            }

            return presult;
        }

        public PropertySetInfo GenerateProjectSet(IServiceSession session)
        {
            return new ProjectPropertySetInfo()
            {
                DisplayName = Constants.Identifiers.PropertySets.CoBuilderMaster,
                Identifier = Constants.Identifiers.PropertySets.CoBuilderMaster,
                WorkplaceId = session.CurrentWorkplaceId,
                WorkplaceName = session.CurrentWorkplace.WorkplaceName,
                Visible = true
            };

        }

        private PropertyInfo MapProperty(IPropertyDefinition definition, IBimProduct bimProduct)
        {


            var value = BuildValue(bimProduct, definition.ConnectedProperty);
            if (value == null) return null;

            var result = new PropertyInfo
            {
                DisplayName = definition.DisplayName,
                Identifier = definition.Identifier,
                Value = value.Value,
                Units = value.Units,
                Visible = definition.Visible
            };

            return result;
        }

        private Data BuildValue(IBimProduct bimProduct, string connectedProperty)
        {
            var path = connectedProperty.Split(new[] {'.'}, StringSplitOptions.RemoveEmptyEntries);
            if (path[0] == Constants.Identifiers.PropertySets.CoBuilderMaster)
            {
                var type = typeof(IBimProduct);
                var value = new Data
                {
                    Value = type.GetProperty(path[1])?.GetValue(bimProduct)?.ToString(),
                    Units = null
                };

                return value.Value == null ? value : null;

            }
            else
            {
                if (path[1] == "Base")
                {
                    var type = typeof(BimProduct);
                    var value = new Data
                    {
                        Value = type.GetProperty(path[2])?.GetValue(bimProduct)?.ToString(),
                        Units = null
                    };
                    return value.Value == null ? null : value;
                }
                else
                {
                    var property = bimProduct.PropertySets[path[1]]?.Properties[path[2]];
                    if (property == null) return null;

                    return new Data()
                    {
                        Value = property.Value,
                        Units = property.Unit
                    };
                }
            }

        }

        private class Data
        {
            public string Value { get; set; }
            public string Units { get; set; }
        }

        private PropertySetInfo MapPSet(IPropertySetDefinition definition, IBimProduct bimProduct)
        {
            var pSetInfo = new PropertySetInfo
            {
                DisplayName = definition.DisplayName,
                Identifier = definition.Identifier,
                Visible = definition.Visible
            };

            return pSetInfo;
        }
    }
}