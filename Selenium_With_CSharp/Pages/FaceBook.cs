using OpenQA.Selenium;
using OpenQA.Selenium.Internal;
using OpenQA.Selenium.Support.Events;
using OpenQA.Selenium.Support.PageObjects;
using TestProject2.Utilities;

namespace TestProject2.Pages
{
    public class FaceBook : TestBase
    {
        public FaceBook()
        {
            PageFactory.InitElements(driver, this);
        }
      

      // this is how we create elements
    [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Sign Up')]")]
    public  IWebElement searchbox { get; set; }
    
    
    
    
    
    
      
    }
}