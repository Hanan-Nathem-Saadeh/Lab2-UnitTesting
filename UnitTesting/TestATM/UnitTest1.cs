using Xunit;
using UnitTesting;
namespace TestATM
{
    public class TestATM

    {
        [Fact]
        public void TestViewBalance()
        {
            Program.Balance = 1000.00m;
            Assert.Equal(1000, Program.ViewBalance());
        }

        [Fact]

        public void TestDeposite()
        {

            Assert.Equal(2500, Program.Deposit(1500));
        }
        [Fact]

        public void TestWithdraw()
        {
            Program.Balance = 3500.500M;
            Assert.Equal((decimal)3450.500, Program.Withdraw(50.00m));
        }
        [Fact]
        public void BalanceUpdatedAfterWithdrawl()
        {
            Program.Balance = 3000m;
            Program.Withdraw(500m);
            Assert.Equal(2500, Program.Balance);
        }
        [Fact]
        public void BalanceUpdatedAfterDeposit()
        {
            Program.Balance = 3000m;
            Program.Deposit(3000m);
            Assert.Equal(6000, Program.Balance);
        }
        [Fact]
        public void WithdrawAnegativeValue()
        {
            Program.Balance = 3000m;
            Program.Withdraw(-10);
            Assert.Equal(3000, Program.ViewBalance());// return the balance without withdraw a negative value
        }
        [Fact]
        public void WithdrawLargerValue()
        {
            Program.Balance = 1000m;
            Program.Withdraw(-50000);
            Assert.Equal(1000, Program.ViewBalance());// return the balance without withdraw a value larger the balance
        }
        [Fact]
        public void DepositNegativeValue()
        {
            Program.Balance = 2000.30m;
            Program.Deposit(-500.00m);
            Assert.Equal(2000.30m, Program.ViewBalance());// return the balance without Deposit a negative value
        }

    }
}
