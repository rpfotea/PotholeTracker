using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.UITests.PageObjects
{
    public class RegisterPage : BasePage
    {
        //Constructor for Register Page
        public RegisterPage(IWebDriver driver)
            : base(driver, "/user/register")
        {
            PageFactory.InitElements(driver, this);
        }

        //Elements on the page

        [FindsBy(How = How.Id, Using = "Email")]
        public IWebElement RegisterEmail { get; set; }

        [FindsBy(How = How.Id, Using = "Password")]
        public IWebElement RegisterPassword { get; set; }

        [FindsBy(How = How.Id, Using = "ConfirmPassword")]
        public IWebElement RegisterConfirmPassword { get; set; }

        [FindsBy(How = How.Id, Using = "Name")]
        public IWebElement RegisterName { get; set; }

        [FindsBy(How = How.Id, Using = "register_button")]
        public IWebElement RegisterButton { get; set; }

        public RegisterUserExist FillOutRegister(string email, string password, string conf_password, string name)
        {
            RegisterEmail.SendKeys(email.ToString());

            RegisterPassword.SendKeys(password.ToString());

            RegisterConfirmPassword.SendKeys(conf_password.ToString());

            RegisterName.SendKeys(name.ToString());

            RegisterButton.Click();

            return new RegisterUserExist(driver);

        }

    }
}
