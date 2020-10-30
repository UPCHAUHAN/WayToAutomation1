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
    public class TestCase8
    {
        [TestMethod]
        public void TestCase_8()
        {

            // string result = "TC 8 Fail";

            Login open = new Login();
            open.OpenPage();

            (ObjectRepository.Driver).SwitchTo().DefaultContent();
            Thread.Sleep(2000);
            CommonFunctions.selectMenuoption("Widget");
            CommonFunctions.selectoptionfromMenu("Datepicker");
            //driver.FindElement(By.LinkText("Widget")).Click();
            //Thread.Sleep(1000);
            //driver.FindElement(By.LinkText("Datepicker")).Click();
            Thread.Sleep(1000);
            (ObjectRepository.Driver).FindElement(By.XPath(ObjectRepository.animations)).Click();
            (ObjectRepository.Driver).SwitchTo().Frame(1);
            Thread.Sleep(1000);
            SelectElement animations = new SelectElement((ObjectRepository.Driver).FindElement(By.XPath(ObjectRepository.animationdropdown)));
            IList<IWebElement> list = animations.Options;
            //Console.WriteLine(list.Count());
            animations.SelectByValue("clip");
            //driver.SwitchTo().Frame(1);
            IWebElement date = (ObjectRepository.Driver).FindElement(By.XPath("//input[@id='datepicker']"));
            date.Click();
            Thread.Sleep(2000);
            IWebElement month = (ObjectRepository.Driver).FindElement(By.XPath(ObjectRepository.MonthonDatePicker));
            string monthondatepicker = month.Text;
            IWebElement year = (ObjectRepository.Driver).FindElement(By.XPath(ObjectRepository.YearonDatePicker));
            string yearondatepicker = year.Text;





            if (monthondatepicker == "November")
            {
                IWebElement selectDate = (ObjectRepository.Driver).FindElement(By.XPath("//table//a[contains(text(),'27')]"));
                selectDate.Click();
                Console.WriteLine("Date 27th November 2020 is selected");
                //result = "TC 8 Pass";
            }
            else
            {
                IWebElement next = (ObjectRepository.Driver).FindElement(By.XPath("//div[@id='ui-datepicker-div']//a[@class = 'ui-datepicker-next ui-corner-all']"));
                next.Click();
                Thread.Sleep(2000);
                IWebElement selectDate = (ObjectRepository.Driver).FindElement(By.XPath("//table//a[contains(text(),'27')]"));
                selectDate.Click();
                Console.WriteLine("Date 27th November 2020 is selected");
                //  result = "TC 8 Pass";
            }

           // return result;
        }
    }
}
