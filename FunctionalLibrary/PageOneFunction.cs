using System;
using NUnit.Framework;

namespace MyNamespace
{
    [TestFixture]
    public class PageOneFunction : FrameworkBase
    {
        //Creating object of Application Model class
        public PageOneObject PageOneObj = null;

        //Supplying Ibrowser to the object of Application Model class
        public PageOneFunction()
        {
            PageOneObj = new PageOneObject(browser);
        }

        public void FunctionX(String URL)
        {
            browser.Navigate(URL);
        }

        public void FunctionY(String Value1, String Value2)
        {
            PageOneObj.PageOne.Obj1EditField.SetValue(Value1);
            PageOneObj.PageOne.Obj2EditField.SetValue(Value2);
        }

        public void FunctionZ(String Value3, String ValueDD)
        {
            PageOneObj.PageOne.Obj3EditField.SetValue(Value3);
            PageOneObj.PageOne.Obj4ListBox.Select(ValueDD);
            PageOneObj.PageOne.Obj5WebElement.Click();
        }
    }
}
