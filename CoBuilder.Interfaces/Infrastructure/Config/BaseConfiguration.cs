using System;
using System.IO;
using System.Reflection;
using CoBuilder.Service.Interfaces;

namespace CoBuilder.Service.Infrastructure.Config
{
    public static class BaseConfiguration
    {

        public static Configuration BaseLoad()
        {
            string codeBase = Assembly.GetExecutingAssembly().CodeBase;
            UriBuilder uri = new UriBuilder(codeBase);
            string path = Uri.UnescapeDataString(uri.Path);
            var dirPath = Path.Combine(Path.GetDirectoryName(path), "Configurations", "Base", "CoBuilderBase" + Constants.ConfigFileType);

            var serializer = new ConfigurationSerializer();
            Configuration con;
            try
            {
                con = serializer.Deserialize(dirPath);
            }
            catch (Exception)
            {
                return new Configuration();
            }

            return con;
        }

        public static void BaseSave(this IConfiguration config)
        {
            string codeBase = Assembly.GetExecutingAssembly().CodeBase;
            UriBuilder uri = new UriBuilder(codeBase);
            string path = Uri.UnescapeDataString(uri.Path);
            var dirPath = Path.Combine(Path.GetDirectoryName(path), "Configurations", "Base", "CoBuilderBase" + Constants.ConfigFileType);

            var serializer = new ConfigurationSerializer();
            serializer.Serialize(config, dirPath);

        }
    }
}