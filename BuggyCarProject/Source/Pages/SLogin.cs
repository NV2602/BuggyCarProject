using BuggyCarProject.Source.BaseClass;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuggyCarProject.Source.Pages
{
    public class Slogin :Driver
    {
        WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
        public Slogin() 
        {

            PageFactory.InitElements(_driver, this);
        }

        [FindsBy(How = How.Name, Using = "login")]
        private IWebElement _txtlogin;

        [FindsBy(How = How.Name, Using = "password")]
        private IWebElement _txtpassword;

        [FindsBy(How = How.XPath, Using = "//button[text()='Login']")]
        private IWebElement _btnLogin;

        [FindsBy(How = How.XPath , Using = "//form[@class='form-inline']//div//span")]
        private IWebElement _strFailedmessage;

       [FindsBy(How = How.XPath , Using = "//li//a[text()='Logout']")]
         private IWebElement _strMessage;

        [FindsBy(How = How.XPath, Using = "//li//a[text()='Profile']")]
        private IWebElement _strProfile;

        public void BuggyFailedLogin(string username, string password)
        {
            _txtlogin.SendKeys(text: username);
           
            Thread.Sleep(2000);

            _txtpassword.SendKeys(text: password);
           
            Thread.Sleep(2000);
            _btnLogin.Click();

            Thread.Sleep(5000);
            if (_strFailedmessage.Displayed)
            {
                string strMessage = _strFailedmessage.Text;
                if (strMessage == "Invalid username/password")
                {
                    Assert.AreEqual("Invalid username/password", strMessage);
                    _txtlogin.Clear();
                    _txtpassword.Clear();
                }
            }
           
           
         }
        public void SuccessfulLogin(string username, string password)
        {
            _txtlogin.SendKeys(text: username);

            Thread.Sleep(2000);

            _txtpassword.SendKeys(text: password);

            Thread.Sleep(2000);
            _btnLogin.Click();

            Thread.Sleep(5000);

            Assert.IsTrue(_strMessage.Text.Contains("Logout"));
            _strProfile.Click();
            Thread.Sleep(5000);









        }
    }
}
