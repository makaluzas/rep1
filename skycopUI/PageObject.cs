using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace SeleniumTemplate
{
    public class PageObject
    {
        [FindsBy(How = How.XPath, Using = "(//input [@class= 'Select-input'])[1]")]
        public IWebElement departureAirportField;

        [FindsBy(How = How.XPath, Using = "//div[@title='Kaunas International Airport']")]
        public IWebElement kaunasselection;

        [FindsBy(How = How.XPath, Using = "(//input [@class= 'Select-input'])[2]")]
        public IWebElement arrivedAirportField;

        [FindsBy(How = How.XPath, Using = "//div[@title='Dublin Airport']")]
        public IWebElement dublinselection;

        [FindsBy(How = How.XPath, Using = "(//input[@class='Select-input'])[3]")]
        public IWebElement airlinesselection;

        [FindsBy(How = How.XPath, Using = "//div[@id= 'react-select-5--option-0']")]
        public IWebElement selectwizzair;

        [FindsBy(How = How.XPath, Using = "//input[@class= 'form-control js-flightDigits js-checkable data-hj-whitelist sc-kkGfuU eUxbsH']")]
        public IWebElement flightnumberselection;

        [FindsBy(How = How.XPath, Using = "//input[@name= 'failedFlightDate']")]
        public IWebElement DataSelection;

        [FindsBy(How = How.XPath, Using = "//th[@class= 'rdtPrev']")]
        public IWebElement selectDate;

        [FindsBy(How = How.XPath, Using = "(//td[@data-value= '9'])[1]")]
        public IWebElement datsel;

        [FindsBy(How = How.XPath, Using = "(//span[@class= 'form-check-label form-check-label--bold'])[2]")]
        public IWebElement problemselection;

        [FindsBy(How = How.XPath, Using = "(//span[@class= 'form-check-label form-check-label--bold'])[6]")]
        public IWebElement timeselection;

        [FindsBy(How = How.XPath, Using = "//input[@class='Select-input']")]
        public IWebElement DeparturePort;

        [FindsBy(How = How.XPath, Using = "(//span[@class= 'form-check-label form-check-label--bold'])[7]")]
        public IWebElement cancellationselection;

                    [FindsBy(How = How.XPath, Using = "(//span[@class='Select-arrow'])[5]")]
        public IWebElement reasonselection;

        [FindsBy(How = How.XPath, Using = "//div[text()='Airport issues']")]
        public IWebElement selectReason;

        [FindsBy(How = How.XPath, Using = "(//span[@class= 'Select-arrow'])[6]")]
        public IWebElement selectarrow;

        [FindsBy(How = How.XPath, Using = "//div[text()= 'Facebook']")]
        public IWebElement selectabout;

        [FindsBy(How = How.XPath, Using = "//textarea[@name= 'comments']")]
        public IWebElement describeSituation;

        [FindsBy(How = How.XPath, Using = "//button[@type= 'submit']")]
        public IWebElement next;

        [FindsBy(How = How.XPath, Using = "(//input[@type= 'text'])[3]")]
        public IWebElement reservationNr;

        [FindsBy(How = How.XPath, Using = "//button[@type= 'submit']")]
        public IWebElement travelDeatails;

        [FindsBy(How = How.XPath, Using = "(//input[@type= 'text'])[1]")]
        public IWebElement name;

        [FindsBy(How = How.XPath, Using = "(//input[@type= 'text'])[2]")]
        public IWebElement surename;

        [FindsBy(How = How.XPath, Using = "(//input[@type= 'text'])[3]")]
        public IWebElement birthdate;

        [FindsBy(How = How.XPath, Using = "(//th[@class='rdtNext'])[1]")]
        public IWebElement yearselection;

        [FindsBy(How = How.XPath, Using = "//td[@data-value='1993']")]
        public IWebElement year;

        [FindsBy(How = How.XPath, Using = "//td[@data-value='3']")]
        public IWebElement month;

        [FindsBy(How = How.XPath, Using = "//td[@data-value='23']")]
        public IWebElement day;
    }
}
