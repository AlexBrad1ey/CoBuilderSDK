using System;
using CoBuilder.Core.Interfaces;
using CoBuilder.Service.Domain;
using CoBuilder.Service.Interfaces;

namespace CoBuilder.Service
{
    public class ServiceSession : IServiceSession
    {
        public ICoBuilderUser User { get; }
        public bool LoggedIn { get; internal set; }
        public IWorkplace CurrentWorkplace { get; internal set; }

        public int CurrentWorkplaceId
        {
            get
            {
                return CurrentWorkplace?.Id ?? default(int);
            }
        }

        public bool WorkplaceSet
        {
            get
            {
                return CurrentWorkplace != null;
            }
        }

        public IConfiguration CurrentConfiguration { get; internal set}
        public CoBuilderService TheService { get; }

        public Guid UserContactId
        {
            get { return User.ContactId; }
        }

        internal ServiceSession(ISession session, CoBuilderService service)
        {
            User = new CoBuilderUser(session);
            TheService = service;
            LoggedIn = false;
            CurrentWorkplace = null;


        } 
    }
}