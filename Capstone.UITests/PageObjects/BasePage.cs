using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Capstone.UITests.PageObjects
{
    public abstract class BasePage
    {
        protected IWebDriver driver;

        //the full URL for the page
        public string Url { get; private set; }

        public BasePage(IWebDriver driver, string url)
        {
            this.driver = driver;
            this.Url = url;
        }

        public void Navigate()
        {
            string url = driver.Url;
            Uri currentUri = new Uri(url);
            string baseUrl = currentUri.Authority; //get the "base" of the URL
            driver.Navigate().GoToUrl(baseUrl + Url);
        }


    }
}
