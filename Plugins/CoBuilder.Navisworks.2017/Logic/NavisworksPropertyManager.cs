// ***********************************************************************
// Assembly         : CoBuilder.Navisworks
// Author           : Alex Bradley
// Created          : 09-09-2016
//
// Last Modified By : Alex Bradley
// Last Modified On : 11-08-2016
// ***********************************************************************
// <copyright file="NavisworksPropertyManager.cs" company="AB Consulting">
//     Copyright (c) AB Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
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
    /// <summary>
    /// Class NavisworksPropertyManager.
    /// </summary>
    /// <seealso cref="CoBuilder.Service.Interfaces.App.IAppAttacher{T}" />
    /// <seealso cref="CoBuilder.Service.Interfaces.App.IAppAccessor{T}" />
    public class NavisworksPropertyManager : IAppAttacher<ModelItem>, IAppAccessor<ModelItem>
    {
        /// <summary>
        /// The _active
        /// </summary>
        private readonly Document _active;

        /// <summary>
        /// Initializes a new instance of the <see cref="NavisworksPropertyManager"/> class.
        /// </summary>
        public NavisworksPropertyManager()
        {
            _active = Application.ActiveDocument;
        }

        /// <summary>
        /// Gets the project property set.
        /// </summary>
        /// <param name="identifier">The identifier.</param>
        /// <returns>ProjectPropertySetInfo.</returns>
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
                WorkplaceName = workplaceName.Value.ToDisplayString()
            };

            info.AddProperty(new PropertyInfo
            {
                DisplayName = "Workplace Id",
                Identifier = Constants.Identifiers.Properties.WorkplaceId,
                Value = workplaceId.Value.ToDisplayString()
            });

            return info;
        }

        /// <summary>
        /// Gets the property set.
        /// </summary>
        /// <param name="element">The element.</param>
        /// <param name="identifier">The identifier.</param>
        /// <returns>PropertySetInfo.</returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public PropertySetInfo GetPropertySet(ModelItem element, string identifier)
        {
            return null;
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the property sets.
        /// </summary>
        /// <param name="element">The element.</param>
        /// <returns>IEnumerable&lt;PropertySetInfo&gt;.</returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public IEnumerable<PropertySetInfo> GetPropertySets(ModelItem element)
        {
            return null;
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the co builder product keys.
        /// </summary>
        /// <param name="element">The element.</param>
        /// <returns>IEnumerable&lt;ProductKey&gt;.</returns>
        public IEnumerable<ProductKey> GetCoBuilderProductKeys(ModelItem element)
        {
            var list = new List<ProductKey>();
            foreach (var propertyCategory in element.PropertyCategories)
            {
                if (propertyCategory.Properties.FindPropertyByName(Constants.Identifiers.Properties.ProductId) != null)
                {
                    var pId =
                        int.Parse(
                            propertyCategory.Properties.FindPropertyByName(Constants.Identifiers.Properties.ProductId)
                                .Value.ToDisplayString());
                    var wId =
                        int.Parse(
                            propertyCategory.Properties.FindPropertyByName(Constants.Identifiers.Properties.BaseWorkplaceId)
                                .Value.ToDisplayString());

                    list.Add(new ProductKey(wId, pId));
                }
            }
            return list;
        }

        /// <summary>
        /// Attaches the specified application element.
        /// </summary>
        /// <param name="appElement">The application element.</param>
        /// <param name="pSetInfo">The p set information.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
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

        /// <summary>
        /// Attaches the root.
        /// </summary>
        /// <param name="pSetInfo">The p set information.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public bool AttachRoot(PropertySetInfo pSetInfo)
        {
            return Attach(_active.Models[0].RootItem, pSetInfo);
        }

        /// <summary>
        /// Removes the specified application element.
        /// </summary>
        /// <param name="appElement">The application element.</param>
        /// <param name="productId">The product identifier.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
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

        /// <summary>
        /// Determines whether [has project property set] [the specified identifier].
        /// </summary>
        /// <param name="identifier">The identifier.</param>
        /// <returns><c>true</c> if [has project property set] [the specified identifier]; otherwise, <c>false</c>.</returns>
        public bool HasProjectPropertySet(string identifier)
        {
            var cat = _active.Models[0].RootItem.PropertyCategories.FindCategoryByDisplayName(identifier);
            return cat != null;
        }

        /// <summary>
        /// Creates the data properties.
        /// </summary>
        /// <param name="pSetInfoBase">The p set information base.</param>
        /// <returns>IEnumerable&lt;DataProperty&gt;.</returns>
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