namespace CoBuilder.Service
{
    public static class Constants
    {
        public static class Caching
        {
            public const int AbsoluteEvictionMinutes = 30;
            public const int SlidingEvictionMinutes = 10;
            public const string Delimiter = ".";
        }

        public static class Commands
        {
            public const string Login = "LoginCommand";
        }

        public static class PropertySets
        {
            public const string CoBuilderMaster = "CoBuilderProject";
        }
    }
} 