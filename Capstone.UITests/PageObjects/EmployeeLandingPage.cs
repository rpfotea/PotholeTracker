using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.UITests.PageObjects
{
    public class EmployeeLandingPage:BasePage
    {
        public EmployeeLandingPage(IWebDriver driver)
            :base (driver, "")
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How= How.Id, Using= "employee_portal")]
        public IWebElement EmployeePortal { get; set; }

    }
}
