namespace CoBuilder.Core
{
    public static class Constants
    {
        public static class Authentication
        {
            public const string AccessTokenKeyName = "access_token";
            public const string CoBuilderBaseUrl = "https://services.cobuilder.com/Plugin/PluginService.svc/REST";
        }

        public static class Headers
        {
            public const string Bearer = "Bearer";
        }

        public static class Url
        {
            public const string Login = "Login";
            public const string Workplaces = "GetWorkplaceHierarchy";
            public const string PropertySetTags = "PSetTags";
            public const string Products = "Products";
            public const string PropertySets = "ProductPSets";
            public const string Properties = "ProductProperties";
        }

        public static class Parameters
        {
            public const string Username = "username";
            public const string Password = "password";
            public const string ContactId = "contactId";
            public const string AppId = "appId";
            public const string WorkplaceId = "workplaceId";
            public const string CountryIndex = "countryIndex";
            public const string ProductId = "productId";
            public const string PropertySetId = "pSetId";
            public const string PropertySetIds = "pSetIds";
        }
    }
}