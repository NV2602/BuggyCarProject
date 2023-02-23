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
    public class SProfile : Driver
    {

        public SProfile() 
        {
            PageFactory.InitElements(_driver, this);
        }
        [FindsBy(How =How.Id , Using = "firstName")]
        private IWebElement _txtFname;

        [FindsBy(How = How.Id, Using = "age")]
        private IWebElement _txtAge;

        [FindsBy(How = How.Id, Using = "phone")]
        private IWebElement _txtPhone;

        [FindsBy(How = How.Id, Using = "currentPassword")]
        private IWebElement _txtCurPass;

        [FindsBy(How = How.Id, Using = "newPassword")]
        private IWebElement _txtNewPass;

        [FindsBy(How = How.Id, Using = "newPasswordConfirmation")]
        private IWebElement _txtNewConPass;

        [FindsBy(How = How.XPath, Using = "//div[@class='row btn-block']//div//button")]
        private IWebElement _btnSave;

        [FindsBy(How =How.XPath , Using = "//div//div[@class='result alert alert-success']")]
        private IWebElement _strSuccessMessage;

        [FindsBy(How = How.XPath, Using = "//li//span[@class='nav-link disabled']")]
        private IWebElement _strUpdatedName;


        [FindsBy(How = How.XPath, Using = "//li//a[text()='Logout']")]
        private IWebElement _btnLogout;


        public void UpdateProfile(string firstname,string age , string phone , string currentpass , string newpass)
        {
            _txtFname.Clear();
            Thread.Sleep(1000);
            _txtFname.SendKeys(firstname);
            _txtAge.Clear();
            Thread.Sleep(1000);
            _txtAge.SendKeys(age);
            _txtPhone.Clear();
            Thread.Sleep(1000);
            _txtPhone.SendKeys(phone);
            Thread.Sleep(1000);
            _txtCurPass.SendKeys(currentpass);
            Thread.Sleep(1000);
            _txtNewPass.SendKeys(newpass);
            Thread.Sleep(1000);
            _txtNewConPass.SendKeys(newpass);
            Thread.Sleep(1000);
            _btnSave.Click();
            Thread.Sleep(5000);
            //if(_strSuccessMessage.Text == "The profile has been saved successful")
            //{

            
               // Console.WriteLine(_strSuccessMessage.GetAttribute());
            //    Assert.IsTrue(_strSuccessMessage.Text.Contains("The profile"));
            
                
           // }     
    
        }

        public void VerifyUpdatedDetails(string vfirstname)
        {
            _driver.Navigate().Refresh();
            Thread.Sleep(1000);
            IJavaScriptExecutor js = (IJavaScriptExecutor)_driver;
            js.ExecuteScript("window.scrollTo(0, 0)");
            Thread.Sleep(3000);

            string vname = _strUpdatedName.Text;
            Assert.IsTrue(_strUpdatedName.Text.Contains(vfirstname));

            _btnLogout.Click();
            Thread.Sleep(4000);

        }
    }
}   
