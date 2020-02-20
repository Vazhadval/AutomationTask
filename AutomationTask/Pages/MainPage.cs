
using AutomationTask.Help;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace AutomationTask.Pages
{
    class MainPage
    {
        public const string BaseURL = "http://the-internet.herokuapp.com/";

        [FindsBy(How = How.LinkText, Using = "File Upload")]
        private IWebElement UploadFileLink;

        [FindsBy(How = How.LinkText, Using = "Shifting Content")]
        private IWebElement ShiftingContent;


        public MainPage()
        {
            PageFactory.InitElements(TestTools.driver, this);
        }


       

        public UploadPage GotoFileUpload()
        {
            UploadFileLink.Click();

            return new UploadPage();
        }

        public ShiftingContent GotoShiftingContent()
        {
            ShiftingContent.Click();

            return  new ShiftingContent();
        }


    }
}
