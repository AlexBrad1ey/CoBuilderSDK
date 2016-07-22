using System.IO;

namespace CoBuilder.Core.Interfaces
{
    public interface ISerializer
    {
        T DeserializeObject<T>(Stream stream);
        T DeserializeObject<T>(string inputString);
        string SerializeObject(object serializeableObject);
    }
}