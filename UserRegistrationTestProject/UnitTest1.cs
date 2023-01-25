using UserRegistrationRegex;

namespace UserRegistrationTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow("Raj")]
        [DataRow("Harsh")]
        public void CheckCorrectValidateFirstName(string name)
        {
            var actual=RegexPattern.ValidateFirstName(name);
            Assert.AreEqual(true, actual);
        }
        [TestMethod]
        [DataRow("raj")]
        [DataRow("Ha")]
        public void CheckWrongValidateFirstName(string name)
        {
            var actual = RegexPattern.ValidateFirstName(name);
            Assert.AreEqual(false, actual);
        }
        [TestMethod]
        [DataRow("Soni")]
        [DataRow("Jain")]
        public void CheckCorrectValidateLastName(string name)
        {
            var actual = RegexPattern.ValidateLastName(name);
            Assert.AreEqual(true, actual);
        }
        [TestMethod]
        [DataRow("So")]
        [DataRow("jain")]
        public void CheckWrongValidateLastName(string name)
        {
            var actual = RegexPattern.ValidateLastName(name);
            Assert.AreEqual(false, actual);
        }
        [TestMethod]
        [DataRow("Raj@gmail.com")]
        [DataRow("Harsh.jain@gmail.com")]
        [DataRow("abc.xyz@bl.co.in")]
        public void CheckCorrectValidateEmail(string email)
        {
            var actual = RegexPattern.ValidateEmail(email);
            Assert.AreEqual(true, actual);
        }
        [TestMethod]
        [DataRow("Raj@gmailcom")]
        [DataRow("Harsh.jaingmail.com")]
        [DataRow("abc.xyz#bl.co.in")]
        public void CheckWrongValidateEmail(string email)
        {
            var actual = RegexPattern.ValidateEmail(email);
            Assert.AreEqual(false, actual);
        }
        [TestMethod]
        [DataRow("91 9842905050")]
        [DataRow("91 1111111110")]
        [DataRow("91 9938491872")]
        public void CheckCorrectValidatephoneNumber(string phonenumber)
        {
            var actual =RegexPattern.ValidatephoneNumber(phonenumber);
            Assert.AreEqual(true, actual);
        }
        [TestMethod]
        [DataRow("919842905050")]
        [DataRow("91 110")]
        [DataRow("91 993849187268")]
        public void CheckWrongValidatephoneNumber(string phonenumber)
        {
            var actual = RegexPattern.ValidatephoneNumber(phonenumber);
            Assert.AreEqual(false, actual);
        }
        [TestMethod]
        [DataRow("Test@111")]
        [DataRow("Goforit@3")]
        [DataRow("1234A@11")]
        public void CheckCorrectValidatePassword(string password)
        {
            var actual = RegexPattern.ValidatePassword(password);
            Assert.AreEqual(true, actual);
        }
        [TestMethod]
        [DataRow("test@111")]
        [DataRow("Ofit@3")]
        [DataRow("A@abcdefgh")]
        public void CheckWrongValidatePassword(string password)
        {
            var actual = RegexPattern.ValidatePassword(password);
            Assert.AreEqual(false, actual);
        }
    }
}