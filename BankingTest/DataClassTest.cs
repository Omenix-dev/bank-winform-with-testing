using Core.Interfaces;
using Data.Interfaces;
using Data.Repositories;
using NUnit.Framework;
using Moq;
using Model;
using Enum;
using Data;
using System.Threading.Tasks;
using EasyEncryption;

namespace BankingTest
{
    [Category("Repository")]
    [TestFixture]
    public class AccountRepositoryTest
    {
        private Mock<IUserServices> UserServices = new Mock<IUserServices>();
        private Mock<IAccountServices> AccountServices = new Mock<IAccountServices>();
        private Mock<IProtocols> Protocols = new Mock<IProtocols>();
        private Mock<IWriteToFile> Write = new Mock<IWriteToFile>();
        private AccountRespository AccountRepo;
        public AccountRepositoryTest()
        {
            AccountRepo = new AccountRespository(Protocols.Object, UserServices.Object, AccountServices.Object,Write.Object);
        }
        [Test]
        public async Task AccountRepoRetrieveTest()
        {
            string accountNumber = "0000004567";
            int accountType = 1;
            decimal Amount = 13000.00M;
            string desc = "account was created";
            int transacType = 1;

            AccountDetails details = new AccountDetails((AccountType)1,Amount,accountNumber);
            ValidTransactions transacDetails = new ValidTransactions(desc, accountNumber, Amount,transacType, Amount);
            

            Protocols.Setup(x => x.IsValid(Amount, (AccountType)1)).Returns(true);
            Protocols.Setup(x => x.SESSIONS.IsLogged).Returns(true);
            //Protocols.Setup(x => x).Returns(Protocols);
            AccountServices.Setup(x => x.CreateAccount((AccountType)1, Amount, accountNumber)).Returns(details);
            UserServices.Setup(x => x.Deposit(desc, accountNumber, Amount, Amount)).Returns(transacDetails);
            Write.Setup( x => x.save(Protocols.Object, details)).ReturnsAsync(true);



            var actual = await Task.Run(() => AccountRepo.Retrieve(transacType, Amount,accountNumber));
            //Assert
            Assert.True(actual);
        }
        [Test]
        public async Task AccountRepoNotLoggedTest()
        {
            string accountNumber = "0000004567";
            int accountType = 1;
            int transacType = 1;
            decimal Amount = 13000.00M;

            Protocols.Setup(x => x.IsValid(Amount, (AccountType)1)).Returns(true);
            Protocols.Setup(x => x.SESSIONS.IsLogged).Returns(false);
            var actual = await Task.Run(() => AccountRepo.Retrieve(transacType, Amount, accountNumber));
            //Assert
            Assert.False(actual);
        }
    }

    [Category("Repository")]
    [TestFixture]
    public class BankRepositoryTest
    {
        private Mock<IAccountServices> Customer = new Mock<IAccountServices>();
        private Mock<IWriteToFile> Write = new Mock<IWriteToFile>();
        private BankRepository bank;
        public BankRepositoryTest()
        {
            bank = new BankRepository(Customer.Object, Write.Object);
        }
        [Test]
        public async Task BankRepoCreateCustomerTest()
        {
            string fullname = "Omeni Saviour";
            string password = "asd@123";
            string passwordHASH = SHA.ComputeSHA256Hash("asd@123");
            string sex = "Male";
            string email = "omenigph@gmail.com";

            Customer _person = new Customer(fullname,password,sex,email);

            Customer.Setup(x => x.RegisterCustomer(fullname, password, sex, email)).Returns(_person);
            Write.Setup(x => x.SaveCustomer(bank,_person)).ReturnsAsync(true);
            
            // Act
            var actual = await Task.Run(() => bank.CreateCustomer(fullname, password, sex, email));

            //Assert
            Assert.True(actual);
        }
    } 

}

