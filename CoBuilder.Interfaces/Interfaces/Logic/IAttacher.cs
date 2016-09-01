using System.Collections.Generic;
using CoBuilder.Service.Domain;
using CoBuilder.Service.Enums;

namespace CoBuilder.Service.Interfaces
{
    public interface IAttacher<in TElement> where TElement : class
    {
        AttachmentResult AttachProduct(TElement element, BimProduct product);
        AttachmentResult AttachProduct(IEnumerable<TElement> elements, BimProduct product);
        RemovalResult RemoveProduct(TElement element, BimProduct product);
        RemovalResult RemoveProduct(IEnumerable<TElement> elements, BimProduct product);
        RemovalResult RemoveProducts(TElement element);
        RemovalResult RemoveProducts(IEnumerable<TElement> elements);
    }
}
