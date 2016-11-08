// ***********************************************************************
// Assembly         : CoBuilderV2
// Author           : Alex Bradley
// Created          : 08-09-2016
//
// Last Modified By : Alex Bradley
// Last Modified On : 08-09-2016
// ***********************************************************************
// <copyright file="WorkplacesCollection.cs" company="AB Consulting">
//     Copyright (c) AB Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using CoBuilder.Core.Domain;
using CoBuilder.Core.Interfaces;

namespace CoBuilder.Core.Collections
{
    /// <summary>
    /// Class WorkplacesCollection.
    /// </summary>
    /// <seealso cref="System.Collections.ObjectModel.ReadOnlyCollection{CoBuilder.Core.Domain.Workplace}" />
    /// <seealso cref="CoBuilder.Core.Interfaces.IWorkplacesCollection" />
    public class WorkplacesCollection : ReadOnlyCollection<Workplace>, IWorkplacesCollection
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkplacesCollection"/> class.
        /// </summary>
        /// <param name="workplaces">The workplaces.</param>
        public WorkplacesCollection(IList<Workplace> workplaces):base(workplaces)
        {
        }
    }
}