using NUnit.Framework;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
//using SeleniumExtras.WaitHelpers;
using System.Threading;

public class EsperaImplicita
{
    
   [Test]
   [Obsolete]
   public void EsperaComobox()
      {
         IWebDriver driver = new ChromeDriver();         
         WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

         driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/dropdown");
            
         IWebElement elementoComobox= wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("dropdown")));
         SelectElement combobox = new SelectElement(elementoComobox);
         combobox.SelectByText("Option 2");

         string resultado = combobox.Options[2].GetProperty("selected");
         driver.Quit();
         Assert.AreEqual("True",resultado);
      }
           

   [Test]
   [Obsolete]
   public void AcessarMeusCasosDeTestesNoCrowdTest()
      {
         IWebDriver driver = new ChromeDriver();
           
         driver.Navigate().GoToUrl("http://blackmirror.crowdtest.me.s3-website-us-east-1.amazonaws.com/auth");

         var botaoprosseguir = driver.FindElement(By.XPath("//*[@class='cc-compliance']/a"));
         botaoprosseguir.Click();           
          
         //email
         var email = driver.FindElement(By.Id("login"));
         email.SendKeys("benigna.bernardes@base2.com.br");

         //senha
         var senha = driver.FindElement(By.Id("password"));
         senha.SendKeys("Kbj3FpA1");

         // E clico no botao entrar
         var botaoentrar = driver.FindElement(By.XPath("//*[@class='btn btn-crowdtest btn-block']"));
         botaoentrar.Click();
          
         WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
         wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@class='btn btn-crowdtest mr-1']")));  

         //E clico em “Gerencie seus projetos aqui”
         var botaogerenciar = driver.FindElement(By.XPath("//*[@class='btn btn-crowdtest mr-1']"));
         botaogerenciar.Click(); 

         //E clico no menu Projetos
         var botaoprojetos = driver.FindElement(By.XPath("//*[@class='li-projects']"));
         botaoprojetos.Click();
          
         wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@class='mat-cell cdk-column-identifier mat-column-identifier ng-star-inserted']")));

         // E clico no projeto criado no Módulo 1 - Testes Manuais
         var abrirprojeto = driver.FindElement(By.XPath("//*[@class='mat-cell cdk-column-identifier mat-column-identifier ng-star-inserted']"));
          abrirprojeto.Click(); 
          
         //E clico em Casos de Teste
         var abrircasosdeteste= driver.FindElement(By.Id("mat-tab-label-0-2"));
         abrircasosdeteste.Click(); 

         wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//mat-cell[@class='mat-cell cdk-column-id mat-column-id ng-star-inserted']")));
        
         var validarcasodeteste=driver.FindElement(By.XPath("//mat-cell[@class='mat-cell cdk-column-id mat-column-id ng-star-inserted']"));
         var resultado=validarcasodeteste.Text;
         //driver.Quit();

         Assert.AreEqual("1",resultado);

      }
}

