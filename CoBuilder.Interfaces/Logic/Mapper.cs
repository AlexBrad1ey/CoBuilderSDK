using System.Collections.Generic;
using CoBuilder.Service.Domain;
using CoBuilder.Service.Infrastructure.PTO;
using CoBuilder.Service.Interfaces;

namespace CoBuilder.Service.Logic
{
    public class Mapper : IMapper, IConfigurator
    {
        /// <summary>
        /// The _config
        /// </summary>
        private readonly IConfiguration _config;

        public Mapper(IConfiguration config)
        {
            _config = config;
        }

        public IEnumerable<string> PSetIdentifiers(BimProduct bimProduct)
        {
            //return new List<string> {_config.Structure.Root.Value.Identifier + bimProduct.Id};
        }

    

        public IEnumerable<PropertySetInfo> Map(BimProduct bimProduct)
        {
            var root = _config.Structure.Root;
            var rootPSet = MapPSet(root.Value, bimProduct);

            foreach (var child in root.Children)
            {
                if (child.Value.Include)
                {
                    var property = MapProperty(child.Value, bimProduct);
                    if (property == null) continue;
                    rootPSet.AddProperty(property);
                }
            }

            return new List<PropertySetInfo> {rootPSet};
        }

        private PropertyInfo MapProperty(ConfigInfo info, BimProduct product)
        {
            var value = typeof (BimProduct).GetProperty(info.Name).GetValue(product);
            if (value == null) return null;
            var result = new PropertyInfo
            {
                DisplayName = info.DisplayName,
                Identifier = info.Identifier,
                Units = null,
                Value = value.ToString()
            };

            return result;
        }

        private PropertySetInfo MapPSet(ConfigInfo info, BimProduct product)
        {
            return new PropertySetInfo
            {
                DisplayName = info.DisplayName,
                Identifier = info.Identifier + product.Id
            };
        }
    }
}