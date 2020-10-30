using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WayToAutomation.ComponentHelper;
using WayToAutomation.Configuration;
using WayToAutomation.Settings;


namespace WayToAutomation.TestScript
{
    public class Login
    {
        public object LinkHelper { get; private set; }

        public void OpenPage()
        {
            //INavigation page = ObjectRepository.Driver.Navigate().;
            //page.GoToUrl(ObjectRepository.Config.GetWebsite());

            //ObjectRepository.Driver.Navigate().GoToUrl(ObjectRepository.Config.GetWebsite());

            NavigationHelper.NavigateToUrl(AppConfigReader.url);
            ObjectRepository.Driver.Manage().Window.Maximize();
            //IWebElement element = ObjectRepository.Driver.FindElement(By.LinkText("Signin"));
            //element.Click();

            ClickHelper.ClickLink(By.LinkText("Signin"));
            ClickHelper.TypeInTextBox(By.XPath("//div[@id='login']//input[@type='text']"), AppConfigReader.userName);
            ClickHelper.TypeInTextBox(By.XPath("//div[@id='login']//input[@type='password']"), AppConfigReader.getpasswor);

            ClickHelper.ClickLink(By.XPath("//div[@id='login']//input[@type='submit' and @value='Submit']"));
            Thread.Sleep(5000);


        }
    }
}
