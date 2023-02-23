using BuggyCarProject.Source.Pages;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager;
using OpenQA.Selenium;
using BuggyCarProject.Source.BaseClass;
using AngleSharp.Dom;

namespace BuggyCarProject.Tests
{
    public class RegisterPageTests 
    {
        RegisterPage rp = new RegisterPage();
        [Test]
        public void RegisterSuccessful()
        {
            
            rp.Register("BuggyUser", "Neelam", "Verma", "Test@123", "Test@123");          

            
        }
        [Test]
        public void RegisterUnsuccessful()
        {
            Thread.Sleep(5000);
            rp.Alreadyegistered("BuggyUser", "Neelam", "Verma", "Test@123", "Test@123");
            
        }

        


    }
}
