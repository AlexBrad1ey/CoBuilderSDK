// ***********************************************************************
// Assembly         : CoBuilder.Navisworks
// Author           : Alex Bradley
// Created          : 04-19-2016
//
// Last Modified By : Alex Bradley
// Last Modified On : 07-19-2016
// ***********************************************************************
// <copyright file="NavisworksConfig.cs" company="AB Consulting">
//     Copyright © AB Consulting 2016
// </copyright>
// <summary></summary>
// ***********************************************************************
using Autodesk.Navisworks.Api;
using CoBuilder.Service;
using CoBuilder.Service.Interfaces.App;
using CoBuilder.Service.Repositories;
using CoBuilder.Navisworks.Infrastructure;
using CoBuilder.Navisworks.Logic;
using CoBuilder.Service.Infrastructure.DI;

namespace CoBuilder.Navisworks
{
    public class NavisworksRegistry : CoBuilderServiceRegistry
    {
        public NavisworksRegistry()
        {
            For<IAppSelector<ModelItem>>().Use<NavisworksSelector>();
            For<IAppAccessor<ModelItem>>().Use<NavisworksPropertyManager>();
            For<IAppAttacher<ModelItem>>().Use<NavisworksPropertyManager>();
            For<ConnectionRepository<ModelItem>>().Use<ConnectionRepository<ModelItem>>().Singleton();
        }
    }
}