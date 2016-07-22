namespace CoBuilder.Core.Authentication
{
    public class CoBuilderServiceInfo : ServiceInfo
    {
        public CoBuilderServiceInfo()
        {
            ServiceEndpointVersion = "";
            BaseUrl = Constants.Authentication.CoBuilderBaseUrl;
        }
    }
}