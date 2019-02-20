using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using TechTalk.SpecFlow;


namespace SeleniumTemplate
{
    [Binding]
    public class StepDefinition
    {
        private PageObject _pageObject;
        public PageObject PageObject => _pageObject ?? (_pageObject = new PageObject());
        public static IWebDriver Driver;
        public class Browser

        {
            public IWebDriver Chrome;

            public Browser()
            {
                var options = new ChromeOptions();
                options.AddArgument("--start-maximized");
                Chrome = new ChromeDriver(options);
            }
        }

        public StepDefinition(Browser browser)
        {
            Driver = browser.Chrome;
            PageFactory.InitElements(Driver, PageObject);
        }

       
        [Given(@"I navigate to claims")]
        public void GivenINavigateToClaims()
        {

            Driver.Url ="https://claim.skycop.com/";
        }

        [Then(@"i set Kaunas at departure airport")]
        public void ThenISetKaunasAtDepartureAirport()
        {
            Thread.Sleep(2000);
            PageObject.departureAirportField.SendKeys(Constants.departureAirportField);
            Thread.Sleep(2000);
            PageObject. kaunasselection.Click();
        }
        [Then(@"Then i set last arrived airport to Dublin")]
        public void ThenThenISetLastArrivedAirportToDublin()
        {
            Thread.Sleep(2000);
            PageObject. arrivedAirportField.SendKeys(Constants.arrivedAirportField);
            Thread.Sleep(2000);
            PageObject. dublinselection.Click();
        }

        [Then(@"I set airlines to wizzair")]
        public void ThenISetAirlinesToWizzair()
        {
            Thread.Sleep(2000);
            PageObject. airlinesselection.SendKeys(Constants.airlinesselection);
            Thread.Sleep(2000);
            PageObject. selectwizzair.Click();
        }

        [Then(@"I select flight number (.*)")]
        public void ThenISelectFlightNumber(int p0)
        {
            Thread.Sleep(2000);
            PageObject. flightnumberselection.SendKeys("1234");
        }

        [Then(@"I select flight date")]
        public void ThenISelectFlightDate()
        {
            Thread.Sleep(2000);
            PageObject. DataSelection.Click();
            PageObject. selectDate.Click();
            PageObject. datsel.Click();
        }

        [Then(@"I select problem")]
        public void ThenISelectProblem()
        {
            Thread.Sleep(2000);
            PageObject. problemselection.Click();
        }

            [Then(@"I seleckt delayed time")]
        public void ThenISelecktDelayedTime()
        {
            Thread.Sleep(2000);
            PageObject. timeselection.Click();
        }

        [Then(@"I select when i was informed about flight cancellation")]
        public void ThenISelectWhenIWasInformedAboutFlightCancellation()
        {
            Thread.Sleep(2000);
            PageObject. cancellationselection.Click();
        }

        [Then(@"I Select reason")]
        public void ThenISelectReason()
        {
            Thread.Sleep(2000);
            PageObject. reasonselection.Click();
            Thread.Sleep(1000);
            PageObject. selectReason.Click();
        }

        [Then(@"I select that i heard about them google search")]
        public void ThenISelectThatIHeardAboutThemGoogleSearch()
        {
            Thread.Sleep(1000);
            PageObject. selectarrow.Click();
            Thread.Sleep(1000);
            PageObject. selectabout.Click();
            Thread.Sleep(1000);
            PageObject. next.Click();
        }

        [Then(@"I describe situation")]
        public void ThenIDescribeSituation()
        {
            Thread.Sleep(2000);
            PageObject. describeSituation.SendKeys(Constants.describeSituation);
        }

        [Then(@"i enter flight reservation number")]
        public void ThenIEnterFlightReservationNumber()
        {
            Thread.Sleep(1000);
            PageObject. reservationNr.SendKeys(Constants.reservationNr);
            PageObject. travelDeatails.Click();
        }

        [Then(@"I put personal information")]
        public void ThenIPutPersonalInformation()
        {
            Thread.Sleep(1000);
            PageObject. name.SendKeys(Constants.name);
            PageObject. surename.SendKeys(Constants.surename);
            Thread.Sleep(1000);
            PageObject. birthdate.Click();
        }

        [Then(@"I enter my birth date")]
        public void ThenIEnterMyBirthDate()
        {
            PageObject. yearselection.Click();
            PageObject. year.Click();
            PageObject. month.Click();
            PageObject. day.Click();
        }

        [Then(@"I enter my email")]
        public void ThenIEnterMyEmail()
        {
            var emailfield = Driver.FindElement(By.XPath("(//input[@type='text'])[4]"));
            emailfield.SendKeys("albinas@alio.lt");
            var reapytemail = Driver.FindElement(By.XPath("(//input[@type='text'])[5]"));
            reapytemail.SendKeys("albinas@alio.lt");
        }

        [Then(@"I enter mu phone number")]
        public void ThenIEnterMuPhoneNumber()
        {
            var phoneNr = Driver.FindElement(By.XPath("//input[@name='userPhoneCode']"));
            phoneNr.Click();
            var country = Driver.FindElement(By.XPath("//div[text()='Lithuania']"));
            country.Click();
            var nr = Driver.FindElement(By.XPath("//input[@placeholder='Enter your phone number']"));
            nr.SendKeys("66874231");

        }

    }
}