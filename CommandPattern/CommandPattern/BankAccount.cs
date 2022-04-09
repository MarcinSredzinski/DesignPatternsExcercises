namespace CommandPattern
{
    internal class BankAccount
    {
        private int balance;
        private int overdraftLimit = -500;
        public void Deposit(int amount)
        {
            balance += amount;
            Console.WriteLine("Deposited: {0}, current balance: {1}", amount, balance);
        }
        public void Withdraw(int amount)
        {
            if (balance - amount >= overdraftLimit)
            {
                balance -= amount;
                Console.WriteLine("Withdrawn: {0}, current balance: {1}", amount, balance);
            }
        }
        public override string ToString()
        {
            return $"{nameof(balance)}: {balance}";
        }
    }
}
