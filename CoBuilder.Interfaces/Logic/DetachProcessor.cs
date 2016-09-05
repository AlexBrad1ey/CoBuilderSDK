// ***********************************************************************
// Assembly         : CoBuilder.Common
// Author           : Alex Bradley
// Created          : 05-27-2016
//
// Last Modified By : Alex Bradley
// Last Modified On : 07-20-2016
// ***********************************************************************
// <copyright file="DetachProcessor.cs" company="AB Consulting">
//     Copyright © AB Consulting 2016
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Collections.Generic;
using CoBuilder.Service.Domain;
using CoBuilder.Service.Enums;
using CoBuilder.Service.Interfaces;

namespace CoBuilder.Service.Logic
{
    internal class DetachProcessor<TElement> where TElement : class
    {
        private readonly IAppAttacher<TElement> _attacher;
        private readonly IConfigurator _configurator;

        public DetachProcessor(IAppAttacher<TElement> attacher, IConfiguration config, IAttacher<TElement> manager)
        {
            _attacher = attacher;
            _configurator = new Mapper(config);
        }

        internal RemovalResult Process(IEnumerable<Connection<TElement>> connections)
        {
            var result = RemovalResult.Null;

            foreach (var connection in connections)
            {
                result = result | Process(connection);
            }

            return result;
        }

        public RemovalResult Process(Connection<TElement> connection)
        {
            return _attacher.Remove(connection.AppElement, Identifier.Generate(connection.BimProduct.Id))
                ? RemovalResult.AllElementsDisconnected
                : RemovalResult.NoElementsDisconnected;
        }
    }
}