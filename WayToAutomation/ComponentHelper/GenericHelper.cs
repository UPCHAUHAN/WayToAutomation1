using OpenQA.Selenium;
using System;
using WayToAutomation.Settings;

namespace WayToAutomation.ComponentHelper
{
    public class GenericHelper
    {
        public static bool IsElementPresent(By Locator)
        {
            try
            {
                return ObjectRepository.Driver.FindElements(Locator).Count == 1;
            }
            catch (Exception)
            {
                return false;

            }
        }


        public static IWebElement GetElement(By Locator)
        {
            if (IsElementPresent(Locator))
                return ObjectRepository.Driver.FindElement(Locator);
            else
                throw new NoSuchElementException("Element not found: " + Locator.ToString());
        }
    }
}
