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
    public class TestCase7
    {
        [TestMethod]
        public void TestCase_7() {

            Login open = new Login();
            open.OpenPage();
            CommonFunctions.selectMenuoption("Widget");
            CommonFunctions.selectoptionfromMenu("Tooltip");
            Console.WriteLine("Tooltip has selected");
            WebDriverWait wait = new WebDriverWait((ObjectRepository.Driver), TimeSpan.FromSeconds(3));
            wait.Until(ExpectedConditions.ElementExists(By.XPath(ObjectRepository.defaultFunc)));
            (ObjectRepository.Driver).SwitchTo().DefaultContent();
            (ObjectRepository.Driver).SwitchTo().Frame(0);

            try
            {
                Console.WriteLine("\n///////Tooltip///////\n");
                string expectedTooltip = "We ask for your age only for statistical purposes.";
                IWebElement ele = (ObjectRepository.Driver).FindElement(By.XPath(ObjectRepository.age));
                string actualTooltip = ele.GetAttribute("title");
                (ObjectRepository.Driver).FindElement(By.XPath(ObjectRepository.age)).Click();
                Console.WriteLine("Actual Title of Tool Tip:  " + actualTooltip);
                Assert.AreEqual(expectedTooltip, actualTooltip);
                
                (ObjectRepository.Driver).SwitchTo().DefaultContent();
            }

            catch (NoSuchFrameException e)
            {
                Console.WriteLine(e);
            }
            catch (NoSuchElementException e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
