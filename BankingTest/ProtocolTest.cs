using Moq;
using NUnit.Framework;
using Data.Interfaces;
using Data;
using Enum;
using Model;
using System.Collections.Generic;
using EasyEncryption;

namespace BankingTest
{
    [TestFixture]
    public class ProtocolTest
    {
        private Mock<ISESSIONS> Session = new Mock<ISESSIONS>();
        private Mock<IBankRepository> Bank = new Mock<IBankRepository>();
        private Protocols protocol;
        public ProtocolTest()
        {
            // arrange
            protocol = new Protocols(Session.Object, Bank.Object);
        }

        [Test]
        public void IsValidTest()
        {
            Session.Setup(x => x.IsLogged).Returns(true);
            // test case
            var case1 = (1000.00M,(AccountType)0);
            var case2 = (0.00M, (AccountType)0);
            var case3 = (200.00M, (AccountType)1);
            // act
            var sut1 = protocol.IsValid(case1.Item1,case1.Item2);
            var sut2 = protocol.IsValid(case2.Item1,case2.Item2);
            var sut3 = protocol.IsValid(case3.Item1,case3.Item2);

            // assert
            Assert.True(sut1);
            Assert.IsFalse(sut2);
            Assert.True(sut3);
        }

        [Test]
        public void IsAuthenticatedTest()
        {
            List<Customer> database = new List<Customer>()
            {
                new Customer("Omeni saviour",SHA.ComputeSHA256Hash("asd@123"),"Male","omenigph@gmail.com")
            };
            Bank.Setup(x=>x.Database).Returns(database);

            //testcase
            var testcase1 = ("omenigph@gmail.com",("asd@123"));
            var testcase2 = ("omeni@gmail.com", ("asd@123"));

            // act
            var SUT1 = protocol.IsAuthenticated(testcase1.Item1, testcase1.Item2);
            var SUT2 = protocol.IsAuthenticated(testcase2.Item1, testcase2.Item2);

            // assert
            Assert.IsTrue(SUT1);
            Assert.IsFalse(SUT2);

        }
        [Test]
        public void IsAValidAccountNullTest()
        {
            // test moq
            List<Customer> database = new List<Customer>()
            {
                new Customer("Omeni saviour",SHA.ComputeSHA256Hash("asd@123"),"Male","omenigph@gmail.com")
            };
            var accountdetails = new AccountDetails((AccountType)1, 3000.00M,"0000002345");
            database.ForEach(x => x.CustomerAccountDetails.Add(accountdetails));
            Bank.Setup(x=>x.Database).Returns(database);

            // testcases
            var testcase1 = "0000002345";
            var testcase2 = "2120907574";

            // Act
            var Sut1 = protocol.IsAValidAccount(testcase1);
            var Sut2 = protocol.IsAValidAccount(testcase2);

            //Assert
            Assert.IsNotNull(Sut1);
            Assert.IsNull(Sut2);
        }
        [Test]
        public void CheckAccountabilityTestForNUll()
        {
            // test moq
            Customer database = new Customer("Omeni saviour", SHA.ComputeSHA256Hash("asd@123"), "Male", "omenigph@gmail.com");
            
            var accountdetails = new AccountDetails((AccountType)1, 3000.00M, "0000002345");
            database.CustomerAccountDetails.Add(accountdetails);
            Session.Setup(x => x.SESSION).Returns(database);

            var case1 = ("0000002345", 1000.00M);
            var case2 = ("2120907574", 2000.00M);

            //Act
            var Sut1 = protocol.CheckAccountability(case1.Item2,case1.Item1);
            var Sut2 = protocol.CheckAccountability(case2.Item2, case2.Item1);

            // Assert
            Assert.IsNotNull(Sut1);
            Assert.IsNull(Sut2);
        }
        [Test]
        public void CheckAccountabilityTestForAccountTypeTransfer()
        {
            // test moq
            Customer database = new Customer("Omeni saviour", SHA.ComputeSHA256Hash("asd@123"), "Male", "omenigph@gmail.com");

            var accountdetails = new AccountDetails((AccountType)0, 3000.00M, "0000002345");
            database.CustomerAccountDetails.Add(accountdetails);
            Session.Setup(x => x.SESSION).Returns(database);

            var case1 = ("0000002345", 1000.00M);
            var case2 = ("0000002345", 2500.00M);

            //Act
            var Sut1 = protocol.CheckAccountability(case1.Item2, case1.Item1);
            var Sut2 = protocol.CheckAccountability(case2.Item2, case2.Item1);

            // Assert
            Assert.IsNotNull(Sut1);
            Assert.IsNull(Sut2);
        }
    }
}
