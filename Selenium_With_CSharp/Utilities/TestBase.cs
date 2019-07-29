using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using TestProject2.Pages;

namespace TestProject2.Utilities
{
    public class TestBase
    {
        public static TimeSpan timeout = TimeSpan.FromSeconds(10);
        
        // reusuables:
       public static IWebDriver driver;
       public static WebDriverWait wait;
       public static Actions act;

     
       
       // Pages:
       public static FaceBook FB;

        [SetUp]
        public void setUp01()
        {
            driver = Driver.getDriver();
            driver.Manage().Window.Maximize();
            driver.Url = ConfigurationReader.getProperties("WebSite");
            
            driver.Manage().Timeouts().ImplicitWait=timeout;
            
            act=new Actions(driver);
            
            wait=new WebDriverWait(driver,timeout);
           
        }
        

        [SetUp]   // for the pages:
        public void setUp02()
        {
            FB=new FaceBook(); // this step is a MUST
        }
        

        [TearDown]
        public void end( )
        {
            Library.sleep(3);
            driver.Quit();

        }

       
        
        
    }
}