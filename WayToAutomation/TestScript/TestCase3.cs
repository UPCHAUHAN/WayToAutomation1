using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using WayToAutomation.ComponentHelper;
using WayToAutomation.Settings;

namespace WayToAutomation.TestScript
{
    [TestClass]
    public class TestCase3
    {
        [TestMethod]
        public void SimpleAlert()
        {
            Login open = new Login();
            open.OpenPage();
            ClickHelper.ClickLink(By.XPath("//a[contains(text(), 'Alert')]"));
            Thread.Sleep(2000);
            
            ClickHelper.ClickLink(By.XPath("//a[contains(text(), 'Simple Alert')]"));
            ObjectRepository.Driver.SwitchTo().Frame(ObjectRepository.Driver.FindElement(By.XPath("//iframe[@src='alert/simple-alert.html']")));
            ClickHelper.ClickLink(By.XPath("//button[contains(text(), 'Click the button to display an alert box:')]"));
            String Msg = ObjectRepository.Driver.SwitchTo().Alert().Text;
            Assert.AreEqual("I am an alert box!", Msg);
            if ("I am an alert box!".Equals(Msg))
            {
                ObjectRepository.Driver.SwitchTo().Alert().Accept();
                Console.WriteLine("Valid Alert Box:  TestCase Passed");
            }
            else
            {
                Console.WriteLine("Invalid Alert Box:  TestCase Failed");
            }
        }
    }
}
