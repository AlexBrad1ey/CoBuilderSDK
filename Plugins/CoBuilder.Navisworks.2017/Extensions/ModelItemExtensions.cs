// ***********************************************************************
// Assembly         : CoBuilder.Navisworks
// Author           : Alex Bradley
// Created          : 09-09-2016
//
// Last Modified By : Alex Bradley
// Last Modified On : 11-08-2016
// ***********************************************************************
// <copyright file="ModelItemExtensions.cs" company="AB Consulting">
//     Copyright (c) AB Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using Autodesk.Navisworks.Api;
using Autodesk.Navisworks.Api.ComApi;
using Autodesk.Navisworks.Api.Interop.ComApi;

namespace CoBuilder.Navisworks.Extensions
{
    /// <summary>
    /// Class ModelItemExtensions.
    /// </summary>
    public static class ModelItemExtensions
    {

        /// <summary>
        /// Adds the property category.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <param name="pCatDisplayName">Display name of the p cat.</param>
        /// <param name="pCatInternalName">Name of the p cat internal.</param>
        /// <param name="properties">The properties.</param>
        /// <returns>PropertyCategory.</returns>
        /// <exception cref="System.ArgumentNullException"></exception>
        /// <exception cref="System.ArgumentException">
        /// Value cannot be null or whitespace.
        /// or
        /// Value cannot be an empty collection.
        /// or
        /// Property Category Already Exists Cannot add Duplicate
        /// or
        /// Value cannot be null or whitespace.
        /// </exception>
        public static PropertyCategory AddPropertyCategory(this ModelItem item, string pCatDisplayName,
            string pCatInternalName,
            params DataProperty[] properties)
        {
            if (item == null) throw new ArgumentNullException(nameof(item));
            if (string.IsNullOrWhiteSpace(pCatInternalName))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(pCatInternalName));
            if (properties.Length == 0)
                throw new ArgumentException("Value cannot be an empty collection.", nameof(properties));
            if (item.PropertyCategories.FindCategoryByName(pCatInternalName) != null)
                throw new ArgumentException("Property Category Already Exists Cannot add Duplicate",
                    nameof(pCatInternalName));
            if (string.IsNullOrWhiteSpace(pCatDisplayName))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(pCatDisplayName));

            var oState = ComApiBridge.State;
            var oPath = ComApiBridge.ToInwOaPath(item);
            var oNode = (InwGUIPropertyNode2) oState.GetGUIPropertyNode(oPath, true);

            var oProperties = (InwOaPropertyVec) oState.ObjectFactory(nwEObjectType.eObjectType_nwOaPropertyVec);


            foreach (var property in properties)
            {
                var oProperty = oState.ObjectFactory(nwEObjectType.eObjectType_nwOaProperty) as InwOaProperty;
                if (oProperty == null) continue;
                oProperty.name = property.Name;
                oProperty.UserName = property.DisplayName;
                oProperty.value = property.Value.ToDisplayString();
                oProperties.Properties().Add(oProperty);
            }

            var oPropertyNode = (InwGUIPropertyNode2) oState.GetGUIPropertyNode(oPath, true);
            oPropertyNode.SetUserDefined(0, pCatDisplayName, pCatInternalName, oProperties);

            return item.PropertyCategories.FindCategoryByName(pCatInternalName);
        }


        /// <summary>
        /// Removes the property category.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <param name="pCatIdentifier">The p cat identifier.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        /// <exception cref="System.ArgumentNullException">
        /// </exception>
        public static bool RemovePropertyCategory(this ModelItem item, string pCatIdentifier)
        {
            if (item == null) throw new ArgumentNullException(nameof(item));
            if (pCatIdentifier == null) throw new ArgumentNullException(nameof(pCatIdentifier));

            var oState = ComApiBridge.State;
            var oPath = ComApiBridge.ToInwOaPath(item);
            var oNode = (InwGUIPropertyNode2) oState.GetGUIPropertyNode(oPath, true);
            var index = 1;

            foreach (InwGUIAttribute2 oAttribute in oNode.GUIAttributes())
            {
                if (!oAttribute.UserDefined) continue;

                if (oAttribute.ClassUserName != pCatIdentifier)
                {
                    index++;
                    continue;
                }

                oNode.RemoveUserDefined(index);
                return true;
            }
            return false;
        }

    }
}