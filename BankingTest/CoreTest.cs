using NUnit.Framework;
using Core.Implementation;
using Enum;


namespace BankingTest
{
    [TestFixture]
    public class AccountServicesTest
    {
        private AccountServices AccountServicesObject { get; set; }
        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            // Arrange
            // system under test
            AccountServicesObject = new AccountServices();
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            // tears down by dumping values to null
            AccountServicesObject = null;
        }

        [Test]
        public void AccountServicesNullTest()
        {
            // test values
            decimal deposit = 2000.50M;
            string Account   = "0000000562";
            AccountType Type = AccountType.SAVINGS;

            // Act
            var AccountCreatedValue = AccountServicesObject.CreateAccount(Type, deposit, Account);

            // Assert
            Assert.IsNotNull(AccountCreatedValue);
        }
        [Test]
        public void RegisterCustomerNullTest()
        {
            // values 
            string fullname = "Omeni Saviour";
            string Password = "asd@123";
            string sex = "male";
            string email = "omenigph@gmail.com";

            // Arrange
            var RegisterClass = AccountServicesObject.RegisterCustomer(fullname, Password, sex, email);

            //Assert
            Assert.IsNotNull(RegisterClass);
        }
    }

    public class UserServicesTest
    {
        private UserServices UserServicesObject { get; set; }
        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            UserServicesObject = new UserServices();
        }
        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            // return 
            UserServicesObject = null;
        }
        [Test]
        public void WithdrawalNullTest()
        {
            //testCase values
            string Description = "Withdrawal was made";
            string AccountNumber = "0000004523";
            decimal Amount = 5000.00M;
            decimal balance = 2000.00M;

            // Act
            var UserSUT = UserServicesObject.Withdrawal(Description,AccountNumber,Amount,balance);

            // Assert
            Assert.IsNotNull(UserSUT);
        }
        [Test]
        public void DepositNullTest()
        {
            // testCase value
            string Description = "Deposit was made";
            string AccountNumber = "0000004523";
            decimal Amount = 5000.00M;
            decimal balance = 2000.00M;

            //Act
            var UserSUT = UserServicesObject.Deposit(Description,AccountNumber,Amount,balance);

            //Assert
            Assert.IsNotNull(UserSUT);
        }

    }
}
