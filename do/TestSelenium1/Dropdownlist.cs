using Microsoft.VisualBasic;
using NUnit.Framework;

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using System;

namespace TestSelenium1
{
    public class Dropdownlist
    {


        //Se inicializa el driver de manera global
        public IWebDriver driver = new ChromeDriver(@"D:\vidapogosoft\cursos\2024\Sinergiass\CSDAbril\Herramientas\");

        //instancia de manera global la url de la pagina a testear
        public string url = "http://www.tizag.com/phpT/examples/formex.php";


        [Test]
        public void TestPage()
        {

            //set de la pagina a probar
            driver.Navigate().GoToUrl(url);

            //se maximiza el tamaño de ventana
            driver.Manage().Window.Maximize();

            //Seleccion de controles
            //por nombre
            driver.FindElement(By.Name("Fname")).SendKeys("CSD - Victor");
            driver.FindElement(By.Name("Lname")).SendKeys("Abril 2024");

            //por xpath
            driver.FindElement(By.XPath("//*[@id='examp']/form/input[3]")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//*[@id='examp']/form/input[4]")).Click();


            driver.FindElement(By.XPath("//*[@id='examp']/form/input[6]")).Click();


            driver.FindElement(By.Name("quote")).Clear();

            driver.FindElement(By.Name("quote")).SendKeys("CSD Abril 2024");

            //select the drop down list
            var education = driver.FindElement(By.Name("education"));
            var selectelement = new SelectElement(education);

            //select by value
            selectelement.SelectByValue("Jr.High");
            Thread.Sleep(5000);
            selectelement.SelectByText("College");

            //Take Foto
            ITakesScreenshot foto = driver as ITakesScreenshot;
            Screenshot screen = foto.GetScreenshot();

            screen.SaveAsFile(@"D:\vidapogosoft\cursos\2024\Sinergiass\CSDAbril\" + DateTime.Now.Ticks.ToString() + ".png");

            Assert.IsTrue(true);


        }

    }
}
