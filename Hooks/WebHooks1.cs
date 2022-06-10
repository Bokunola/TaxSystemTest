using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Diagnostics;
using System.Reflection;
using TechTalk.SpecFlow;

namespace TaxSystems_Technical_Test.Hooks
{
    [Binding]
    public class WebHook
    {
        public static IWebDriver? driver;

        [BeforeScenario]
        public static void BeforeScenario()
        {
            var chromeOptions = new ChromeOptions();
            chromeOptions.AddArguments("headless");

            driver = new ChromeDriver(chromeOptions);

            //driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));

            driver.Manage().Window.Maximize();

            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(30);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
        }

        [AfterScenario]
        public void AfterScenario()

        {
            foreach (Process p in Process.GetProcessesByName("chromedriver.exe")) p.Kill();
            driver.Quit();


        }
    }
}
