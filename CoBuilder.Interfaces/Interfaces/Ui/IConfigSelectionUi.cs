namespace CoBuilder.Service.Interfaces
{
    public interface IConfigSelectionUi
    {
        IConfiguration SelectConfiguration();
    }

    public class ConfigSelectionUi : IConfigSelectionUi
    {
        public IConfiguration SelectConfiguration()
        {
            throw new System.NotImplementedException();
        }
    }
}