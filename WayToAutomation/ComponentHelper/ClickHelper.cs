using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WayToAutomation.ComponentHelper
{
    class ClickHelper
    {
        private static IWebElement element;
        private static SelectElement select;

        public static void ClickLink(By Locator)
        {
            element = GenericHelper.GetElement(Locator);
            element.Click();

        }
        public static void TypeInTextBox(By Locator, string Text)
        {
            element = GenericHelper.GetElement(Locator);
            element.SendKeys(Text);
        }

        public static void SelectElement(By Locator, int index)
        {
            select = new SelectElement(GenericHelper.GetElement(Locator));
            select.SelectByIndex(index);
        }

        public static void SelectElement(By Locator, string visibletext)
        {
            select = new SelectElement(GenericHelper.GetElement(Locator));
            select.SelectByValue(visibletext);
        }

        public static IList<string> GetAllItem(By locator)
        {
            select = new SelectElement(GenericHelper.GetElement(locator));
            return select.Options.Select((x) => x.Text).ToList();
        }

        private static void Tolist()
        {
            throw new NotImplementedException();
        }

        private static object x(object arg)
        {
            throw new NotImplementedException();
        }
    }
}
