﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.UITests.PageObjects
{
    public class UserLandingPage : BasePage
    {
        public UserLandingPage(IWebDriver driver)
            : base(driver, "")
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.LinkText, Using = "Report Pothole")]
        public IWebElement ReportPothole { get; set; }
        
    }
}
