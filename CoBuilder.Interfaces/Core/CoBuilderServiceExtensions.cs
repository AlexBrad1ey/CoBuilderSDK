using CoBuilder.Service.Domain;
using CoBuilder.Service.Interfaces;

namespace CoBuilder.Service
{
    public static class CoBuilderServiceExtensions
    {
        public static CoBuilderService SetConfiguration(this CoBuilderService service, IConfiguration configuration)
        {
            ((ServiceSession) service.Session).CurrentConfiguration  = configuration;
            return service;
        }

        public static CoBuilderService SetWorkplace(this CoBuilderService service, IWorkplace workplace)
        {
            ((ServiceSession)service.Session).CurrentWorkplace = workplace;
            return service;
        }
    }
}
