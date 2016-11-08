using System.IO;
using CoBuilder.Service.Interfaces;
using Newtonsoft.Json;

namespace CoBuilder.Service.Infrastructure.Config
{

    public class ConfigurationSerializer
    {
        public void Serialize(IConfiguration configuration, string filePath)
        {
            var json = JsonConvert.SerializeObject(configuration);
            File.WriteAllText(filePath,json);
        }

        public Configuration Deserialize(string filepath)
        {
            using (StreamReader file = File.OpenText(filepath))
            {
                var serializer = new JsonSerializer();
                var config = (Configuration) serializer.Deserialize(file, typeof(Configuration));
                return config;
            }
        }
    }
}
