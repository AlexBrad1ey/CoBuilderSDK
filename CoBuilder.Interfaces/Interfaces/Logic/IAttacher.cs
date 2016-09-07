using System.Collections.Generic;
using CoBuilder.Service.Domain;
using CoBuilder.Service.Enums;

namespace CoBuilder.Service.Interfaces
{
    public interface IAttacher<TElement> where TElement : class
    {
        void RefreshAttachments();
        void RefreshAllAttachments();
    }
}
