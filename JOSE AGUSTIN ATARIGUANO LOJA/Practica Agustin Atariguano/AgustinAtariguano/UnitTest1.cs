using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace PruebaPractica
{
    class PruebaAgustin
    {
        private ChromeDriverService service;
        private IWebDriver driver;
        private string url = "https://admin-sysnnova.com/OpenFact/Account/Login.aspx?AspxAutoDetectCookieSupport=1";

        // Constructor
        public PruebaAgustin()
        {
            // Configura el servicio del ChromeDriver
            service = ChromeDriverService.CreateDefaultService();
            service.HideCommandPromptWindow = true;

            // Inicializa una nueva instancia de ChromeDriver
            driver = new ChromeDriver(service);
        }
        //generacion del metodo de prueba
        [Test]
        public void Registro()
        {
            ITakesScreenshot ScreenShotDrive = driver as ITakesScreenshot;

            Screenshot screenshot = ScreenShotDrive.GetScreenshot();

            try
            {
                //seteo de la pagina a probar 
                driver.Navigate().GoToUrl(url);
                //se maximiza la pagina 
                driver.Manage().Window.Maximize();
                //instancia del campo para login campo USER

                //captura al moemto del logeo 
                screenshot = ScreenShotDrive.GetScreenshot();
                screenshot.SaveAsFile(@"D:\Sistec\Proyectos\CSDAbril2024\JOSE AGUSTIN ATARIGUANO LOJA\Logeo" + DateTime.Now.Ticks.ToString() + ".png");

                driver.FindElement(By.Id("LoginUser_UserName"));
                driver.FindElement(By.Id("LoginUser_UserName")).Click();
                driver.FindElement(By.Id("LoginUser_UserName")).SendKeys("Demo");

                //instancia del campo para login campo PASS
                driver.FindElement(By.Id("LoginUser_Password"));
                driver.FindElement(By.Id("LoginUser_Password")).Click();
                driver.FindElement(By.Id("LoginUser_Password")).SendKeys("0430");

                //Pausa para procerder a dar click 
                WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
                //Click en login 
                driver.FindElement(By.Id("LoginUser_LoginButton")).Click();

                //Hasta este momento logueo exitoso
                //screenshot.SaveAsFile(@"C:\TODO\Personal\Capacitacion\PROYECTOS HECHO EN CURSO\PRINTSCREEN\" + " LogueoOK "+ ".png");
                screenshot = ScreenShotDrive.GetScreenshot();
                screenshot.SaveAsFile(@"D:\Sistec\Proyectos\CSDAbril2024\JOSE AGUSTIN ATARIGUANO LOJA\Lista" + DateTime.Now.Ticks.ToString() + ".png");

                WebDriverWait wait2 = new WebDriverWait(driver, new TimeSpan(0, 0, 10));

                driver.FindElement(By.Id("liClientes")).Click();
                Thread.Sleep(3000);
                WebDriverWait wait3 = new WebDriverWait(driver, new TimeSpan(0, 0, 10));

                driver.FindElement(By.Id("MainContent_btnAdd")).Click();
                Thread.Sleep(2000);
                WebDriverWait wait4 = new WebDriverWait(driver, new TimeSpan(0, 0, 10));

                driver.FindElement(By.Id("MainContent_txtNombreCliente"));
                driver.FindElement(By.Id("MainContent_txtNombreCliente")).Click();
                driver.FindElement(By.Id("MainContent_txtNombreCliente")).SendKeys("Agustin Atariguano");
                Thread.Sleep(2000);
                driver.FindElement(By.Id("MainContent_txtIdentificacion"));
                driver.FindElement(By.Id("MainContent_txtIdentificacion")).Click();
                driver.FindElement(By.Id("MainContent_txtIdentificacion")).SendKeys("0107101990");
                Thread.Sleep(2000);

                driver.FindElement(By.Id("MainContent_txtTelefonoConvencional"));
                driver.FindElement(By.Id("MainContent_txtTelefonoConvencional")).Click();
                driver.FindElement(By.Id("MainContent_txtTelefonoConvencional")).SendKeys("072257881");
                Thread.Sleep(2000);

                driver.FindElement(By.Id("MainContent_txtTelefonoCelular"));
                driver.FindElement(By.Id("MainContent_txtTelefonoCelular")).Click();
                driver.FindElement(By.Id("MainContent_txtTelefonoCelular")).SendKeys("0998560442");
                Thread.Sleep(2000); 

                driver.FindElement(By.Id("MainContent_txtDireccion"));
                driver.FindElement(By.Id("MainContent_txtDireccion")).Click();
                driver.FindElement(By.Id("MainContent_txtDireccion")).SendKeys("Av de las Americas, El Molino");
                Thread.Sleep(2000); 
                
                driver.FindElement(By.Id("MainContent_txtMailDefecto"));
                driver.FindElement(By.Id("MainContent_txtMailDefecto")).Click();
                driver.FindElement(By.Id("MainContent_txtMailDefecto")).SendKeys("jatariguano@sistec.com.ec");
                Thread.Sleep(2000);
               
                var TipoIdent = driver.FindElement(By.Id("MainContent_ddlTipoIdentificacion"));
                var selectElement = new SelectElement(TipoIdent);
                selectElement.SelectByValue("05");

                IWebElement Check1 = driver.FindElement(By.Id("MainContent_cbxEnviarBienvenida"));
                Check1.Click();

                screenshot = ScreenShotDrive.GetScreenshot();
                screenshot.SaveAsFile(@"D:\Sistec\Proyectos\CSDAbril2024\JOSE AGUSTIN ATARIGUANO LOJA\registro" + DateTime.Now.Ticks.ToString() + ".png");

                Thread.Sleep(2000);

                driver.FindElement(By.Id("MainContent_btnGuardarCliente")).Click();
                Thread.Sleep(4000);
                screenshot = ScreenShotDrive.GetScreenshot();
                screenshot.SaveAsFile(@"D:\Sistec\Proyectos\CSDAbril2024\JOSE AGUSTIN ATARIGUANO LOJA\" + DateTime.Now.Ticks.ToString() + ".png");
            }
            catch (Exception ex)
            {
                screenshot.SaveAsFile(@"D:\Sistec\Proyectos\CSDAbril2024\JOSE AGUSTIN ATARIGUANO LOJA\" + " Error " + ".png");
                driver.Close();
            }
        }
    }
}
