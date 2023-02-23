﻿using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager;

namespace BuggyCarProject.Source.BaseClass
{
    public class Driver
    {
        public static IWebDriver _driver;

        [SetUp]
        public void InitScript()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
            _driver = new ChromeDriver();
        }


    }
}
