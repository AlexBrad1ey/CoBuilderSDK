namespace CoBuilder.Service.Helpers
{
    internal static class KeyBuilder
    {
        public static string Build(KeyType type, string identifier)
        {
            return string.Join(Constants.Caching.Delimiter, type.ToString(), identifier);
        }
    }
}