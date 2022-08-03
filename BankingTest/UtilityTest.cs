using NUnit.Framework;
using Utility;


namespace BankingTest
{
    [Category("Validation")]
    [TestFixture]
    public class ValidatingInputTest
    {
        private Validation Validation;
        [OneTimeSetUp]
        public void OnetimeSetup()
        {
            // arrange class 
            Validation = new Validation();
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            // tears down the code here 
            // dumps the code here
            Validation = null;
        }

        [Test]
        public void ValidationName()
        {
            // arrange
            var testcase1 = "Saviour";
            var testcase2 = "1omeni";
            var testcase3 = "chinonso";
            var testcase4 = "    spacedname       ";
            string testcase5 = "";

            // act
            // system under test
            var sut1 = Validation.ValidateName(testcase1);
            var sut2 = Validation.ValidateName(testcase2);
            var sut3 = Validation.ValidateName(testcase3);
            var sut4 = Validation.ValidateName(testcase4);
            var sut5 = Validation.ValidateName(testcase5);

            // Assert
            var expectedValueForsut3 = "Chinonso";
            var expectedValueForsut4 = "Spacedname";

            Assert.IsTrue(sut1.Item2);
            Assert.IsFalse(sut2.Item2);
            Assert.That(sut3.Item1, Is.EqualTo(expectedValueForsut3));
            Assert.That(sut4.Item1, Is.EqualTo(expectedValueForsut4));
            Assert.False(sut5.Item2);
        }

        [Test]
        public void ValidationEmail()
        {
            //arrange
            var EmailCase1 = "Omeni@gmail.com";
            var EmailCase2 = "omeni.saviioue.com";
            var EmailCase3 = "@dev.com";
            var EmailCase4 = "omeni.com@";
            string EmailCase5 = "";
            //act
            var sut1 = Validation.ValidateEmail(EmailCase1);
            var sut2 = Validation.ValidateEmail(EmailCase2);
            var sut3 = Validation.ValidateEmail(EmailCase3);
            var sut4 = Validation.ValidateEmail(EmailCase4);
            var sut5 = Validation.ValidateEmail(EmailCase5);
            // Assert
            Assert.True(sut1.Item2);
            Assert.True(!sut2.Item2);
            Assert.True(!sut3.Item2);
            Assert.True(!sut4.Item2);
            Assert.True(!sut5.Item2);

        }

        [Test]
        public void ValidationPassword()
        {
            // arrange 
            var PasswordCase1 = "";
            var PasswordCase2 = "omeni123";
            var PasswordCase3 = "@omeni123";
            var PasswordCase4 = "@#$123";
            var PasswordCase5 = "asd@123";
            var PasswordCase6 = "a@1";

            // Act 
            var sut1 = Validation.ValidatePassword(PasswordCase1);
            var sut2 = Validation.ValidatePassword(PasswordCase2);
            var sut3 = Validation.ValidatePassword(PasswordCase3);
            var sut4 = Validation.ValidatePassword(PasswordCase4);
            var sut5 = Validation.ValidatePassword(PasswordCase5);
            var sut6 = Validation.ValidatePassword(PasswordCase6);

            // assert
            Assert.True(!sut1.Item2);
            Assert.True(!sut2.Item2);
            Assert.True(sut3.Item2);
            Assert.True(!sut4.Item2);
            Assert.True(sut5.Item2);
            Assert.True(!sut6.Item2);

        }

    }

    [TestFixture]
    public class AccountGeneratorMethodTest
    {
        [Test]
        public void AccountNumberLengthTest()
        {
            //act
            var ActualLength = AccountGenerator.Generate().Length;
            // Assert
            Assert.That(ActualLength, Is.EqualTo(10));
        }
        [Test]
        public void AccountNumberGenerateNull()
        {
            //act
            var ActualValue = AccountGenerator.Generate();
            // Assert
            Assert.IsNotNull(ActualValue);
        }

    }
}
