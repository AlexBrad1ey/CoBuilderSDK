using CoBuilder.Service.Infrastructure.Config;
using CoBuilder.Service.Interfaces;

namespace CoBuilder.Service.Infrastructure.Structures
{
    public class PropertyTree : Tree<IDefinition>
    {
        public PropertyTree(DefinitionNode root) : base(root)
        {
        }
    }
}