using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using WayToAutomation.Configuration;
using WayToAutomation.Settings;

namespace WayToAutomation.BaseClasses
{
    [TestClass]
    public class BaseClass
    {
        private static IWebDriver GetChromeDriver()
        {
            IWebDriver driver = new ChromeDriver();
            return driver;
        }

        private static IWebDriver GetFirefoxDriver()
        {
            IWebDriver driver = new FirefoxDriver();
            return driver;
        }

        [AssemblyInitialize]
        public static void InitWebDriver(TestContext tc)
        {
            switch (AppConfigReader.getBrowser)
            {
                case "Chrome":
                    ObjectRepository.Driver = GetChromeDriver();
                    break;
                case "Firefox":
                    ObjectRepository.Driver = GetFirefoxDriver();
                    break;

                default:
                    throw new DriveNotFoundException();
            }
        }

        [AssemblyCleanup]
        public static void TearDown()
        {
           if (ObjectRepository.Driver != null)
           {
             ObjectRepository.Driver.Close();
             ObjectRepository.Driver.Quit();
           }
        }

    }
}
