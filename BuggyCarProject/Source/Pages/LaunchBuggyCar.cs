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
    public class BuggyCar :Driver
    {
        

        [FindsBy(How = How.LinkText, Using = "Register")]
        private IWebElement btnregister;

        public BuggyCar() 
        {
            PageFactory.InitElements(_driver, this);
         
        }
        public void Register()
        {

            btnregister.Click();
        }
    }
}
