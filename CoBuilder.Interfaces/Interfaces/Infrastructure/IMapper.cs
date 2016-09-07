using System.Collections.Generic;
using CoBuilder.Core.Interfaces;
using CoBuilder.Service.Domain;
using CoBuilder.Service.Infrastructure.PTO;

namespace CoBuilder.Service.Interfaces
{
    public interface IMapper
    {
        IEnumerable<PropertySetInfo> Map(BimProduct bimProduct);
        PropertySetInfo GenerateProjectSet(IServiceSession session);
    }
}