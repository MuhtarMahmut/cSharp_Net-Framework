
using NUnit.Framework;
using TestProject2.Utilities;

namespace TestProject2
{
    [TestFixture]
    public class Tests : TestBase
    {
       
        
        [Test(Description = "Validate sign up button", Author = "Muhtar")]
        public void Test1()
        {
          
            driver.Navigate().GoToUrl("https://www.facebook.com");
            FB.searchbox.Click();


           
        }
    }
}