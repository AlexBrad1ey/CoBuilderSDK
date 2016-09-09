using System.Collections.Generic;
using CoBuilder.Service.Domain;
using CoBuilder.Service.Infrastructure.PTO;

namespace CoBuilder.Service.Interfaces
{
    public interface IMapper
    {
        IEnumerable<PropertySetInfo> Map(IBimProduct bimProduct);
        PropertySetInfo GenerateProjectSet(IServiceSession session);
    }
}