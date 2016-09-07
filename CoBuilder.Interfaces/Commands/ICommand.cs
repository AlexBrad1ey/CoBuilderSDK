namespace CoBuilder.Service.Commands
{
    public interface ICommand
    {
        bool Execute();
        bool CanExecute();
    }
}