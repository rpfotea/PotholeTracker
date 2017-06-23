using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.UITests.PageObjects
{
    public class RegisterUserExist : BasePage
    {
        public RegisterUserExist(IWebDriver driver)
            :base(driver, "/user/register")
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.ClassName, Using = "field-validation-error")]
        public IWebElement EmailAlreadyExist { get; set; }
                
    }
}