using System;

namespace CoBuilder.Service.Domain
{
    public interface ICoBuilderUser
    {
        string AdminName { get; }
        bool CanWrite { get; }
        string CompanyName { get; }
        Guid ContactId { get; }
        string Username { get; }
    }
}