
using System;
using NUnit.Framework;
using TestProject2.Utilities;

namespace TestProject2
{
    [TestFixture]
    public class Tests : TestBase
    {

        [Test(Description = "Verify Page Title conatins 'Facebook'")]
        public void Test1()
        {
            string titile = driver.Title;
            Console.WriteLine(titile);
            Assert.True(titile.Contains("Facebook"));
        }
        

        [Test(Description = "verify that sign up button is clickable")]
        public void Test2()
        {
            bool result = FB.searchbox.Enabled;
            Assert.True(result);
        }
        
        
       
        
        [Test(Description = "Validate sign up button")]
        public void Test3()
        {
            FB.searchbox.Click();
        }
        
        
    }
}