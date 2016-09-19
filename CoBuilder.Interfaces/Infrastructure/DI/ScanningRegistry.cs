using StructureMap;

namespace CoBuilder.Service.Infrastructure.DI
{
    public class ScanningRegistry : Registry
    {
        public ScanningRegistry()
        {
            Scan(x =>
            {
                x.TheCallingAssembly();
                x.LookForRegistries();
            });
        }
    }
}