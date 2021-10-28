using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

[TestFixture]
public class NavegadorTests
{

        [Test]
        public void NavegacaoAteSiteDoGoogle()
        {
            //arragements
           IWebDriver driver = new ChromeDriver();

             //actions
           driver.Navigate().GoToUrl("https://www.google.com.br");
           driver.Quit();

              //assertions
           Assert.IsTrue(true);
        }

        [Test]
        public void ValidaNavegacaoAteSiteGoogle()
        {
            //arragements
            IWebDriver driver = new ChromeDriver();
            string title = null;

            //actions
           driver.Navigate().GoToUrl("https://www.google.com.br"); 
           title = driver.Title;
           driver.Quit();

            //assertions
           Assert.AreEqual("Google", title);           
          
        }

        [Test]
        public void ValidaLinkCorreto()
        {
            //arragements
           IWebDriver driver = new ChromeDriver();

            //actions
            driver.Navigate().GoToUrl("https://www.google.com.br");
            string url = driver.Url;
            driver.Quit();

            //assertions
            Assert.AreEqual("https://www.google.com.br/", url);
          
           }
}