namespace MyNamespace
{
    public class PageThreeFunction : FrameworkBase
    {
        //Creating object of Application Model class
        public PageThreeObject PageThreeObj = null;

        //Supplying Ibrowser to the object of Application Model class
        public PageThreeFunction()
        {
            PageThreeObj = new PageThreeObject(browser);
        }

        public void FunctionLast()
        {
            browser.CloseAllTabs();
        }
    }
}
