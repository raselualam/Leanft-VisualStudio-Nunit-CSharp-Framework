using HP.LFT.SDK.Web;

namespace MyNamespace
{
    //This class is for all common item need for the entire Framework
    public class FrameworkBase
    {
        //Supplying instance of IBrowser for all functional library classes
        //Select Single Browser from below

        //InternetExplorer
        //public static IBrowser browser = BrowserFactory.Launch(BrowserType.InternetExplorer);

        //Chrome      
        public static IBrowser browser = BrowserFactory.Launch(BrowserType.Chrome);

        //Firefox
        //public static IBrowser browser = BrowserFactory.Launch(BrowserType.Firefox);

        //Edge
        //public static IBrowser browser = BrowserFactory.Launch(BrowserType.Edge);

        //Safari
        //public static IBrowser browser = BrowserFactory.Launch(BrowserType.Safari);
    }
}
