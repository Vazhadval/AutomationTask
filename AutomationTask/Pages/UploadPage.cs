
using AutomationTask.Help;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace AutomationTask.Pages
{
    class UploadPage
    {
        [FindsBy(How = How.Id, Using = "file-upload")]
        private IWebElement ChooseFile { get; set; }


        [FindsBy(How = How.Id, Using = "file-submit")]
        private IWebElement Upload { get; set; }


        public UploadPage()
        { 
            PageFactory.InitElements(TestTools.driver,this);
        }

        public void UploadFile(string filePath)
        {
            ChooseFile.SendKeys(filePath);
        }

        public void ClickUpload()
        {
            Upload.Click();
        }

    }
}
