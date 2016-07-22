using System.Collections.Generic;
using System.Linq;
using CoBuilder.Core.Domain;

namespace CoBuilder.Core
{
    public static class Mappers
    {
        public static IList<int> MapPropertySetIds(IList<IBimPropertySetTag> propertySetTags)
        {
            return propertySetTags.Select(pSetTag => pSetTag.Id).ToList();
        }
    }
}