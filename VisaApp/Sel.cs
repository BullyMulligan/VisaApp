using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V109.Debugger;
using Google.Cloud.Translate.V3;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using VisaApp;

namespace VisaApp
{
    public class Sel
    {
        public static IWebDriver Driver; 
        private MyData _survey;
        private string _password = "Popova";
        private List<string> _date;

        public Sel(MyData survey)
        {
            _survey = survey;
        }

        private void Capcha()
        {
            Driver = new ChromeDriver();
            Driver.Navigate().GoToUrl("https://ceac.state.gov/GenNIV/Default.aspx");
            Driver.Manage().Timeouts().ImplicitWait=TimeSpan.FromSeconds(10);
            Driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(20);
            Driver.Manage().Timeouts().AsynchronousJavaScript = TimeSpan.FromSeconds(10);
            
            Select(VisaApp.Capcha.selectLocation,"INDONESIA, JAKARTA");
            string result = Microsoft.VisualBasic.Interaction.InputBox("Введите текст:", "Запрос текста", "");
            SendKeys(VisaApp.Capcha.fieldCapcha,result);
        }
        public MyData CreateUser()
        {
            Capcha();
            Click(VisaApp.Capcha.btnStartApplication);
            
            Click(VisaApp.CreateUser.checkBoxAgree);
            GetText(VisaApp.CreateUser.labelTourID);
            
            SendKeys(VisaApp.CreateUser.fieldSecretPassword,_password);
            Click(VisaApp.CreateUser.btnContinue);

            return _survey;
        }

        public void ContinueChangeUser()
        {
            Capcha();
            Click(VisaApp.Capcha.btnContinueApplication);
            SendKeys(ContinueUser.fieldId,_survey.unique_id);
            Click(ContinueUser.btnContinueChange);
            SendKeys(ContinueUser.fieldFiveLetName,Transliterate(_survey.full_name.surnname));
            SendKeys(ContinueUser.fieldYearOfBirth,_survey.birth_date);
            SendKeys(ContinueUser.fieldMnM,_password);
            Click(ContinueUser.btnContinueChangeAgain);
        }

        public void SuccessSave()
        {
            Click(VisaApp.SavePage.btnSuccessSave);
        }

        public void NextPage()
        {
            Click(Personal1.btnPersonalZeroNext);
        }
        public void PersonalOne()
        {
            SendKeys(Personal1.fieldSurname,Transliterate(_survey.full_name.surnname));
            SendKeys(Personal1.fieldName,Transliterate(_survey.full_name.name));
            SendKeys(Personal1.fieldFullName,$"{_survey.full_name.surnname} {_survey.full_name.name} {_survey.full_name.fathername}");
            if (_survey.second_name!=null)
            {
                Click(Personal1.checkBoxOtherNameYes);
                SendKeys(Personal1.fieldOtherSurname,Transliterate(_survey.second_name));
                SendKeys(Personal1.fieldOtherName,Transliterate(_survey.full_name.name));
            }
            else
            {
                Click(Personal1.checkBoxOtherNameNo);
            }
            Click(Personal1.checkBoxTeleCode);

            Select(Personal1.selectBoxSex,_survey.sex);
            Select(Personal1.selectMaritalStatus,_survey.marital_status);
            AddDate(_survey.birth_date);
            Select(Personal1.selectBirthDateDay,_date[0]);
            Select(Personal1.selectBirthDateMonth,_date[1]);
            SendKeys(Personal1.fieldBirthDateYear,_date[2]);
            SendKeys(Personal1.fieldBirthCity,Transliterate(_survey.birth_sity));
            Click(Personal1.checkBoxRegionNotApply);
            Select(Personal1.selectBirthCountry,TranslateEn(_survey.birth_country));
            SavePage();
        }

