using CoBuilder.Service.Domain;
using CoBuilder.Service.Infrastructure.Config;
using CoBuilder.Service.Interfaces;

namespace CoBuilder.Service.Helpers
{
    internal static class KeyBuilder
    {
        public static string Build(KeyType type, string identifier)
        {
            return string.Join(Constants.Caching.Delimiter, type.ToString(), identifier);
        }

        public static string Build(IWorkplace workplace)
        {
            return KeyBuilder.Build(KeyType.Workplaces, workplace.Id.ToString());
        }

        public static DefinitionKey Build(IDefinition definition )
        {
            return new DefinitionKey()
            {
                DisplayName = definition.DisplayName,
                Identifier = definition.Identifier
            };
        }
    }
}