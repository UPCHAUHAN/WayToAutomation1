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
    public class TestCase4
    {
        [TestMethod]
        public void TestCase_4()
        {
            Login open = new Login();
            open.OpenPage();
            CommonFunctions.selectMenuoption("Alert");
            WebDriverWait wait = new WebDriverWait((ObjectRepository.Driver), TimeSpan.FromSeconds(3000));
            wait.Until(ExpectedConditions.ElementExists(By.XPath(ObjectRepository.inputAlert)));
            Console.WriteLine("\n///////Input Alert///////\n");
            try
            {
                bool element = (ObjectRepository.Driver).FindElement(By.XPath(ObjectRepository.inputAlert)).Displayed;
                (ObjectRepository.Driver).FindElement(By.XPath(ObjectRepository.inputAlert)).Click();
                
                (ObjectRepository.Driver).SwitchTo().Frame(1);
                if (element)
                {

                    wait.Until(ExpectedConditions.ElementExists(By.XPath(ObjectRepository.inputButton)));
                    (ObjectRepository.Driver).FindElement(By.XPath(ObjectRepository.inputButton)).Click();
                    var confirm_win = (ObjectRepository.Driver).SwitchTo().Alert();

                    string alertBox = confirm_win.Text;
                    if (alertBox.Equals("Please enter your name"))
                    {
                        Console.WriteLine("Verified 'Please enter your name'");
                        confirm_win.SendKeys("Nishant");
                        Console.WriteLine("Entered Name in the Alert Box");
                        Thread.Sleep(2000);
                        confirm_win.Accept();
                        Console.WriteLine("Clicked on 'OK' button");
                        string messageAlert = "Hello Nishant! How are you today?";
                         Assert.AreEqual(messageAlert, (ObjectRepository.Driver).FindElement(By.XPath(ObjectRepository.imputMessage)).Text);
                        if (messageAlert.Equals((ObjectRepository.Driver).FindElement(By.XPath(ObjectRepository.imputMessage)).Text))
                        {
                            Console.WriteLine("Verified 'Hello Nishant! How are you today?'");
                            Console.WriteLine("Test case passed");
                        }
                        else {
                            Console.WriteLine("Test case failed");
                        }

                        (ObjectRepository.Driver).SwitchTo().DefaultContent();

                    }
                    else
                    {
                        Console.WriteLine("Alert Box is not available");
                    }

                }
                else
                {
                    Console.WriteLine("Inout Alert option is not displayed");
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
        }
    }
}

