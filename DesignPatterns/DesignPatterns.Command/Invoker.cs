namespace DesignPatterns.Command
{
    public class Invoker
    {
        public void Invoke(ICommand command)
        {
            command.Execute();
        }
    }
}
