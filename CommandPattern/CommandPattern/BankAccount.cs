namespace CommandPattern
{
    public class BankAccount
    {
        private int balance;
        private int overdraftLimit = -500;
        public void Deposit(int amount)
        {
            balance += amount;
            Console.WriteLine("Deposited: {0}, current balance: {1}", amount, balance);
        }
        public bool Withdraw(int amount)
        {
            bool succeeded = false;
            if (balance - amount >= overdraftLimit)
            {
                balance -= amount;
                Console.WriteLine("Withdrawn: {0}, current balance: {1}", amount, balance);
                succeeded = true;
            }
            return succeeded;
        }
        public override string ToString()
        {
            return $"{nameof(balance)}: {balance}";
        }
    }
}
