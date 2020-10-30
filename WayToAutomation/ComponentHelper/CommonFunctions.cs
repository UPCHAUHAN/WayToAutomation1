using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using WayToAutomation.Settings;

namespace WayToAutomation.ComponentHelper
{
    public class CommonFunctions
    {
        public static void selectMenuoption(string menuname)
        {
            try
            {
                Thread.Sleep(3000);
                bool menuvisible = (ObjectRepository.Driver).FindElement(By.XPath("//li/a[text()='" + menuname + "']")).Displayed;
                IWebElement wb = (ObjectRepository.Driver).FindElement(By.XPath("//li/a[text()='" + menuname + "']"));
                IJavaScriptExecutor js = (IJavaScriptExecutor)(ObjectRepository.Driver);
                js.ExecuteScript("arguments[0].scrollIntoView();", wb);
                if (menuvisible)
                {
                    Console.WriteLine(menuname + " is visible");
                    (ObjectRepository.Driver).FindElement(By.XPath("//li/a[text()='" + menuname + "']")).Click();
                    Thread.Sleep(2000);
                }
                else
                {
                    Console.WriteLine("User selection is not valid");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public static void selectoptionfromMenu(string options)
        {
            try
            {
                (ObjectRepository.Driver).FindElement(By.LinkText("" + options + "")).Click();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}