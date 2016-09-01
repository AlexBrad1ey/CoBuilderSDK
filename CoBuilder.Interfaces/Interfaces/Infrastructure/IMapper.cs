// ***********************************************************************
// Assembly         : CoBuilder.Common
// Author           : Alex Bradley
// Created          : 05-31-2016
//
// Last Modified By : Alex Bradley
// Last Modified On : 07-20-2016
// ***********************************************************************
// <copyright file="IMapper.cs" company="AB Consulting">
//     Copyright © AB Consulting 2016
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Collections.Generic;
using CoBuilder.Core.Interfaces;
using CoBuilder.Service.Domain;
using CoBuilder.Service.Infrastructure.PTO;

namespace CoBuilder.Service.Interfaces
{
    public interface IMapper
    {
        IEnumerable<PropertySetInfo> Map(BimProduct bimProduct);
        PropertySetInfo GenerateProjectSet(ISession session);
    }
}