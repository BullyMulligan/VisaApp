
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V109.Debugger;
using OpenQA.Selenium.Support.UI;

namespace VisaApp
{
    public class Sel
    {
        public static IWebDriver Driver = new ChromeDriver();
        private MyData _survey;

        public Sel(MyData survey)
        {
            _survey = survey;
        }
 
        public void StartPage()
        {
            Driver.Navigate().GoToUrl("https://ceac.state.gov/GenNIV/Default.aspx");
            Select(Variables.location,"INDONESIA, JAKARTA");
            string result = Microsoft.VisualBasic.Interaction.InputBox("Введите текст:", "Запрос текста", "");
            SendKeys(Variables.fieldCapcha,result);
        }

        private void Select(By select, string text)
        {
            IWebElement dropdown = Driver.FindElement(select);
            SelectElement selectElement = new SelectElement(dropdown);
            selectElement.SelectByText(text);
        }

        private void SendKeys(By element, string text)
        {
            Driver.FindElement(element).SendKeys(text);
        }
    }
}