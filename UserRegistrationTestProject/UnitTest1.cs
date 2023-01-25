using UserRegistrationRegex;

namespace UserRegistrationTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow("Raj")]
        [DataRow("Harsh")]
        public void CheckValidateFirstName(string name)
        {
            var actual=RegexPattern.ValidateFirstName(name);
            Assert.AreEqual(true, actual);
        }
        [TestMethod]
        [DataRow("Soni")]
        [DataRow("Jain")]
        public void CheckValidateLastName(string name)
        {
            var actual = RegexPattern.ValidateLastName(name);
            Assert.AreEqual(true, actual);
        }
        [TestMethod]
        [DataRow("Raj@gmail.com")]
        [DataRow("Harsh.jain@gmail.com")]
        [DataRow("abc.xyz@bl.co.in")]
        public void CheckValidateEmail(string email)
        {
            var actual = RegexPattern.ValidateEmail(email);
            Assert.AreEqual(true, actual);
        }
        [TestMethod]
        [DataRow("91 9842905050")]
        [DataRow("91 1111111110")]
        [DataRow("91 9938491872")]
        public void CheckValidatephoneNumber(string phonenumber)
        {
            var actual =RegexPattern.ValidatephoneNumber(phonenumber);
            Assert.AreEqual(true, actual);
        }
        [TestMethod]
        [DataRow("Test@111")]
        [DataRow("Goforit@3")]
        [DataRow("1234A@11")]
        public void CheckValidatePassword(string password)
        {
            var actual = RegexPattern.ValidatePassword(password);
            Assert.AreEqual(true, actual);
        }
    }
}