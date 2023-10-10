namespace UnitTestingBank
{
    public class BankAccount
    {
        public const string DebitAmountExceedsBalanceMessage = "Debit amount exceeds the current balance";
        public const string DebitAmountLessThanZeroMessage = "Debit amount is less than zero";

        private readonly string _customerName;
        private double _balance;

        private BankAccount() { }

        public BankAccount(string customerName, double balance)
        {
            _customerName = customerName;
            _balance = balance;
        }

        public string GetCustomerName
        {
            get { return _customerName; }
        }

        public double GetBalance
        {
            get { return _balance; }
        }

        public void Debit(double amount)
        {
            if (amount > _balance)
            {
                /*throw new ArgumentOutOfRangeException("amount"); */
                throw new System.ArgumentOutOfRangeException("amount", amount, DebitAmountExceedsBalanceMessage);
            }

            if (amount < 0)
            {
                /*throw new ArgumentOutOfRangeException("amount"); */
                throw new System.ArgumentOutOfRangeException("amount", amount, DebitAmountLessThanZeroMessage);
            }

            _balance -= amount; 
        }

        public void Credit(double amount)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("amount");
            }

            _balance += amount;
        }

        public static void Main()
        {
            BankAccount ba = new BankAccount("Sandhya", 50000.00);

            ba.Credit(2900.89);
            ba.Debit(8000.45);
            Console.WriteLine("Current balance is ${0}", ba.GetBalance);
        }
    }
}