using System.IO;
using System.Text;
using CoBuilder.Core.Interfaces;
using Newtonsoft.Json;

namespace CoBuilder.Core.Serialization
{
    internal class Serializer : ISerializer
    {
        public T DeserializeObject<T>(Stream stream)
        {
            if (stream == null)
            {
                return default(T);
            }

            using (var streamReader = new StreamReader(
                stream,
                Encoding.UTF8 /* encoding */,
                true /* detectEncodingFromByteOrderMarks */,
                4096 /* bufferSize */,
                true /* leaveOpen */))
            using (var textReader = new JsonTextReader(streamReader))
            {
                var jsonSerializer = new JsonSerializer();
                return jsonSerializer.Deserialize<T>(textReader);
            }
        }

        public T DeserializeObject<T>(string inputString)
        {
            if (string.IsNullOrEmpty(inputString))
            {
                return default(T);
            }

            return JsonConvert.DeserializeObject<T>(inputString);
        }

        public string SerializeObject(object serializeableObject)
        {
            if (serializeableObject == null)
            {
                return null;
            }

            var stream = serializeableObject as Stream;
            if (stream != null)
            {
                using (var streamReader = new StreamReader(stream))
                {
                    return streamReader.ReadToEnd();
                }
            }

            var stringValue = serializeableObject as string;
            if (stringValue != null)
            {
                return stringValue;
            }

            return JsonConvert.SerializeObject(serializeableObject);
        }
    }
}