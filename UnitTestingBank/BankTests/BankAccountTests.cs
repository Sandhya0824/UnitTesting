using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestingBank; 
namespace BankTests
{
    [TestClass]
    public class BankAccountTests
    {
        [TestMethod]
        public void Debit_WithValidAmount_UpdatesBalance()
        {
            double initialBalance = 6900.78;
            double debitAmount = 6700.68;
            double expectedAmount = 200.10;
            BankAccount account = new BankAccount("Sandhya", initialBalance);

            account.Debit(debitAmount);

            double actualAmount = account.GetBalance;
            Assert.AreEqual(expectedAmount, actualAmount, 0.001, "Account not debited correctly");
        }

        /*
        [TestMethod]
        public void Debit_WhenAmountIsLessThanZero_ShouldThrowArgumentOutOfRange()
        {
            double initialBalance = 11.99;
            double debitAmount = -100.00;
            BankAccount account = new BankAccount("Sandhya", initialBalance);

            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => account.Debit(debitAmount));
        }

        [TestMethod]
        public void Debit_WhenAmountIsMoreThanBalance_ShouldThrowArgumentOutOfRange()
        {
            double initialBalance = 11.99;
            double debitAmount = 67000.00;
            BankAccount account = new BankAccount("Sandhya", initialBalance);

            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => account.Debit(debitAmount));
        }
        */

        [TestMethod]
        public void Debit_WhenAmountIsLessThanZero_ShouldThrowArgumentOutOfRange()
        {
            double initialBalance = 4500;
            double debitAmount = -2000.0;
            BankAccount account = new BankAccount("Sandhya", initialBalance);

            try
            {
                account.Debit(debitAmount);
            }
            catch (System.ArgumentOutOfRangeException e)
            {
                StringAssert.Contains(e.Message, BankAccount.DebitAmountLessThanZeroMessage);
            }
        }

        [TestMethod]
        public void Debit_WhenAmountIsMoreThanBalance_ShouldThrowArgumentOutOfRange()
        {
            double initialBalance = 78.00;
            double debitAmount = 100.00;
            BankAccount account = new BankAccount("Sandhya", initialBalance);

            try
            {
                account.Debit(debitAmount);
            }
            catch (System.ArgumentOutOfRangeException e)
            {
                StringAssert.Contains(e.Message, BankAccount.DebitAmountExceedsBalanceMessage);
            }
        }
    }
}