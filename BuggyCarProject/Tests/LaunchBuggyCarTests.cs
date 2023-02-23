using BuggyCarProject.Source.BaseClass;
using BuggyCarProject.Source.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace BuggyCarProject.Tests
{
    public class LaunchBuggyCarTests : Driver
    {
        [Test] 
        public void LunchApplication()
        {
            BuggyCar buggycar = new BuggyCar();
            _driver.Navigate().GoToUrl("https://buggy.justtestit.org/");
            _driver.Manage().Window.Maximize();
            Assert.True(_driver.Title.Contains("Buggy Cars Rating"));
            buggycar.Register();

            RegisterPageTests regtest = new RegisterPageTests();
            
            

         }

     
    }
}
