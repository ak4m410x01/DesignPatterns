namespace DesignPatterns.Command
{
    public class SendMoneyToAllCommand : ICommand
    {
        public SendMoneyToAllCommand(IEnumerable<Receiver> receivers)
        {
            _receivers = receivers;
        }

        private IEnumerable<Receiver> _receivers;
        public virtual void Execute()
        {
            foreach (Receiver receiver in _receivers)
            {
                receiver.SendMoney(Random.Shared.Next(100, 1000));
            }
        }
    }
}
