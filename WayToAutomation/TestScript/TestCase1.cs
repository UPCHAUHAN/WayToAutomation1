using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using WayToAutomation.BaseClasses;
using WayToAutomation.ComponentHelper;
using WayToAutomation.Settings;

namespace WayToAutomation.TestScript
{
    [TestClass]
    public class TestCase1
    {
        [TestMethod]
        public void SelectCountry()
        {
            Login open = new Login();
            open.OpenPage();
            try
            {
                CommonFunctions.selectMenuoption("Dynamic Elements");
                Thread.Sleep(2000);
                CommonFunctions.selectMenuoption("Dropdown");
                (ObjectRepository.Driver).SwitchTo().Frame(0);
                bool ele = (ObjectRepository.Driver).FindElement(By.CssSelector(ObjectRepository.SelectCountry)).Displayed;
                if (ele)
                {
                    SelectElement oSelect = new SelectElement((ObjectRepository.Driver).FindElement(By.CssSelector(ObjectRepository.SelectCountry)));
                    IList<IWebElement> elementCount = oSelect.Options;
                    Console.WriteLine("Total country available in select country dropdown " + elementCount.Count);
                    for (int i = 0; i < elementCount.Count; i++)
                    {
                        String countryname = elementCount.ElementAt(i).Text;
                        if (countryname.Equals("Ghana"))
                        {
                            Console.WriteLine("Ghana" + " is available in Select Country dropdown");
                            oSelect.SelectByText("Ghana");
                            Thread.Sleep(2000);
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
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally {
                (ObjectRepository.Driver).Quit();
            }
        }        
    }
}
