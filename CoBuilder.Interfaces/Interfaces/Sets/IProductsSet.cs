using System.Collections.Generic;
using CoBuilder.Service.Domain;
using CoBuilder.Service.Sets;

namespace CoBuilder.Service.Interfaces
{
    public interface IProductsSet: ICBSet<IBimProduct>
    {
        SupplierSet Suppliers { get; }
    }
}