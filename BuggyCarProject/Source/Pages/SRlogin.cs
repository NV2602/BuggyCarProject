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
    public class SRlogin : Driver
    {
      public SRlogin() 
        {
            PageFactory.InitElements(_driver, this);
        }

           

        


    }
}
