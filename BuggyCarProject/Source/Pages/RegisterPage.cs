using BuggyCarProject.Source.BaseClass;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuggyCarProject.Source.Pages
{
    public class RegisterPage : Driver
    {
        public RegisterPage()
        {
            PageFactory.InitElements(_driver, this);

        }
        [FindsBy(How =How.Id ,Using = "username")]
        private IWebElement _txtlogin;

        [FindsBy(How = How.Id, Using = "firstName")]
        private IWebElement _txtfirstname;

        [FindsBy(How = How.Id, Using = "lastName")]
        private IWebElement _txtlastname;

        [FindsBy(How = How.Id, Using = "password")]
        private IWebElement _txtpassword;

        [FindsBy(How = How.Id, Using = "confirmPassword")]
        private IWebElement _txtconfirmpassword;

        [FindsBy(How = How.XPath, Using = "//button[text()='Register']")]
        private IWebElement _btnRegister;

        [FindsBy(How = How.XPath , Using = "//div[@class = 'result alert alert-success']")]
        private IWebElement _divSuccessful;

        [FindsBy(How = How.XPath , Using = "//div[@class='result alert alert-danger']")] 
        private IWebElement _divUnsuccessful;

        public void Scrollup()
        {
            //Scroll up the page
            IJavaScriptExecutor js = (IJavaScriptExecutor)_driver;
            js.ExecuteScript("window.scrollTo(0, 0)");
        }
        public void Register(string username, string firstname, string lastname, string password, string confirmpassword)
        {
            _txtlogin.SendKeys(username);
            Thread.Sleep(2000);
            _txtfirstname.SendKeys(text: firstname);
            Thread.Sleep(2000);
            _txtlastname.SendKeys(text: lastname);
            Thread.Sleep(2000);
            _txtpassword.SendKeys(text: password);
            Thread.Sleep(2000);
            _txtconfirmpassword.SendKeys(text: confirmpassword);
            Thread.Sleep(2000);
            _btnRegister.Click();
            Thread.Sleep(2000);
            string strSucessmessage = _divSuccessful.Text;
            Assert.AreEqual("Registration is successful", strSucessmessage);

            
        }

            public void Alreadyegistered(string username, string firstname, string lastname, string password, string confirmpassword)
            {
               Thread.Sleep(1000);
               _txtlogin.SendKeys(username);
                Thread.Sleep(1000);
                _txtfirstname.SendKeys(text: firstname);
                Thread.Sleep(1000);
                _txtlastname.SendKeys(text: lastname);
                Thread.Sleep(1000);
                _txtpassword.SendKeys(text: password);
                Thread.Sleep(1000);
                _txtconfirmpassword.SendKeys(text: confirmpassword);
                Thread.Sleep(1000);
                _btnRegister.Click();
                Thread.Sleep(1000);
                string strUnsucessful = _divUnsuccessful.Text;
                Assert.AreEqual("UsernameExistsException: User already exists", strUnsucessful);                            
                    
                                

            }

        }
}
