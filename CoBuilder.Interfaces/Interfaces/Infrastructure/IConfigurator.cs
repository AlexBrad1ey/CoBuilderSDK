using System.Collections.Generic;
using CoBuilder.Service.Domain;

namespace CoBuilder.Service.Interfaces
{
    public interface IConfigurator
    {
        IEnumerable<string> PSetIdentifiers(BimProduct bimProduct);
    }
}