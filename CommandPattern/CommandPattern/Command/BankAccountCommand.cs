namespace CommandPattern.Command
{
    public class BankAccountCommand :IUndoableCommand
    {
        private BankAccount _account;
        public enum Action
        {
            Deposit, Withdraw
        }
        private Action _action;
        private int _amount;
        private bool succeeded = false;
        public BankAccountCommand(BankAccount account, Action action, int ammount)
        {
            _account = account;
            _action = action;
            _amount = ammount;
        }

        public void Call()
        {
            switch (_action)
            {
                case Action.Deposit:
                    _account.Deposit(_amount);
                    succeeded = true;
                    break;
                case Action.Withdraw:
                    succeeded = _account.Withdraw(_amount);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
        public void Undo()
        {
            if (!succeeded) return;

            switch (_action)
            {
                case Action.Deposit:
                    succeeded = _account.Withdraw(_amount);
                    break;
                case Action.Withdraw:
                    _account.Deposit(_amount);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}
