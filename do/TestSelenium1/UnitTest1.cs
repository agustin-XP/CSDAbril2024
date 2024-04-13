using Microsoft.VisualStudio.TestPlatform.PlatformAbstractions.Interfaces;
using NUnit.Framework;

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Threading;

namespace TestSelenium1
{
    public class Tests
    {
        //Se inicializa el driver de manera global
        public IWebDriver driver = new ChromeDriver(@"D:\vidapogosoft\cursos\2024\Sinergiass\CSDAbril\Herramientas\");

        //instancia de manera global la url de la pagina a testear
        public string url = "https://admin-sysnnova.com/OpenFact/Account/Login.aspx";

        [Test]
        public void Login1()
        {
            
            //set de la pagina a probar
            driver.Navigate().GoToUrl(url);

            //se maximiza el tamaño de la ventana
            driver.Manage().Window.Maximize();

            //instancia de los campos a traves de find elements
            driver.FindElement(By.Id("LoginUser_UserName"));
            driver.FindElement(By.Id("LoginUser_UserName")).Click();
            driver.FindElement(By.Id("LoginUser_UserName")).SendKeys("demo");


            driver.FindElement(By.Id("LoginUser_Password"));
            driver.FindElement(By.Id("LoginUser_Password")).Click();
            driver.FindElement(By.Id("LoginUser_Password")).SendKeys("0430");

            Thread.Sleep(8000);

            driver.FindElement(By.Id("LoginUser_LoginButton")).Click();

            Thread.Sleep(8000);

            driver.FindElement(By.Id("liClientes")).Click();

            Thread.Sleep(4000);

            driver.FindElement(By.Id("MainContent_btnAdd")).Click();
            Thread.Sleep(2000);

            ///llenar formulario
            driver.FindElement(By.Id("MainContent_txtNombreCliente")).SendKeys("VPR CURSO CSD");
            driver.FindElement(By.Id("MainContent_txtIdentificacion")).SendKeys("0819172559");
            driver.FindElement(By.Id("MainContent_txtTelefonoConvencional")).SendKeys("045114449");
            driver.FindElement(By.Id("MainContent_txtTelefonoCelular")).SendKeys("0952474445");
            driver.FindElement(By.Id("MainContent_txtDireccion")).SendKeys("ALBORADA 12VA ETAPA GYE");
            driver.FindElement(By.Id("MainContent_txtMailDefecto")).SendKeys("VICTOR.PORTUGAL@SINERGIASS.COM");

            //controles mas elaboradas
            //ddl
            var tipoident = driver.FindElement(By.Id("MainContent_ddlTipoIdentificacion"));
            var selectelement = new SelectElement(tipoident);
            selectelement.SelectByValue("05");
            Thread.Sleep(2000);

            //check
            IWebElement check1 = driver.FindElement(By.Id("MainContent_cbxEnviarBienvenida"));
            check1.Click();

            Thread.Sleep(8000);

            driver.FindElement(By.Id("MainContent_btnGuardarCliente")).Click();

            Thread.Sleep(5000);

            driver.SwitchTo().Alert().Accept();

            Thread.Sleep(10000);
            //cerrar pagina
            driver.Quit();
        }
    }
}