        public void PersonalTwo()
        {
            Select(Personal2.selectNationality,TranslateEn(_survey.sitizenship.sitizenship));
            if (!_survey.sitizenship.second_sitizenship)
            {
                Click(Personal2.checkHaveAnyNationalityNo);
            }
            else
            {
                Click(Personal2.checkHaveAnyNationalityYes);
                Select(Personal2.selectOtherCountryNation,TranslateEn(_survey.sitizenship.second_country));
                if (!_survey.sitizenship.second_passport_availability)
                {
                    Click(Personal2.checkOtherPassportNo);
                }
                else
                {
                    Click(Personal2.checkOtherPassportYes);
                    SendKeys(Personal2.fieldOtherPassportNumber,_survey.sitizenship.number_second_passport);
                }
            }

            if (!_survey.sitizenship.permanent_resident)
            {
                Click(Personal2.checkPermanentResidentNo);
            }
            else
            {
                Click(Personal2.checkPermanentResidentYes);
                SendKeys(Personal2.selectOtherPermanentCountry,TranslateEn(_survey.sitizenship.second_sitizen_country));
            }

            if (_survey.stay_in_usa.national_identification_number!=null)
            {
                SendKeys(Personal2.fieldNationalIdentificationNumber,_survey.stay_in_usa.national_identification_number);
            }
            else
            {
                Click(Personal2.checkNationalIdentificationNumber);
            }
            
            if (_survey.stay_in_usa.national_identification_number!=null)
            {
                SendKeys(Personal2.fieldSocialNumberOne,_survey.stay_in_usa.social_security_number.Substring(0, 3));
                SendKeys(Personal2.fieldSocialNumberTwo,_survey.stay_in_usa.social_security_number.Substring(3, 2));
                SendKeys(Personal2.fieldSocialNumberThree,_survey.stay_in_usa.social_security_number.Substring(5,4));
            }
            else
            {
                Click(Personal2.checkSocialNumber);
            }

            if (_survey.stay_in_usa.taxpayer_number!=null)
            {
                SendKeys(Personal2.fieldTaxpayerId,_survey.stay_in_usa.taxpayer_number);
            }
            else
            {
                Click(Personal2.checkTaxpayerId);
            }
            SavePage();
        }

        public void TravelInfornation()
        {
            Select(Travel.selectVisaTypeChar,_survey.info_about_travel.visa_char);
            Select(Travel.selectVisaType,_survey.info_about_travel.visa_type);
            Click(Travel.checkHaveTravelPlansYes);
            AddDate(_survey.info_about_travel.arrival_date,Travel.selectDateArrivalDay,Travel.selectDateArrivalMonht,Travel.fieldDateArrivalYear);
            SendKeys(Travel.fieldArrivalCity,TranslateEn(_survey.info_about_travel.arrival_city));
            AddDate(_survey.info_about_travel.departure_date,Travel.selectDateDepartureDay,Travel.selectDateDepartureMonht,Travel.fieldDateDepartureYear);
            SendKeys(Travel.fieldDepartureCity,TranslateEn(_survey.info_about_travel.departure_city));
            AddAndFillFields(_survey.info_about_travel.travel_places,Travel.btnAddLocationTravel,Travel.fieldAddLocationTravel);
            SendKeys(Travel.fieldWillStayStreet1,TranslateEn(_survey.info_about_travel.stop_address.street));
            SendKeys(Travel.fieldWillStayCity,TranslateEn(_survey.info_about_travel.stop_address.city));
            Select(Travel.selectWillStayState,TranslateEn(_survey.info_about_travel.stop_address.region));
            SendKeys(Travel.fieldWillStayIndex,_survey.info_about_travel.stop_address.index);
            Select(Travel.selectPayerPerson,_survey.info_about_travel.payer);
            SavePage();
        }

        public void TravelCompanionsInformation()
        {
            if (_survey.companions!=null)
            {
                Click(Companions.checkHaveCompanionYes);
                if (_survey.info_about_travel.have_group)
                {
                    Click(Companions.checkHaveOrganizationYes);
                    SendKeys(Companions.fieldGroupName,_survey.info_about_travel.group_name);
                }
                else
                {
                    Click(Companions.checkHaveOrganizationNo);
                    AddAndFillCompanions(_survey.companions,Companions.btnAddCompanion,Companions.fieldSurnameCompanion,Companions.fieldNameCompanion,Companions.selectRelationShip);
                }
            }
            else
            {
                Click(Companions.checkHaveCompanionNo);
            }
            SavePage();
            
        }

        private void SavePage()
        {
            Click(Personal1.btnPersonalZeroSave);
            SuccessSave();
            Click(Personal1.btnPersonalZeroNext);
        }

        private void AddAndFillCompanions<T>(List<T>list, By button, By surname, By name, By relationship)
        {
            
            for (int i = 0; i < list.Count-1; i++)
            {
                Driver.FindElements(button)[i].Click();
                Thread.Sleep(1000);
            }
            for (int i = 0; i < list.Count; i++)
            {
                string[] words = _survey.companions[i].name.Split(' ');
                Driver.FindElement(By.Id($"ctl00_SiteContentPlaceHolder_FormView1_dlTravelCompanions_ctl0{i}_tbxSurname")).SendKeys(TranslateEn(words[0]));
                Driver.FindElement(By.Id($"ctl00_SiteContentPlaceHolder_FormView1_dlTravelCompanions_ctl0{i}_tbxGivenName")).SendKeys(TranslateEn(words[1]));
            }
            for (int i = 0; i < list.Count; i++)
            {
                IWebElement element = Driver.FindElements(relationship)[i];
                SelectElement selectElement = new SelectElement(element);
                selectElement.SelectByIndex(_survey.companions[i].status);
            }
        }
        //добавляем поля и заполняем их в зависимости от количество полей
        private void AddAndFillFields<T>(List<T> list, By button, By field)
        {
            for (int i = 0; i < list.Count-1; i++)
            {
                Driver.FindElements(button)[i].Click();
                Thread.Sleep(1000);
            }

            for (int i = 0; i < list.Count; i++)
            {
                Driver.FindElements(field)[i].SendKeys(TranslateEn(list[i].ToString()));
            }
        }

