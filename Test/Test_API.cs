using NUnit.Framework;
using HP.LFT.SDK.APITesting.UFT;
using System.Configuration;

namespace MyNamespace
{
    [TestFixture]
    public class Test_API : UnitTestClassBase
    {
        //For API test you need to create UFT API test and call them into your LeanFT Framework as below
        [Test]
        public void SampleApiTest()
        {
            APITestResult resultOriginal = APITestRunner.Run(ConfigurationManager.AppSettings["TestPath1"]+"UFT_API_TestName1");
            Assert.IsTrue(resultOriginal.Status == true);
        }

        [Test]
        public void AnotherApiTest()
        {
            APITestResult resultOriginal = APITestRunner.Run(ConfigurationManager.AppSettings["TestPath2"]+ "UFT_API_TestName2");
            Assert.IsTrue(resultOriginal.Status == true);
        }
    }
}
