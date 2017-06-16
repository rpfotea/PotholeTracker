using Capstone.UITests.PageObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.UITests.SeleniumTests
{
    [TestClass]
    public class LoginTest
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
        public void SubmitLoghinInformation_WithValidData_GoToUserLandingPage()
        {
            LoginPage loginPage = new LoginPage(driver);
            loginPage.Navigate();

            UserLandingPage userLandPg = loginPage.FillOutForm("petru.fotea@gmail.com", "Techelevator1@");

            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));

            Assert.AreEqual("Report Pothole", userLandPg.ReportPothole.Text);

        }

        [TestMethod]
        public void SubmitLoghinInformation_WithValidData_GoToEmployeeLandingPage()
        {
            LoginPage loginPage = new LoginPage(driver);
            loginPage.Navigate();

            EmployeeLandingPage userLandPg = loginPage.FillOutForm("p...", "Techelevator1@");

            // delay the assert test
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));

            Assert.AreEqual("Report Pothole", userLandPg.ReportPothole.Text);

        }




    }
}
