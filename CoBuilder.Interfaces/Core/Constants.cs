using System;
using System.IO;
using System.Reflection;

namespace CoBuilder.Service
{
    public static class Constants
    {
        public static class FilePaths
        {
            public const string ConfigFolder = "Configurations";
            public const string ConfigFileType = ".CoBuilderConfig";

            /// <exclude />
            public static string ConfigDirectory()
            {
                var codeBase = Assembly.GetExecutingAssembly().CodeBase;
                var uri = new UriBuilder(codeBase);
                var path = Uri.UnescapeDataString(uri.Path);
                var dir = Path.GetDirectoryName(path);

                return dir != null ? Path.Combine(dir, ConfigFolder) : null;
            }

            public static string ConfigPathGenerate(string id)
            {
                var directory = ConfigDirectory();

                return Path.Combine(directory, id + ConfigFileType);
            }

            public static string ConfigBasePath()
            {
                return ConfigPathGenerate("Base\\CoBuilderBase");
            }
        }
        
        

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
            public const string IdentifierBase = "CoBuilderProduct";

            public static class PropertySets
            {
                public const string CoBuilderMaster = "CoBuilderProject";
                public const string Base = Identifiers.IdentifierBase + ".Base";

            }

            public static class Properties
            {
                public const string ProductId = PropertySets.Base + ".ProductId";
                public const string WorkplaceId = PropertySets.CoBuilderMaster + ".WorkplaceId";
                public const string WorkplaceName = PropertySets.CoBuilderMaster + ".WorkplaceName";
                public const string BaseWorkplaceId = PropertySets.Base + ".WorkplaceId";
            }
        }


        
    }
} 