using System;
using TechTalk.SpecFlow;

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using System.Threading;

namespace SpecFlow1.StepDefinitions
{
    [Binding]
    public class TestOutlineStepDefinitions
    {

        public IWebDriver driver = new ChromeDriver(@"D:\vidapogosoft\cursos\2024\Sinergiass\CSDAbril\code1\do\SpecFlow1\Drivers\selenium\123.0.6312.122\");

        public string URlLoginExitoso = "https://demoqa.com/profile";
        public string URlLoginValidar = "";

        [Given(@"Usuario se dirige a website demoqa.com/login")]
        public void GivenUsuarioSeDirigeAWebsiteDemoqa_ComLogin()
        {
            driver.Navigate().GoToUrl("https://demoqa.com/login");

            driver.Manage().Window.Maximize();
        }

        [When(@"para ingresar al site digita su usuario (.*) y contraseña (.*)")]
        public void WhenParaIngresarAlSiteDigitaSuUsuarioTestuser_YContrasenaTest(string user, string pwd)
        {
            driver.FindElement(By.Id("userName")).SendKeys(user);
            driver.FindElement(By.Id("password")).SendKeys(pwd);
        }

        [When(@"realiza click en  boton Login para ingresar")]
        public void WhenRealizaClickEnBotonLoginParaIngresar()
        {
            Thread.Sleep(5000);

            driver.FindElement(By.Id("login")).Click();
        }

        [Then(@"Login correcto")]
        public void ThenLoginCorrecto()
        {
            Thread.Sleep(5000);

            URlLoginValidar = driver.Url;

            Assert.AreEqual(URlLoginExitoso, URlLoginValidar);
        }
    }
}
