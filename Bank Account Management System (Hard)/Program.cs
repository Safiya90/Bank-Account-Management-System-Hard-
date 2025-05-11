namespace Bank_Account_Management_System__Hard_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account1 = new BankAccount("101", "Ali", 2600);
            BankAccount account2 = new BankAccount("202", "Muna", 3000);

            account1.Deposit(200);
            account2.Withdraw(300);

            BankAccount.TotalAccounts();
        }
    }
    public class BankAccount
    {
        private static int totalAccounts ;
        private string AccountNumber;
        private double Balance;
        private string Owner;

        public BankAccount(string acountNo, string ownerName, double balance)
        {
            AccountNumber = acountNo;
            Owner = ownerName;
            if (balance >= 0)
                Balance = balance;
            else
                Balance = 0;

            totalAccounts++;
        }
        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine("Youre balance now is equal to: " + Balance);
            }
        }
        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine("Youre balance now is equal to : " + Balance);
            }
            else
            {
                Console.WriteLine("You dont have enough money");
            }
        }
        public static void TotalAccounts()
        {
            Console.WriteLine("Total accounts created: " + totalAccounts);
        }
    }
}
