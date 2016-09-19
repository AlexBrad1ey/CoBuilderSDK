namespace CoBuilder.Service
{
    public static class Constants
    {
        public const string FilePathBase = "Configurations";
        public const string ConfigFileType = ".CoBuilderConfig";

    public static class Caching
        {
            public const int AbsoluteEvictionMinutes = 30;
            public const int SlidingEvictionMinutes = 10;
            public const string Delimiter = ".";
        }

        /// <exclude />
        public static class Commands
        {
            public const string Login = "LoginCommand";
        }

        public static class Identifiers
        {

            public static class PropertySets
            {
                public const string CoBuilderMaster = "CoBuilderProject";
                public const string Base = "CoBuilderProduct.Base";

            }

            public static class Properties
            {
                public const string ProductId = PropertySets.Base + ".ProductId";
                public const string WorkplaceId = PropertySets.CoBuilderMaster + ".WorkplaceId";
                public const string WorkplaceName = PropertySets.CoBuilderMaster + ".WorkplaceName";
            }
        }


        
    }
} 