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

            var serializer = new ConfigurationSerializer();
            Configuration con;
            try
            {
                con = serializer.Deserialize(Constants.FilePaths.ConfigBasePath());
            }
            catch (Exception)
            {
                return new Configuration();
            }

            return con;
        }

        public static void BaseSave(this IConfiguration config)
        {
            var serializer = new ConfigurationSerializer();
            serializer.Serialize(config, Constants.FilePaths.ConfigBasePath());
        }
    }
}