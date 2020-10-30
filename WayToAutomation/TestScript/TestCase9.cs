using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using WayToAutomation.ComponentHelper;
using WayToAutomation.Settings;

namespace WayToAutomation.TestScript
{
    [TestClass]

    public class TestCase9
    {
        [TestMethod]
        public void TestCase_9()
        {

            Login open = new Login();
            open.OpenPage();
            string result = "TC 9 Fail";

            (ObjectRepository.Driver).SwitchTo().DefaultContent();
            Thread.Sleep(2000);
            CommonFunctions.selectMenuoption("Widget");
            CommonFunctions.selectoptionfromMenu("Slider");
            
            Thread.Sleep(1000);
            (ObjectRepository.Driver).SwitchTo().Frame(0);
            IWebElement slider = (ObjectRepository.Driver).FindElement(By.XPath(ObjectRepository.slider));            
            slider.Click();
            var js = (IJavaScriptExecutor)(ObjectRepository.Driver);
            var myValue = js.ExecuteScript("return document.getElementById('amount').value");

            while (myValue.ToString() != "6")
            {
                slider.SendKeys(Keys.ArrowRight);
                myValue = js.ExecuteScript("return document.getElementById('amount').value");
            }



            if (myValue.ToString() == "6")
            {
                result = "TC 9 Pass";
                Console.WriteLine(result);
            }




            //return result;
        }
    }
}
