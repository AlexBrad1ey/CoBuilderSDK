// ***********************************************************************
// Assembly         : CoBuilder.Navisworks
// Author           : Alex Bradley
// Created          : 09-09-2016
//
// Last Modified By : Alex Bradley
// Last Modified On : 11-08-2016
// ***********************************************************************
// <copyright file="NavisworksSelector.cs" company="AB Consulting">
//     Copyright (c) AB Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Collections.Generic;
using System.Linq;
using Autodesk.Navisworks.Api;
using CoBuilder.Service.Interfaces.App;

namespace CoBuilder.Navisworks.Infrastructure
{
    /// <summary>
    /// Class NavisworksSelector.
    /// </summary>
    /// <seealso cref="CoBuilder.Service.Interfaces.App.IAppSelector{T}" />
    public class NavisworksSelector : IAppSelector<ModelItem>
    {
        /// <summary>
        /// Gets or sets the selection.
        /// </summary>
        /// <value>The selection.</value>
        public IEnumerable<ModelItem> Selection { get; set; }

        /// <summary>
        /// Gets the selection count.
        /// </summary>
        /// <value>The selection count.</value>
        public int SelectionCount => Selection.Count();

        /// <summary>
        /// Alls this instance.
        /// </summary>
        /// <returns>IEnumerable&lt;ModelItem&gt;.</returns>
        public IEnumerable<ModelItem> All()
        {
            return Application.ActiveDocument.Models.RootItemDescendantsAndSelf;
        }

        /// <summary>
        /// Gets the selection.
        /// </summary>
        /// <returns>IEnumerable&lt;ModelItem&gt;.</returns>
        IEnumerable<ModelItem> IAppSelector<ModelItem>.GetSelection()
        {
            Selection = Application.ActiveDocument.CurrentSelection.SelectedItems;
            return Selection;
        }
    }
}