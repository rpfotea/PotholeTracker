using Capstone.UITests.PageObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.UITests.SeleniumTests
{
    [TestClass]
    public class RegisterExistentUser
    {
        private static IWebDriver driver;

        [ClassInitialize]
        public static void SetUp(TestContext context)
        {
            driver = new ChromeDriver();

            driver.Navigate().GoToUrl("http://localhost:55601/");
        }

        [ClassCleanup]
        public static void Cleanup()
        {
            driver.Close();
            driver.Quit();
        }

        [TestMethod]
        public void SubmitRegisterInformation_WithExistingUser_GoToRegisterPageAndPrintErrorMessage()
        {
            RegisterPage registerPage = new RegisterPage(driver);
            registerPage.Navigate();

            RegisterUserExist registerUserExist = registerPage.FillOutRegister("petru.fotea@gmail.com", "Techelevator1@", "Techelevator1@", "Radu Fotea");

            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));

            Assert.AreEqual("An account with this email address already exists", registerUserExist.EmailAlreadyExist.Text);
        }
    }
}
