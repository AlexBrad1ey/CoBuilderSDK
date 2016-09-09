using System;
using CoBuilder.Service.Domain;

namespace CoBuilder.Service.Interfaces
{
    public interface IServiceSession
    {

        ICoBuilderUser User { get; }
        bool LoggedIn { get; }
        IWorkplace CurrentWorkplace { get; }
        int CurrentWorkplaceId { get; }
        Guid UserContactId { get; }
        bool WorkplaceSet { get; }
        IConfiguration CurrentConfiguration { get; }
        CoBuilderService TheService { get; }
       
    }
}