using System;
using System.Collections.Generic;
using System.Linq;
using Autodesk.Navisworks.Api;
using CoBuilder.Service.Interfaces.App;
using CoBuilder.Navisworks.Extensions;
using CoBuilder.Service;
using CoBuilder.Service.Infrastructure.PTO;

namespace CoBuilder.Navisworks.Logic
{
    public class NavisworksPropertyManager : IAppAttacher<ModelItem>, IAppAccessor<ModelItem>
    {
        private readonly Document _active;

        public NavisworksPropertyManager()
        {
            _active = Application.ActiveDocument;
        }

        public ProjectPropertySetInfo GetProjectPropertySet(string identifier)
        {
            var workplaceName = _active.Models[0].RootItem.PropertyCategories.FindPropertyByDisplayName(identifier,
                "Workplace Name");
            var workplaceId = _active.Models[0].RootItem.PropertyCategories.FindPropertyByDisplayName(identifier,
                "Workplace Id");

            var info = new ProjectPropertySetInfo
            {
                DisplayName = "identifier",
                Identifier = "identifier",
                WorkplaceName = workplaceName.Value.ToDisplayString(),
            };

            info.AddProperty(new PropertyInfo
            {
                DisplayName = "Workplace Id",
                Identifier = Constants.Identifiers.Properties.WorkplaceId,
                Value = workplaceId.Value.ToDisplayString()
            });

            return info;
        }

        public PropertySetInfo GetPropertySet(ModelItem element, string identifier)
        {
            return null;
            throw new NotImplementedException();
        }

        public IEnumerable<PropertySetInfo> GetPropertySets(ModelItem element)
        {
            return null;
            throw new NotImplementedException();
        }

        public IEnumerable<ProductKey> GetCoBuilderProductKeys(ModelItem element)
        {
            var list = new List<ProductKey>();
            foreach (var propertyCategory in element.PropertyCategories)
            {
                if (propertyCategory.Properties.FindPropertyByName(Constants.Identifiers.Properties.ProductId) != null)
                {
                    int pId =
                        int.Parse(
                            propertyCategory.Properties.FindPropertyByName(Constants.Identifiers.Properties.ProductId)
                                .Value.ToDisplayString());
                    int wId =
                        int.Parse(
                            propertyCategory.Properties.FindPropertyByName(Constants.Identifiers.Properties.BaseWorkplaceId)
                                .Value.ToDisplayString());

                    list.Add(new ProductKey(wId, pId));
                }
            }
            return list;
        }

        public bool Attach(ModelItem appElement, PropertySetInfo pSetInfo)
        {
            try
            {
                var properties = CreateDataProperties(pSetInfo);
                appElement.AddPropertyCategory(pSetInfo.DisplayName, pSetInfo.Identifier, properties.ToArray());
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool AttachRoot(PropertySetInfo pSetInfo)
        {
            return Attach(_active.Models[0].RootItem, pSetInfo);
        }

        public bool Remove(ModelItem appElement, int  productId)
        {
            try
            {
                var Removals = new List<string>();
                foreach (var category in appElement.PropertyCategories)
                {
                    if (category.Properties.FindPropertyByName(Constants.Identifiers.Properties.ProductId) != null)
                    {
                        if (
                            category.Properties.FindPropertyByName(Constants.Identifiers.Properties.ProductId)
                                .Value.ToDisplayString() == productId.ToString())
                        {
                            Removals.Add(category.DisplayName);
                        }
                    }
                }

                foreach (var removal in Removals)
                {
                    appElement.RemovePropertyCategory(removal);
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool HasProjectPropertySet(string identifier)
        {
            var cat = _active.Models[0].RootItem.PropertyCategories.FindCategoryByDisplayName(identifier);
            return cat != null;
        }

        private IEnumerable<DataProperty> CreateDataProperties(PropertySetInfo pSetInfoBase)
        {
            foreach (var pair in pSetInfoBase.Properties)
            {
                var data = new DataProperty(pair.Value.Identifier, pair.Value.DisplayName,
                    new VariantData(pair.Value.Value));

                yield return data;
            }
        }
    }
}