using CoBuilder.Service.Interfaces;

namespace CoBuilder.Service.Domain
{
    public interface IEntity
    {
        ICoBuilderContext Context { get; set; }
    }
}