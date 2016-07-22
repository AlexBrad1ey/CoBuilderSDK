using System.Collections.Generic;
using CoBuilder.Core.Domain;

namespace CoBuilder.Core.Interfaces
{
    public interface IProductsCollection :IReadOnlyCollection<BimProduct>
    {
    }
}