using System;
using System.Diagnostics.Eventing.Reader;
using CoBuilder.Core.Interfaces;
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
    }

    public class ServiceSession : IServiceSession
    {
        public ICoBuilderUser User { get; private set; }
        public bool LoggedIn { get; private set; }
        public IWorkplace CurrentWorkplace { get; private set; }

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

        public Guid UserContactId
        {
            get { return User.ContactId; }
        }

        internal ServiceSession(ISession session)
        {
            User = new CoBuilderUser(session);
            LoggedIn = false;
            CurrentWorkplace = null;


        } 
    }
}