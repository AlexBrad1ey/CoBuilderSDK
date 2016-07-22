using CoBuilder.Core.Enums;

namespace CoBuilder.Core.Authentication
{
    public class CredentialCacheKey
    {
        private const string Delimiter = ";";


        public string UserId { get; set; }
        public PluginApp AppId { get; set; }


        public override bool Equals(object obj)
        {
            var credentialCacheKey = obj as CredentialCacheKey;

            return credentialCacheKey != null && credentialCacheKey.GetHashCode() == GetHashCode();
        }

        public override int GetHashCode()
        {
            return
                string.Join(
                    Delimiter,
                    AppId,
                    UserId).ToLowerInvariant().GetHashCode();
        }
    }
}