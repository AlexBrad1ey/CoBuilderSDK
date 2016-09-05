// ***********************************************************************
// Assembly         : CoBuilder.Common
// Author           : Alex Bradley
// Created          : 06-07-2016
//
// Last Modified By : Alex Bradley
// Last Modified On : 07-20-2016
// ***********************************************************************
// <copyright file="ModelInterrogator.cs" company="AB Consulting">
//     Copyright © AB Consulting 2016
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Collections.Generic;
using System.Linq;
using CoBuilder.Core.Interfaces;
using CoBuilder.Service.Domain;
using CoBuilder.Service.Interfaces;

namespace CoBuilder.Service.Logic
{
    public class ModelInterrogator<TElement> : IInterrogator<TElement> where TElement : class
    {
        /// <summary>
        /// The _accessor
        /// </summary>
        private readonly IAppAccessor<TElement> _accessor;
        /// <summary>
        /// The _connector
        /// </summary>
        private readonly ConnectionManager<TElement> _connector;
        /// <summary>
        /// The _selector
        /// </summary>
        private readonly IAppSelector<TElement> _selector;
        /// <summary>
        /// The _session
        /// </summary>
        private readonly ISession _session;

        public ModelInterrogator(ConnectionManager<TElement> connector, IAppAccessor<TElement> accessor,
            IAppSelector<TElement> selector, ISession session)
        {
            _connector = connector;
            _accessor = accessor;
            _selector = selector;
            _session = session;
        }

        public bool Interrogate()
        {
            var hasProject = _accessor.HasProjectPropertySet("CBProject");
            if (hasProject)
            {
                var projectPropertySetInfo = _accessor.GetProjectPropertySet("CBProject");
                var check = projectPropertySetInfo.Username;
                if (projectPropertySetInfo.Username != null)
                {
                    UpdateSession(_session, projectPropertySetInfo);
                    Interrogate(_selector.All());
                    return true;
                }
            }
            return false;
        }

        public void Interrogate(IEnumerable<TElement> elements)
        {
            foreach (var element in elements)
            {
                var identifiers = _accessor.GetCoBuilderPropertySetIdentifiers(element);
                var coBuilderIds =
                    identifiers.Where(i => i.Item1.StartsWith("CBProduct", StringComparison.InvariantCultureIgnoreCase));

                foreach (var identifier in coBuilderIds)
                {
                    var productId = identifier.Item2;
                    _connector.Connect(element, productId);
                }
            }
        }

        private ISession UpdateSession(ISession session, ProjectPropertySetInfo projectPropertySetInfo)
        {
            session.CurrentUser = new CoBuilderUser
            {
                Username = projectPropertySetInfo.Username,
                ContactId = projectPropertySetInfo.ContactId
            };
            session.CurrentWorkplaceName = projectPropertySetInfo.WorkplaceName;
            session.LoginStatus = LoginStatus.NotLoggedInWithWorkplaceId;
            session.modelHasData = true;

            return session;
        }
    }
}