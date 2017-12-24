using System;
using NUnit.Framework;

namespace MyNamespace
{
    [TestFixture]
    public class Test_UI : UnitTestClassBase
    {
        [SetUp]
        public void SetUp()
        { 
            Console.WriteLine("Nunit SetUp will run before test");
        }

        [TearDown]
        public void TearDown()
        {
            Console.WriteLine("Nunit TearDown will run after test");
        }

        [Test]
        public void SampleUiTest()
        {
            PageOneController().FunctionX("Url");
            PageOneController().FunctionY("UserName", "UserPass");
            PageOneController().FunctionZ("Value", "SearchBy");
            PageTwoController().FunctionNext();
            PageThreeController().FunctionLast();
        }

        [Test]
        public void AnotherUiTest()
        {
            PageTwoController().FunctionNext();
            PageThreeController().FunctionLast();
        }
    }
}
