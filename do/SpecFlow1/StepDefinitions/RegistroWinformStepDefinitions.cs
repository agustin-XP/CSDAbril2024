using System;
using TechTalk.SpecFlow;

using TechTalk.SpecFlow.Assist;
using SpecFlow.Actions.WindowsAppDriver;
using SpecFlow1.Drivers.dto;
using OpenQA.Selenium.Appium;

namespace SpecFlow1.StepDefinitions
{
    [Binding]
    public class RegistroWinformStepDefinitions
    {
        private readonly AppDriver _appDriver;

        public RegistroWinformStepDefinitions(AppDriver appDriver)
        {
            _appDriver = appDriver;
        }

        [Given(@"usuario se dirige a aplicativo winform de registro")]
        public void GivenUsuarioSeDirigeAAplicativoWinformDeRegistro()
        {
            var options = new AppiumOptions();
            options.AddAdditionalCapability("app", "D:\\vidapogosoft\\cursos\\2024\\Sinergiass\\CSDAbril\\Herramientas\\AppWinForm1.exe");
            options.AddAdditionalCapability("deviceName", "HP-VPR2");

            _appDriver.Current.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

        }

        [When(@"llena formulario con los siguientes datos")]
        public void WhenLlenaFormularioConLosSiguientesDatos(Table table)
        {
            var LisRegistro = table.CreateSet<Registro>();

            foreach (var data in LisRegistro)
            {

                _appDriver.Current.FindElementByAccessibilityId("TxtIdentificacion").SendKeys(data.identificacion);

                _appDriver.Current.FindElementByAccessibilityId("TxtNombres").Click();
                _appDriver.Current.FindElementByAccessibilityId("TxtNombres").SendKeys(data.nombres);


                _appDriver.Current.FindElementByAccessibilityId("TxtDireccion").Click();
                _appDriver.Current.FindElementByAccessibilityId("TxtDireccion").SendKeys(data.direccion);

                _appDriver.Current.FindElementByName("Confirmar Datos").Click();
            }
        }

        [When(@"visualizo datos registrados")]
        public void WhenRealizaClickEnBotonRegistrar()
        {
            throw new PendingStepException();
        }

        [Then(@"registro correcto")]
        public void ThenRegistroCorrecto()
        {
            throw new PendingStepException();
        }


    }
}
