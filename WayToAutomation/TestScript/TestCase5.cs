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
    public class TestCase5
    {
        [TestMethod]
        public void TestCase_5()
        {

            Login open = new Login();
            open.OpenPage();

            CommonFunctions.selectMenuoption("Registration");

                bool ele = (ObjectRepository.Driver).FindElement(By.XPath("//div[@class = 'registration_form']/h2")).Displayed;
                Console.WriteLine("Registradion for display - True if displayed - " + ele);
                if (ele)
                {
                    Thread.Sleep(2000);
                    (ObjectRepository.Driver).FindElement(By.XPath(ObjectRepository.firstname)).Click();
                    (ObjectRepository.Driver).FindElement(By.XPath(ObjectRepository.firstname)).SendKeys("Uday");
                    (ObjectRepository.Driver).FindElement(By.XPath(ObjectRepository.lastname)).Click();
                    (ObjectRepository.Driver).FindElement(By.XPath(ObjectRepository.lastname)).SendKeys("Chauhan");

                    bool radiobutton = (ObjectRepository.Driver).FindElement(By.XPath(ObjectRepository.maritalstatusbutton)).Selected;
                    if (!radiobutton)
                    {
                        (ObjectRepository.Driver).FindElement(By.XPath(ObjectRepository.maritalstatusbutton)).Click();
                    }
                    bool checkbox = (ObjectRepository.Driver).FindElement(By.XPath(ObjectRepository.hobbyCheckbox)).Selected;
                    if (!checkbox)
                    {
                        (ObjectRepository.Driver).FindElement(By.XPath(ObjectRepository.hobbyCheckbox)).Click();
                    }

                    SelectElement monthdd = new SelectElement((ObjectRepository.Driver).FindElement(By.XPath(ObjectRepository.monthdropd)));
                    monthdd.SelectByValue("1");
                    SelectElement daydd = new SelectElement((ObjectRepository.Driver).FindElement(By.XPath(ObjectRepository.daydropd)));
                    daydd.SelectByValue("1");
                    SelectElement yeardd = new SelectElement((ObjectRepository.Driver).FindElement(By.XPath(ObjectRepository.yeardropd)));
                    yeardd.SelectByValue("2014");
                    (ObjectRepository.Driver).FindElement(By.XPath(ObjectRepository.phoneInput)).Click();
                    (ObjectRepository.Driver).FindElement(By.XPath(ObjectRepository.phoneInput)).SendKeys("6395573865");
                    (ObjectRepository.Driver).FindElement(By.XPath(ObjectRepository.usernameR)).Click();
                    (ObjectRepository.Driver).FindElement(By.XPath(ObjectRepository.usernameR)).SendKeys("usingh");
                    (ObjectRepository.Driver).FindElement(By.XPath(ObjectRepository.emailInput)).Click();
                    (ObjectRepository.Driver).FindElement(By.XPath(ObjectRepository.emailInput)).SendKeys("usingh@gmail.com");
                    (ObjectRepository.Driver).FindElement(By.XPath(ObjectRepository.aboutYourself)).Click();
                    (ObjectRepository.Driver).FindElement(By.XPath(ObjectRepository.aboutYourself)).SendKeys("Value entered");
                    (ObjectRepository.Driver).FindElement(By.XPath(ObjectRepository.passwordR)).Click();
                    (ObjectRepository.Driver).FindElement(By.XPath(ObjectRepository.passwordR)).SendKeys("ABCD123");
                    (ObjectRepository.Driver).FindElement(By.XPath(ObjectRepository.confirmPass)).Click();
                    (ObjectRepository.Driver).FindElement(By.XPath(ObjectRepository.confirmPass)).SendKeys("ABCD123");
                    //save the file at below given directory
                    IWebElement image = (ObjectRepository.Driver).FindElement(By.XPath(ObjectRepository.imageupload));
                    image.SendKeys("C:\\Users\\uday.singh\\Downloads\\Capture.JPG");
                    (ObjectRepository.Driver).FindElement(By.XPath(ObjectRepository.submitbuttonR)).Click();
                    Console.WriteLine("Ragistration is completed");
                    bool ele1 = (ObjectRepository.Driver).FindElement(By.XPath("//div[@class = 'registration_form']/h2")).Displayed;
                    //Assert.AreEqual(true, (ObjectRepository.Driver).FindElement(By.XPath(By.XPath("//div[@class = 'registration_form']/h2")).Displayed);
                    if (ele1)
                    {
                        Console.WriteLine("Ragistration form is back to default page");
                    }
                    else
                    {
                        Console.WriteLine("Ragistration form is not available");
                    }
                }
        }
    }
}
