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
    public class TestCase6
    {
        [TestMethod]
        public void Testcase_6()
        {
            Login open = new Login();
            open.OpenPage();

            CommonFunctions.selectMenuoption("Widget");
            CommonFunctions.selectoptionfromMenu("Menu");
            try
            {
                bool ele = (ObjectRepository.Driver).FindElement(By.XPath("//ul[@class='responsive-tabs']//li[2]//a[text()='Menu With Sub Menu']")).Displayed;
                if (ele)
                {
                    (ObjectRepository.Driver).FindElement(By.XPath("//ul[@class='responsive-tabs']//li[2]//a[text()='Menu With Sub Menu']")).Click();
                    (ObjectRepository.Driver).SwitchTo().Frame(1);
                    Console.WriteLine("User is inside the frame");
                    IWebElement wb = (ObjectRepository.Driver).FindElement(By.XPath("//li[normalize-space(text())='Delphi']"));
                    //IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                    //js.ExecuteScript("arguments[0].scrollIntoView();", wb);
                    wb.Click();

                    Thread.Sleep(3000);
                    IList<IWebElement> dd = (ObjectRepository.Driver).FindElements(By.XPath("//li[normalize-space(text())='Delphi']/ul/li"));
                    Console.WriteLine(dd.Count);

                    for (int i = 1; i <= dd.Count; i++)
                    {
                        string submenuname = (ObjectRepository.Driver).FindElement(By.XPath("//li[normalize-space(text())='Delphi']/ul/li[" + i + "]")).Text;
                        if (submenuname.Equals("Sub Menu 3"))
                        {
                            string test = (ObjectRepository.Driver).FindElement(By.XPath("//li[normalize-space(text())='Delphi']/ul/li[" + i + "]")).Text;
                            Console.WriteLine("Menu name - " + test + " is clicked");
                            (ObjectRepository.Driver).FindElement(By.XPath("//li[normalize-space(text())='Delphi']/ul/li[" + i + "]")).Click();
                        }
                    }
                    (ObjectRepository.Driver).SwitchTo().DefaultContent();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
