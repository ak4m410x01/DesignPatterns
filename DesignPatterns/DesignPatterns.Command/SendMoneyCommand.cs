namespace DesignPatterns.Command
{
    public class SendMoneyCommand : ICommand
    {
        public SendMoneyCommand(Receiver receiver)
        {
            _receiver = receiver;
        }

        private Receiver _receiver;
        public virtual void Execute()
        {
            _receiver.SendMoney(Random.Shared.Next(100, 1000));
        }
    }
}