        //заполняем форму с датой
        private void AddDate(string fullDate,By day, By month, By year)
        {
            AddDate(fullDate);
            Select(day,_date[0]);
            Select(month,_date[1]);
            SendKeys(year,_date[2]);
        }

        //метод расставляет простые чекбоксы. Параметры: булевое поле из анкеты и чекбокс да или нет
        private void CheckBox(bool answer,By yes,By no)
        {
            if (answer)
            {
                Click(yes);
            }
            else
            {
                Click(no);
            }
        }
        

        private void GetText(By element)
        {
            IWebElement span = Driver.FindElement(element);
            _survey.unique_id = span.Text;
        }
        
        private void Click(By element)
        {
            Driver.FindElement(element).Click();
        }
        private void Select(By select, string text)
        {
            IWebElement dropdown = Driver.FindElement(select);
            SelectElement selectElement = new SelectElement(dropdown);
            selectElement.SelectByText(text);
        }
        private void Select(By select, int number)
        {
            IWebElement dropdown = Driver.FindElement(select);
            SelectElement selectElement = new SelectElement(dropdown);
            selectElement.SelectByIndex(number);
        }
        

        private void SendKeys(By element, string text)
        {
            Driver.FindElement(element).SendKeys(text);
        }
        private string Transliterate(string text)
        {
            Dictionary<char, string> dictionary = new Dictionary<char, string>
            {
                {'а', "a"}, {'б', "b"}, {'в', "v"}, {'г', "g"}, {'д', "d"}, {'е', "e"}, {'ё', "yo"},
                {'ж', "zh"}, {'з', "z"}, {'и', "i"}, {'й', "y"}, {'к', "k"}, {'л', "l"}, {'м', "m"},
                {'н', "n"}, {'о', "o"}, {'п', "p"}, {'р', "r"}, {'с', "s"}, {'т', "t"}, {'у', "u"},
                {'ф', "f"}, {'х', "h"}, {'ц', "ts"}, {'ч', "ch"}, {'ш', "sh"}, {'щ', "sch"}, {'ъ', ""},
                {'ы', "y"}, {'ь', ""}, {'э', "e"}, {'ю', "yu"}, {'я', "ya"}, {'А', "A"}, {'Б', "B"},
                {'В', "V"}, {'Г', "G"}, {'Д', "D"}, {'Е', "E"}, {'Ё', "Yo"}, {'Ж', "Zh"}, {'З', "Z"},
                {'И', "I"}, {'Й', "Y"}, {'К', "K"}, {'Л', "L"}, {'М', "M"}, {'Н', "N"}, {'О', "O"},
                {'П', "P"}, {'Р', "R"}, {'С', "S"}, {'Т', "T"}, {'У', "U"}, {'Ф', "F"}, {'Х', "H"},
                {'Ц', "Ts"}, {'Ч', "Ch"}, {'Ш', "Sh"}, {'Щ', "Sch"}, {'Ъ', ""}, {'Ы', "Y"}, {'Ь', ""},
                {'Э', "E"}, {'Ю', "Yu"}, {'Я', "Ya"}
            };

            StringBuilder builder = new StringBuilder();
            foreach (char c in text)
            {
                if (dictionary.ContainsKey(c))
                {
                    builder.Append(dictionary[c]);
                }
                else
                {
                    builder.Append(c);
                }
            }
            return builder.ToString();
        }
        private void AddDate(string fullDate)
        {
            DateTime date = DateTime.ParseExact(fullDate, "yyyy-MM-dd", CultureInfo.InvariantCulture);
            _date = new List<string>();
            _date.Add(date.Day.ToString("D2"));
            _date.Add(date.ToString("MMM", CultureInfo.InvariantCulture).ToUpper());
            _date.Add(date.Year.ToString());
        }
        private string TranslateEn(string text)
        {
            Translator translator = new Translator();
            string translatedText = translator.TranslateText(text);

            return translatedText.ToUpper();
        }


    }
}