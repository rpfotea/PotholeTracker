using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.UITests.PageObjects
{
    class LoginPage:BasePage
    {
        //Constructor for Login Page
        public LoginPage(IWebDriver driver)
            :base(driver, "/user/login")
        {
            PageFactory.InitElements(driver, this);
        }

        //Elements on the page

        [FindsBy(How = How.Id, Using = "Email")]
        public IWebElement Email { get; set; }

        [FindsBy(How = How.Id, Using = "Password")]
        public IWebElement Password { get; set; }

        [FindsBy(How = How.Id, Using = "login_button")]
        public IWebElement LoginButton { get; set; }

        public UserLandingPage FillOutForm(string email, string password)
        {
            Email.SendKeys(email.ToString());

            Password.SendKeys(password.ToString());

            LoginButton.Click();

            return new UserLandingPage(driver);
        }

        public EmployeeLandingPage FillOutFormEmployee(string email, string password)
        {
            Email.SendKeys(email.ToString());

            Password.SendKeys(password.ToString());

            LoginButton.Click();

            return new EmployeeLandingPage(driver);
        }
    }
}
