
using AutomationTask.Help;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace AutomationTask.Pages
{
    class ShiftingContent
    {
        [FindsBy(How = How.LinkText,Using = "Example 1: Menu Element")]
        private IWebElement MenuElement { get; set; }

        [FindsBy(How = How.LinkText, Using = "Example 2: An image")]
        private IWebElement AnImage { get; set; }


        public ShiftingContent()
        {
            PageFactory.InitElements(TestTools.driver, this);
        }

        public void GotoMenuElement()
        {
            MenuElement.Click();
        }

        public void GotoImages()
        {
            AnImage.Click();
        }


    }
}
