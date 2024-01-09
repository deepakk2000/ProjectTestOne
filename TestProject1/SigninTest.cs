using SigninLib;
namespace TestProject1
{
    [TestClass]
    public class SigninTest
    {
        [TestMethod]
        public void SuccessMethod()
        {
            string expResult = "valid user ";
            Assert.AreEqual(expResult, SignIn.Authenticate("sam", "sam@123"));
        }
        public void FailMethod()
        {
            string expResult = "invalid user credential";
            Assert.AreEqual(expResult, SignIn.Authenticate("ravi", "sam@123"));
        }
        public void AnonynousMethod()
        {
            string expResult = "You must provide username and password";
            Assert.AreEqual(expResult, SignIn.Authenticate(null,null));
        }
    }
}