using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Safari;

namespace TestProject2.Utilities
{

  public enum WebDriver
    {
        chrome, firefox, IE, safari, edge, none
        
    }
    
    public class Driver : TestBase
    {
        private static String str = ConfigurationReader.getProperties("Browser").ToLower();

        private static WebDriver myDriver = str.Equals("chrome")
            ? WebDriver.chrome
            : str.Equals("firefox")
                ? WebDriver.firefox
                : str.Equals("ie")
                    ? WebDriver.IE
                    : str.Equals("safari")
                        ? WebDriver.safari
                        : str.Equals("edge")
                            ? WebDriver.edge
                            : WebDriver.none;
        public static IWebDriver getDriver()
        {
            
            switch (myDriver)
            {
                case WebDriver.chrome:
                    driver = new ChromeDriver();
                    break;
                
                case WebDriver.firefox:
                    driver=new FirefoxDriver();
                    break;
                
                case WebDriver.IE:
                    driver= new InternetExplorerDriver();
                    break;
                
                case WebDriver.safari:
                    driver=new SafariDriver();
                    break;
                
                case WebDriver.edge:
                    driver= new EdgeDriver();
                    break;
                
                default:
                    driver = null;
                    break;
            }

            return driver;
        }
        
    }
}