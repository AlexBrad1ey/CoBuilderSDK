using System;
using System.Collections.Generic;
using CoBuilder.Service.Infrastructure.PTO;

namespace CoBuilder.Service.Interfaces.App
{
    public interface IAppAccessor<TElement> where TElement: class
    {
        ProjectPropertySetInfo GetProjectPropertySet(string identifier);
        bool HasProjectPropertySet(string identifier);
        PropertySetInfo GetPropertySet(TElement element, string identifier);
        IEnumerable<Tuple<string, int>> GetCoBuilderPropertySetIdentifiers(TElement element);
        IEnumerable<PropertySetInfo> GetPropertySets(TElement element);

    }
}