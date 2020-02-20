
using AutomationTask.Help;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace AutomationTask
{
    static class HelperClass
    {

        public static void OpenPage(string url, bool maximizeWindow = false)
        {
            TestTools.driver.Navigate().GoToUrl(url);
            if (maximizeWindow) TestTools.driver.Manage().Window.Maximize();
        }


        public static void HoverOnElement(IWebElement element)
        {
            Actions actions = new Actions(TestTools.driver);
            actions.MoveToElement(element).Build().Perform();
        }
    }
}
