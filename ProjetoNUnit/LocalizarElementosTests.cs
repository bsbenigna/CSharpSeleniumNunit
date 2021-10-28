using NUnit.Framework;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

public class LocalizarElementosTests
{

  [Test]
  public void ValidaCampoBuscaSiteGoogle()
    {
      //arragements
      IWebDriver driver = new ChromeDriver("C:\\Repositorio Base2\\TreinamentoWeb");
   
     //actions
      driver.Navigate().GoToUrl("https://www.google.com.br");
      var busca = driver.FindElement(By.Name("q"));
      busca.SendKeys("Base2");
      busca.SendKeys(Keys.Return);
      driver.Quit();

      //assertions
      Assert.IsTrue(true);
           
    }
    
    [Test]
  public void PreencheCamposObrigatorios()
    {
      //arragements
      IWebDriver driver = new ChromeDriver();

      //actions
      driver.Navigate().GoToUrl("https://ultimateqa.com/filling-out-forms/");
      var campoNome = driver.FindElement(By.Id("et_pb_contact_name_0"));
      campoNome.SendKeys("Teste");

      var campoMensagem = driver.FindElement(By.Id("et_pb_contact_message_0"));
      campoMensagem.SendKeys("Hello");
          
      var botaoSubmit = driver.FindElement(By.Name("et_builder_submit_button"));  
      botaoSubmit.Click();

      var elementoMensagem = driver.FindElement(By.XPath("//*[@class='et-pb-contact-message']/p"));
      string mensagemRecebida = elementoMensagem.Text;
      driver.Quit();

      //assertions
      Assert.AreEqual("Thanks for contacting us", mensagemRecebida);
    }


  [Test]
  public void PreencheUmCampoObrigatorio()
    {
      //arragements
      IWebDriver driver = new ChromeDriver("C:\\Repositorio Base2\\TreinamentoWeb");

      //actions
      driver.Navigate().GoToUrl("https://ultimateqa.com/filling-out-forms/");

      var campoNome = driver.FindElement(By.Id("et_pb_contact_name_0"));
      campoNome.SendKeys("Teste");
      Thread.Sleep(2000);

      var botaoSubmit = driver.FindElement(By.Name("et_builder_submit_button"));
      botaoSubmit.Click();

      var elementoMensagem = driver.FindElement(By.XPath("//*[@class='et-pb-contact-message']/p"));
      string mensagemRecebida = elementoMensagem.Text;
      driver.Quit();

      //assertions
      Assert.AreEqual("Please, fill in the following fields:",mensagemRecebida);
    }

  [Test]
  public void ValidaCampoCaptchaFormularioADireita()
    {
      //arragements
      IWebDriver driver = new ChromeDriver();

      //actions
      driver.Navigate().GoToUrl("https://ultimateqa.com/filling-out-forms/");
      var campoNome = driver.FindElement(By.Id("et_pb_contact_name_1"));
      campoNome.SendKeys("Teste2");

      var campoMensagem = driver.FindElement(By.Id("et_pb_contact_message_1"));
      campoMensagem.SendKeys("Hello");
      Thread.Sleep(2000);
           
      var botaoSubmit = driver.FindElement(By.XPath("//*[@class='et_pb_contact_right']//following::button[@type='submit']"));
      botaoSubmit.Click();
           
      var elementoMensagem = driver.FindElement(By.XPath("//div[@class='et_pb_column et_pb_column_1_2 et_pb_column_2  et_pb_css_mix_blend_mode_passthrough et-last-child']//following::p [text()='Please, fill in the following fields:']"));
      string mensagemRecebida = elementoMensagem.Text;
      driver.Quit();

      //assertions
      Assert.AreEqual("Please, fill in the following fields:", mensagemRecebida);
    }       

}