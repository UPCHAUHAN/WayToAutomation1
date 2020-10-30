using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;


namespace WayToAutomation.Settings
{
    public class ObjectRepository
    {
        public static string login = "//a [contains(text(),'Signin')]";
        public static string username = "//div[@id='login']//input [@type='text' and @name='username']";
        public static string password = "//div[@id='login']//input [@type='password']";
        public static string submitLogin = "//div[@id='login']//input [@type='submit' and @value='Submit' and @class='button']";
        public static string SelectCountry = "body:nth-child(2)>select";
        public static string SelectCountry1 = "//a[text()='Select Country']";
        public static string enterCountrytab = "//div[@class='internal_navi']//ul//li[2]//a";
        public static string entercountrybox = "//div[@class='ui-widget']//span[@class='custom-combobox']/input";
        public static string autocompletevalue = "//ul[@id='ui-id-1']//li";
        public static string dropdownbutton = "*//span[@class='ui-button-icon-primary ui-icon ui-icon-triangle-1-s']";
        public static string countCountry = "//body//select[not(@id='combobox')]/option";
        public static string enterCountry = "//a [contains(text(),'Enter Country')]";
        public static string enterCoun = "//input [@class='custom-combobox-input ui-widget ui-widget-content ui-state-default ui-corner-left ui-autocomplete-input']";
        public static string sampleAlert = "//a [contains(text(),'Simple Alert')]";
        public static string name = "//input [@type='text' and @name='name']";
        public static string phone = "//input [@type='tel' and @name='phone']";
        public static string email = "//input [@type='email' and @name='email']";
        public static string city = "//input [@type='text' and @name='city']";
        public static string userSign = "//div[@id='load_box']//input [@type='text' and @name='username']";
        public static string passSign = "//div[@id='load_box']//input [@type='password' and @name='password']";
        public static string sampleButton = "//button [contains(text(),'Click the button to display an alert box:')]";
        public static string inputButton = "//button [contains(text(),'Click the button to demonstrate the Input box.')]";
        public static string inputAlert = "//a [contains(text(),'Input Alert')]";
        public static string menuSub = "//a [contains(text(),'Menu With Sub Menu')]";
        public static string goAhead = " //*[@id='ui-id-8']//span[@class='ui-menu-icon ui-icon ui-icon-carat-1-e']";
        public static string menuDelphi = "//li[normalize-space(text())='Delphi']";
        public static string subMenu4 = "//*[@id='ui-id-8']/ul/li";
        public static string imputMessage = "//p [@id='demo']";
        public static string status = "//div[@class='radio_wrap']//label[1]//input[@name='m_status'][1]";
        public static string firstname = "//fieldset[@class='fieldset']/p[1]/input";
        public static string lastname = "//fieldset[@class='fieldset']/p[2]/input";
        public static string maritalstatusbutton = "//div[@class='radio_wrap']//label[1]//input[@name='m_status'][1]";
        public static string hobbyCheckbox = "//div[@class='radio_wrap']//label[1]//input[@name='hobby'][1]";
        public static string monthdropd ="//div[@class='time_feild'][1]//select[1]";
        public static string daydropd = "//div[@class='time_feild'][2]//select[1]";
        public static string yeardropd ="//div[@class='time_feild'][3]//select[1]";
        public static string phoneInput ="//fieldset[@class='fieldset']//input[@name='phone']";
        public static string usernameR = "//fieldset[@class='fieldset']//input[@name='username']";
        public static string emailInput = "//fieldset[@class='fieldset']//input[@name='email']";
        public static string aboutYourself = "//form[@id='register_form']/fieldset[10]/textarea";
        public static string passwordR = "//fieldset[@class='fieldset']//input[@name='password']";
        public static string confirmPass = "//fieldset[@class='fieldset']//input[@name='c_password']";
        public static string imageupload = "//form[@id='register_form']/fieldset[9]/input";
        public static string submitbuttonR = "//input[@type='submit']";
        public static string age = "//input[@id='age']";
        public static string toolTipHover = "//div [@class='ui-helper-hidden-accessible']//div[6] [contains(text(),'We ask for your age only for statistical purposes.')]";
        public static string defaultFunc = "//a [contains(text(),'Default functionality')]";
        public static string datePicker = "//input[@id='datepicker']";
        public static string nextMonth = "//span[@class='ui-icon ui-icon-circle-triangle-e']";
        public static string date = "//a[contains(text(), '27')]";
        public static string rangeSlider = "//a[contains(text(), 'Range slider')]";
        public static string moveSlider = "//div[@id='slider-range-max']//span";
        public static string selectCountryFromDropdown = "//body//select[not(@id='combobox')]";
        public static string EnterCountry = "//a[text()='Enter Country']";
        public static IWebDriver Driver { get; set; }
        public static string EnterCountryFromDropdown = "//body//div//span//input";
        public static string animationdropdown = "//select[@id='anim']";
        public static string animations = "//ul[@class='responsive-tabs']//li[2]/a";
        public static string MonthonDatePicker = "//div[@id='ui-datepicker-div']//div//div//span[1]";
        public static string YearonDatePicker = "//div[@id='ui-datepicker-div']//div//div//span[2]";
        public static string slider = "//div[@id='slider-range-max']/span";
    }
}
