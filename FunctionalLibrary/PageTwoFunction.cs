using NUnit.Framework;

namespace MyNamespace
{
    [TestFixture]
    public class PageTwoFunction : FrameworkBase
    {
        //Creating object of Application Model class
        public PageTwoObject PageTwoObj = null;

        //Supplying Ibrowser to the object of Application Model class
        public PageTwoFunction()
        {
            PageTwoObj = new PageTwoObject(browser);
        }

        public void FunctionNext()
        {
            PageTwoObj.PageTwo.Obj5Link.Click();
        }
    }
}
