using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Threading;
using NUnit.Framework;
using NUnit.Framework.Internal;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;


namespace TestProject2.Utilities
{
    public class Library : TestBase 
    {

        public static void sleep(double seconds)
        {
            Thread.Sleep((int)seconds*1000);
        }


        public static void TakeScreenShotPLZ(String saveAs)
        {
           // String DateTime= LocalDate.now().toString()+ LocalTime.now().toString().substring(0,5);

           
           String now = DateTime.Now.ToString();
           now=now.Replace("/", "").Replace(":","").Replace(" ", "");
           
          
           Screenshot ss = ((ITakesScreenshot) driver).GetScreenshot();
           String foldername =
               "/Users/maihemutimuhetaerjiang/RiderProjects/Selenium_With_C_Sharp/Selenium_With_CSharp/Captures/"+saveAs+"_"+now;
           ss.SaveAsFile(foldername,ScreenshotImageFormat.Png);

        }
        
        
        
        
     
        
        
    }
}