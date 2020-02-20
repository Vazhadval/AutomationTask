using AutomationTask.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Threading;
using OpenQA.Selenium.Chrome;
using AutomationTask.Help;

namespace AutomationTask
{
    [TestFixture]
    class Test
    {


        [SetUp]
        public void BeforeEach()
        {

            TestTools.driver = new ChromeDriver();
            //second parameter is for maximizing browser window
            HelperClass.OpenPage(MainPage.BaseURL,false);
            Console.WriteLine("Opened Main Page");
        }

        [TearDown]
        public void Cleanup()
        {
            TestTools.driver.Quit();
            Console.WriteLine("Closed driver");
        }


        [Test]
        public void ExecuteUploadTest()
        {
            var mainPage = new MainPage();
            var uploadPage = mainPage.GotoFileUpload();
            Console.WriteLine("Navigated to File Upload  Page");


            uploadPage.UploadFile(Constants.FilePath);
            Console.WriteLine("Choose File To Upload");


            uploadPage.ClickUpload();
            Console.WriteLine("Clicked Upload");


            Assert.IsTrue(TestTools.driver.FindElement(By.Id("uploaded-files")).Text == Constants.FileName);
            Console.WriteLine("File Uploaded Successfully");


        }

        [Test]
        public void ExecuteImagePositionTest()
        {
            var mainPage = new MainPage();
            var shiftingContent = mainPage.GotoShiftingContent();
            Console.WriteLine("Navigated to Shifting Content");

            shiftingContent.GotoImages();
            Console.WriteLine("Navigated to Images");


            //get coordinates of image before click link
            var image = TestTools.driver.FindElement(By.CssSelector("img[class='shift']"));

            var oldPosition = image.Location;

            //click second link
            TestTools.driver.FindElements(By.LinkText("click here"))[1].Click();
            Console.WriteLine("Clicked link");

            image = TestTools.driver.FindElement(By.CssSelector("img[class='shift']"));
            var newPosition = image.Location;

            Assert.IsTrue(oldPosition != newPosition);
            Console.WriteLine($"Image was on location X:{oldPosition.X}, Y:{oldPosition.Y} after click it appeared at X:{newPosition.X}, Y:{newPosition.X}");


        }
        [Test]
        public void ExecuteHoverTest()
        {
            var mainPage = new MainPage();
            var shiftingContent = mainPage.GotoShiftingContent();
            Console.WriteLine("Navigated to Shifting Content");

            shiftingContent.GotoMenuElement();
            Console.WriteLine("Navigated to Menus");


            HelperClass.HoverOnElement(TestTools.driver.FindElement(By.LinkText("Home")));
            Console.WriteLine("Hover on Home link");

            //check if text became black after mouse hover
            Assert.IsTrue(TestTools.driver.FindElement(By.LinkText("Home")).GetCssValue("Color") == Constants.Black);
            Console.WriteLine("Visual Changed");




        }




    }
}
