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
    public class TestCase2
    {
        [TestMethod]
        public void Entercountry()
        {
            try
            {
                Login open = new Login();
                open.OpenPage();
                CommonFunctions.selectMenuoption("Dynamic Elements");
                Thread.Sleep(2000);
                CommonFunctions.selectMenuoption("Dropdown");
                bool tx = (ObjectRepository.Driver).FindElement(By.XPath(ObjectRepository.enterCountrytab)).Displayed;
                Console.WriteLine("Verify enter country tab - " + tx);
                (ObjectRepository.Driver).FindElement(By.XPath(ObjectRepository.enterCountrytab)).Click();
                (ObjectRepository.Driver).SwitchTo().Frame(1);
                bool ele;
                ele = (ObjectRepository.Driver).FindElement(By.XPath(ObjectRepository.entercountrybox)).Displayed;
                if (ele)
                {
                    (ObjectRepository.Driver).FindElement(By.XPath(ObjectRepository.dropdownbutton)).Click();
                    Thread.Sleep(2000);
                    IList<IWebElement> count = (ObjectRepository.Driver).FindElements(By.XPath(ObjectRepository.autocompletevalue));
                    Console.WriteLine("Total country in enter country dropdown " + count.Count());

                    (ObjectRepository.Driver).FindElement(By.XPath(ObjectRepository.entercountrybox)).Click();
                    (ObjectRepository.Driver).FindElement(By.XPath(ObjectRepository.entercountrybox)).Clear();
                    (ObjectRepository.Driver).FindElement(By.XPath(ObjectRepository.entercountrybox)).SendKeys("Kenya");
                    Thread.Sleep(5000);
                    for (int i = 1; i < count.Count(); i++)
                    {
                        string countryfromList = (ObjectRepository.Driver).FindElement(By.XPath("*//ul[@id='ui-id-1']//li[" + i + "]")).Text.Trim();
                        if ((ObjectRepository.Driver).FindElement(By.XPath("*//ul[@id='ui-id-1']//li[" + i + "]")).Text.Trim().Equals("Kenya"))
                        {
                            Console.WriteLine("Country " + countryfromList + " is available in dropdown");
                            (ObjectRepository.Driver).FindElement(By.XPath("*//ul[@id='ui-id-1']//li[" + i + "]")).Click();
                            (ObjectRepository.Driver).SwitchTo().DefaultContent();
                            break;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Drop down is not available");
                }
            }
            catch (NoSuchFrameException e)
            {
                Console.WriteLine(e);
            }
            catch (NoSuchElementException e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                (ObjectRepository.Driver).Quit();
            }
        }
    }
}
