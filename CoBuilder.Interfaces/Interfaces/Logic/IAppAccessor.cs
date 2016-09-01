using System;
using System.Collections.Generic;
using CoBuilder.Service.Infrastructure.PTO;

namespace CoBuilder.Service.Logic
{
    public interface IAppAccessor<TElement> where TElement: class
    {
        PropertySetInfo GetProjectPropertySet(string identifier);
        bool HasProjectPropertySet(string identifier);
        PropertySetInfo GetPropertySet(TElement element, string identifier);
        IEnumerable<Tuple<string, int>> GetCoBuilderPropertySetIdentifiers(TElement element);
        IEnumerable<PropertySetInfo> GetPropertySets(TElement element);

    }
}