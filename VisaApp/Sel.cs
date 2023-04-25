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

        public void Setup()
        {
            Driver = new ChromeDriver();
            Driver.Navigate().GoToUrl("https://ceac.state.gov/GenNIV/Default.aspx");
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(20);
            Driver.Manage().Timeouts().AsynchronousJavaScript = TimeSpan.FromSeconds(10);
        }

        private void Capcha()
        {
            Setup();

            Select(VisaApp.Capcha.selectLocation, "INDONESIA, JAKARTA");
            string result = Microsoft.VisualBasic.Interaction.InputBox("Введите текст:", "Запрос текста", "");
            SendKeys(VisaApp.Capcha.fieldCapcha, result);
        }

        public MyData CreateUser()
        {
            Capcha();
            Click(VisaApp.Capcha.btnStartApplication);

            Click(VisaApp.CreateUser.checkBoxAgree);
            GetText(VisaApp.CreateUser.labelTourID);

            SendKeys(VisaApp.CreateUser.fieldSecretPassword, _password);
            Click(VisaApp.CreateUser.btnContinue);

            return _survey;
        }

        public void ContinueChangeUser()
        {
            Capcha();
            Click(VisaApp.Capcha.btnContinueApplication);
            SendKeys(ContinueUser.fieldId, _survey.unique_id);
            Click(ContinueUser.btnContinueChange);
            SendKeysTranslite(ContinueUser.fieldFiveLetName, _survey.full_name.surnname);
            SendKeys(ContinueUser.fieldYearOfBirth, _survey.birth_date);
            SendKeys(ContinueUser.fieldMnM, _password);
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
            SendKeysTranslite(Personal1.fieldSurname, _survey.full_name.surnname);
            SendKeysTranslite(Personal1.fieldName, _survey.full_name.name);
            SendKeysOriginal(Personal1.fieldFullName,
                $"{_survey.full_name.surnname} {_survey.full_name.name} {_survey.full_name.fathername}");
            if (_survey.second_name != null)
            {
                Click(Personal1.checkBoxOtherNameYes);
                SendKeysTranslite(Personal1.fieldOtherSurname, _survey.second_name);
                SendKeysTranslite(Personal1.fieldOtherName, _survey.full_name.name);
            }
            else
            {
                Click(Personal1.checkBoxOtherNameNo);
            }

            Click(Personal1.checkBoxTeleCode);

            Select(Personal1.selectBoxSex, _survey.sex);
            Select(Personal1.selectMaritalStatus, _survey.marital_status);
            AddDate(_survey.birth_date);
            Select(Personal1.selectBirthDateDay, _date[0]);
            Select(Personal1.selectBirthDateMonth, _date[1]);
            SendKeys(Personal1.fieldBirthDateYear, _date[2]);
            SendKeys(Personal1.fieldBirthCity, _survey.birth_sity);
            Click(Personal1.checkBoxRegionNotApply);
            Select(Personal1.selectBirthCountry, TranslateEn(_survey.birth_country));
            SavePage();
        }

        public void PersonalTwo()
        {
            Select(Personal2.selectNationality, _survey.sitizenship.sitizenship);
            if (!_survey.sitizenship.second_sitizenship)
            {
                Click(Personal2.checkHaveAnyNationalityNo);
            }
            else
            {
                Click(Personal2.checkHaveAnyNationalityYes);
                Select(Personal2.selectOtherCountryNation, _survey.sitizenship.second_country);
                if (!_survey.sitizenship.second_passport_availability)
                {
                    Click(Personal2.checkOtherPassportNo);
                }
                else
                {
                    Click(Personal2.checkOtherPassportYes);
                    SendKeys(Personal2.fieldOtherPassportNumber, _survey.sitizenship.number_second_passport);
                }
            }

            if (!_survey.sitizenship.permanent_resident)
            {
                Click(Personal2.checkPermanentResidentNo);
            }
            else
            {
                Click(Personal2.checkPermanentResidentYes);
                Select(Personal2.selectOtherPermanentCountry, _survey.sitizenship.second_sitizen_country);
            }

            if (_survey.stay_in_usa.national_identification_number != null)
            {
                SendKeys(Personal2.fieldNationalIdentificationNumber,
                    _survey.stay_in_usa.national_identification_number);
            }
            else
            {
                Click(Personal2.checkNationalIdentificationNumber);
            }

            if (_survey.stay_in_usa.national_identification_number != null)
            {
                SendKeys(Personal2.fieldSocialNumberOne, _survey.stay_in_usa.social_security_number.Substring(0, 3));
                SendKeys(Personal2.fieldSocialNumberTwo, _survey.stay_in_usa.social_security_number.Substring(3, 2));
                SendKeys(Personal2.fieldSocialNumberThree, _survey.stay_in_usa.social_security_number.Substring(5, 4));
            }
            else
            {
                Click(Personal2.checkSocialNumber);
            }

            if (_survey.stay_in_usa.taxpayer_number != null)
            {
                SendKeys(Personal2.fieldTaxpayerId, _survey.stay_in_usa.taxpayer_number);
            }
            else
            {
                Click(Personal2.checkTaxpayerId);
            }

            SavePage();
        }

        public void TravelInfornation()
        {
            Select(Travel.selectVisaTypeChar, _survey.info_about_travel.visa_char);
            Select(Travel.selectVisaType, _survey.info_about_travel.visa_type);
            Click(Travel.checkHaveTravelPlansYes);
            AddDate(_survey.info_about_travel.arrival_date, Travel.selectDateArrivalDay, Travel.selectDateArrivalMonht,
                Travel.fieldDateArrivalYear);
            SendKeys(Travel.fieldArrivalCity, TranslateEn(_survey.info_about_travel.arrival_city));
            AddDate(_survey.info_about_travel.departure_date, Travel.selectDateDepartureDay,
                Travel.selectDateDepartureMonht, Travel.fieldDateDepartureYear);
            SendKeys(Travel.fieldDepartureCity, TranslateEn(_survey.info_about_travel.departure_city));
            AddAndFillFields(_survey.info_about_travel.travel_places, Travel.btnAddLocationTravel,
                Travel.fieldAddLocationTravel);
            SendKeys(Travel.fieldWillStayStreet1, TranslateEn(_survey.info_about_travel.stop_address.street));
            SendKeys(Travel.fieldWillStayCity, TranslateEn(_survey.info_about_travel.stop_address.city));
            Select(Travel.selectWillStayState, TranslateEn(_survey.info_about_travel.stop_address.region));
            SendKeys(Travel.fieldWillStayIndex, _survey.info_about_travel.stop_address.index);
            Select(Travel.selectPayerPerson, _survey.info_about_travel.payer);
            SavePage();
        }

        public void TravelCompanionsInformation()
        {
            Thread.Sleep(500);
                Driver.Navigate().GoToUrl("https://ceac.state.gov/GenNIV/General/complete/complete_travelcompanions.aspx?node=TravelCompanions");
            if (_survey.companions != null)
            {
                Click(Companions.checkHaveCompanionYes);
                if (_survey.info_about_travel.have_group)
                {
                    Click(Companions.checkHaveOrganizationYes);
                    SendKeys(Companions.fieldGroupName, _survey.info_about_travel.group_name);
                }
                else
                {
                    Click(Companions.checkHaveOrganizationNo);
                    AddAndFillCompanions(_survey.companions, Companions.btnAddCompanion,
                        Companions.fieldSurnameCompanion, Companions.fieldNameCompanion, Companions.selectRelationShip);
                }
            }
            else
            {
                Click(Companions.checkHaveCompanionNo);
            }

            SavePage();
        }

        public void AddPrevious()
        {
            Thread.Sleep(500);
            Driver.Navigate().GoToUrl("https://ceac.state.gov/GenNIV/General/complete/complete_previousustravel.aspx?node=PreviousUSTravel");
            //юывали ли бы в США
            if (CheckBox(_survey.have_been_to_USA, Previous.checkHaveBeenUSAYes, Previous.checkHaveBeenUSANo))
            {
                AddDate(_survey.date_arrival, Previous.selectDateArrivedDay, Previous.selectDateArrivedMonth,
                    Previous.fieldDateArrivedYear);
                SendKeys(Previous.fieldLengthOfStay, _survey.time_arrival);
                Select(Previous.selectUnit, _survey.unit_arrival);
                //Получали ли вы водительские права в США
                if (CheckBox(_survey.have_driver_doc, Previous.checkHaveDriverLicenseYes,
                        Previous.checkHaveDriverLicenseNo))
                {
                    if (_survey.driver_doc_number != null)
                    {
                        SendKeys(Previous.fieldDriverLicenseNumber, _survey.driver_doc_number);
                    }
                    else
                    {
                        Click(Previous.checkDoNotKnowDriver);
                    }

                    Select(Previous.selectDriverLicenseState, TranslateEn(_survey.driver_doc_state));
                }
            }

            //Получали ли вы визу ранее
            if (CheckBox(_survey.have_visa_before, Previous.checkHaveEvenIssuedUSYes, Previous.checkHaveEvenIssuedUSNo))
            {
                AddDate(_survey.date_issue_visa, Previous.selectDateIssueDay, Previous.selectDateIssueMonth,
                    Previous.fieldDateIssueYear);
                if (_survey.visa_number != null)
                {
                    SendKeys(Previous.fieldVisaNumber, _survey.visa_number);
                }
                else
                {
                    Click(Previous.checkDoNotKnow);
                }

                CheckBox(_survey.same_type_visa, Previous.checkVisaIsSameYes, Previous.checkVisaIsSameNo);
                CheckBox(_survey.same_country, Previous.checkCountryIsSameYes, Previous.checkCountryIsSameNo);
                CheckBox(_survey.fingers_prints, Previous.checkHaveTenPrintedYes, Previous.checkHaveTenPrintedNo);
                if (CheckBox(_survey.loss_visa, Previous.checkLostVisaYes, Previous.checkLostVisaNo))
                {
                    SendKeys(Previous.fieldLostYear, _survey.year_loss_visa);
                    SendKeys(Previous.fieldExplain, _survey.loss_explain);
                }

                if (CheckBox(_survey.cancelled_visa, Previous.checkCanceledVisaYes, Previous.checkCanceledVisaNo))
                {
                    SendKeys(Previous.fieldCancelExplain, _survey.cancel_explain);
                }
            }

            if (CheckBox(_survey.rejection_visa, Previous.checkRefusedVisaYes, Previous.checkRefusedVisaNo))
            {
                SendKeys(Previous.fieldRefusedExplain, _survey.rejection_reason);
            }

            if (CheckBox(_survey.greencard, Previous.checkTryImmigrantYes, Previous.checkTryImmigrantNo))
            {
                SendKeys(Previous.fieldImmigrantExplain, _survey.imigration_explain);
            }

            SavePage();
        }

        public void AddressAndPhone()
        {
            Thread.Sleep(500);
            Driver.Navigate()
                .GoToUrl("https://ceac.state.gov/GenNIV/General/complete/complete_contact.aspx?node=AddressPhone");
            FillLinesAddress(_survey.address.street, Address.fieldHomeStreet, Address.fieldHomeStreet2);
            SendKeys(Address.fieldHomeCity, _survey.address.city);
            DoesNotApply(_survey.address.region, Address.fieldHomeState, Address.checkHomeStateNotApply);
            DoesNotApply(_survey.address.index, Address.fieldHomeZip, Address.checkHomeZipNotApply);
            Select(Address.selectHomeCountry, TranslateEn(_survey.address.country));
            if (CheckBox((_survey.real_address != null), Address.checkMailAddressNo, Address.checkMailAddressYes))
            {
                FillLinesAddress(_survey.real_address.street, Address.fieldMailStreet, Address.fieldMailStreet2);
                SendKeys(Address.fieldMailCity, _survey.real_address.city);
                DoesNotApply(_survey.real_address.region, Address.fieldMailState, Address.checkMailStateNotApply);
                DoesNotApply(_survey.real_address.index, Address.fieldMailZip, Address.checkMailZipNotApply);
                Select(Address.selectMailCountry, TranslateEn(_survey.real_address.country));
            }

            SendKeys(Address.fieldPrimaryPhone, _survey.personal_number);
            DoesNotApply(_survey.additive_number, Address.fieldSecondaryPhone, Address.checkSecondaryNotApply);
            DoesNotApply(_survey.job_number, Address.fieldWorkPhone, Address.checkWorkNotApply);
            if (CheckBox((_survey.numbers_of_fives_years != null), Address.checkHaveAnotherNumbersYes,
                    Address.checkHaveAnotherNumbersNo))
            {
                AddAndFillFields(_survey.numbers_of_fives_years, Address.btnAddPhone, Address.fieldAdditionalPhone);
            }

            SendKeysOriginal(Address.fieldEmail, _survey.email);
            if (CheckBox((_survey.email_adresses != null), Address.checkHaveAnotherEmailYes,
                    Address.checkHaveAnotherEmailNo))
            {
                AddAndFillFields(_survey.email_adresses, Address.btnAddEmail, Address.fieldAdditionalEmail);
            }

            for (int i = 0; i < _survey.public_links.Count - 1; i++)
            {
                Click(By.Id($"ctl00_SiteContentPlaceHolder_FormView1_dtlSocial_ctl0{i}_InsertButtonSOCIAL_MEDIA_INFO"));
                Thread.Sleep(1000);
            }

            for (int i = 0; i < _survey.public_links.Count; i++)
            {
                Select(By.Id($"ctl00_SiteContentPlaceHolder_FormView1_dtlSocial_ctl0{i}_ddlSocialMedia"),
                    _survey.public_links[i].linl_soc_web);
                SendKeysOriginal(By.Id($"ctl00_SiteContentPlaceHolder_FormView1_dtlSocial_ctl0{i}_tbxSocialMediaIdent"),
                    _survey.public_links[i].link_to_account);
            }

            Click(Address.checkHaveAnotherSWNo);
            SavePage();
        }

        public void AddPassport()
        {
            Thread.Sleep(500);
            Driver.Navigate()
                .GoToUrl("https://ceac.state.gov/GenNIV/General/complete/Passport_Visa_Info.aspx?node=PptVisa");
            Select(Passport.selectPassportType, _survey.passport.passport_type);


            Click(Passport.checkNotApply);

            Select(Passport.selectPassportCountry, TranslateEn(_survey.passport.country));
            SendKeys(Passport.fieldPassportCity, _survey.passport.city);
            SendKeys(Passport.fieldPassportState, _survey.passport.region);
            Select(Passport.selectPassportIssueCountry, TranslateEn(_survey.passport.country));
            AddDate(_survey.passport.issuedate, Passport.selectIssuanceDay, Passport.selectIssuanceMonth,
                Passport.fieldIssuanceYear);
            AddDate(_survey.passport.endDate, Passport.selectExpirationDay, Passport.selectExpirationMonth,
                Passport.fieldExpirationYear);
            if (CheckBox(_survey.passport.isLoss, Passport.checkLostPassportYes, Passport.checkLostPassportNo))
            {
                if (_survey.passport.loss_passport_number != null)
                {
                    SendKeys(Passport.fieldLostPassportNumber, _survey.passport.loss_passport_number);
                }
                else
                {
                    Click(Passport.checkDontKnow);
                }

                Select(Passport.selectLostPassportCountry, TranslateEn(_survey.passport.loss_passport_country));
                SendKeys(Passport.fieldExplain, _survey.passport.loss_passport_explain);
            }

            SendKeysTranslite(Passport.fieldPassportNumber, _survey.passport.number);
            SavePage();
        }

        public void USContact()
        {
            Thread.Sleep(500);
            Driver.Navigate()
                .GoToUrl("https://ceac.state.gov/GenNIV/General/complete/complete_uscontact.aspx?node=USContact");
            SendKeys(USContactInformation.fieldContactPersonSurname, _survey.inviter.surname);
            DoesNotApply(_survey.inviter.name, USContactInformation.fieldContactPersonName,
                USContactInformation.checkDontRnowName);
            DoesNotApply(_survey.inviter.company_name, USContactInformation.fieldOrganizationName,
                USContactInformation.checkDontKnowOrganization);
            Select(USContactInformation.selectRelationship, _survey.inviter.relationship);
            FillLinesAddress(_survey.inviter.address.street, USContactInformation.fieldStreet1,
                USContactInformation.fieldStreet2);
            SendKeys(USContactInformation.fieldCity, _survey.inviter.address.city);
            Select(USContactInformation.selectState, TranslateEn(_survey.inviter.address.region));
            if (_survey.inviter.address.index != null)
            {
                SendKeys(USContactInformation.fieldZip, _survey.inviter.address.index);
            }

            SendKeys(USContactInformation.fieldPhone, _survey.inviter.number);
            DoesNotApply(_survey.inviter.email, USContactInformation.fieldEmail, USContactInformation.checkNotApply);
            SavePage();
        }

        public void Family()
        {
            Thread.Sleep(500);
            Driver.Navigate()
                .GoToUrl("https://ceac.state.gov/GenNIV/General/complete/complete_family1.aspx?node=Relatives");
            DoesNotApply(_survey.father.surname, FamilyInfo.fieldFatherSurname, FamilyInfo.checkFatherSurmaneDontKnow);
            DoesNotApply(_survey.father.name, FamilyInfo.fieldFatherName, FamilyInfo.checkFatherNaneDontKnow);
            if (_survey.father.birth_date != null)
            {
                AddDate(_survey.father.birth_date, FamilyInfo.selectFatherDay, FamilyInfo.selectFatherMonth,
                    FamilyInfo.fieldFatherYear);
            }
            else
            {
                Click(FamilyInfo.checkFatherBirthDayDontKnow);
            }

            if (CheckBox(_survey.father.is_sitizen_usa, FamilyInfo.checkFatherInUSYes, FamilyInfo.checkFatherInUSNo))
            {
                Select(FamilyInfo.selectFatherStatus, _survey.father.usa_status);
            }

            DoesNotApply(_survey.mother.surname, FamilyInfo.fieldMotherSurname, FamilyInfo.checkMotherSurmaneDontKnow);
            DoesNotApply(_survey.mother.name, FamilyInfo.fieldMotherName, FamilyInfo.checkMotherNaneDontKnow);
            if (_survey.mother.birth_date != null)
            {
                AddDate(_survey.mother.birth_date, FamilyInfo.selectMotherDay, FamilyInfo.selectMotherMonth,
                    FamilyInfo.fieldMotherYear);
            }
            else
            {
                Click(FamilyInfo.checkMotherBirthDayDontKnow);
            }

            if (CheckBox(_survey.mother.is_sitizen_usa, FamilyInfo.checkMotherInUSYes, FamilyInfo.checkMotherInUSNo))
            {
                Select(FamilyInfo.selectMotherStatus, _survey.mother.usa_status);
            }

            Click(FamilyInfo.checkNo);
            Click(FamilyInfo.checkRelativeNo);
            SavePage();
        }

        public void AddSpouse()
        {
            Thread.Sleep(500);
            Driver.Navigate()
                .GoToUrl("https://ceac.state.gov/GenNIV/General/complete/complete_family2.aspx?node=Spouse");
            SendKeysTranslite(Spose.fieldSurname, _survey.spouse.surname);
            SendKeysTranslite(Spose.fieldName, _survey.spouse.name);
            AddDate(_survey.spouse.birth_date, Spose.selectBirthDay, Spose.selectBirthMonth, Spose.fieldBirthYear);
            Select(Spose.selectNationality, TranslateEn(_survey.spouse.birth_country));
            DoesNotApply(_survey.spouse.birht_city, Spose.fieldCity, Spose.checkCityDontKnow);
            Select(Spose.selectCountry, TranslateEn(_survey.spouse.birth_country));
            Select(Spose.selectAdress, _survey.spouse.address);
            SavePage();
        }

        public void AdditionalWork()
        {
            Thread.Sleep(500);
            Driver.Navigate()
                .GoToUrl("https://ceac.state.gov/GenNIV/General/complete/complete_family2.aspx?node=Spouse");
            Click(Personal1.btnPersonalZeroNext);
            Select(Additional.selectOccupation, _survey.job[0].kind_of_activity);
            SendKeys(Additional.fieldCompanyName, _survey.job[0].company_name);
            FillLinesAddress(_survey.job[0].address.street, Additional.fieldStreet1, Additional.fieldStreet2);
            SendKeys(Additional.fieldCity, _survey.job[0].address.city);
            DoesNotApply(_survey.job[0].address.region, Additional.fieldState, Additional.checkStateNotApply);
            DoesNotApply(_survey.job[0].address.index, Additional.fieldZip, Additional.checkZipNotApply);
            SendKeys(Additional.fieldPhone, _survey.job[0].job_number);
            Select(Additional.selectCountry, TranslateEn(_survey.job[0].address.country));
            AddDate(_survey.job[0].start_date, Additional.selectStartDay, Additional.selectStartMonth,
                Additional.fieldStartYear);
            DoesNotApply(_survey.job[0].wages, Additional.fieldWages, Additional.checkWagesNotApply);
            SendKeys(Additional.fieldSpec, _survey.job[0].spec);
            SavePage();
            AdditionalPrevious();
        }

        public void AdditionalPrevious()
        {
            try
            {

            
                Thread.Sleep(500);
                Driver.Navigate().GoToUrl("https://ceac.state.gov/GenNIV/General/complete/complete_workeducation2.aspx?node=WorkEducation2");
                if (_survey.job.Count > 1)
                {
                    Click(PreviousWork.checkPreviousJobYes);
                    for (int i = 0; i < _survey.job.Count - 1; i++)
                    {
                        Click(StringBy(PreviousWork.btnAddJob, i));
                    }

                    for (int i = 0; i < _survey.job.Count; i++)
                    {
                        SendKeys(StringBy(PreviousWork.fieldCompanyName, i), _survey.job[i].company_name);
                        FillLinesAddress(_survey.job[i].address.street, StringBy(PreviousWork.fieldStreet1, i),
                            StringBy(PreviousWork.fieldStreet2, i));
                        SendKeys(StringBy(PreviousWork.fieldCity, i), _survey.job[i].address.city);
                        DoesNotApply(_survey.job[i].address.region, StringBy(PreviousWork.fieldState, i),
                            StringBy(PreviousWork.checkStateNotApply, i));
                        DoesNotApply(_survey.job[i].address.index, StringBy(PreviousWork.fieldZip, i),
                            StringBy(PreviousWork.checkZipNotApply, i));
                        Select(StringBy(PreviousWork.selectCountry, i), TranslateEn(_survey.job[i].address.country));
                        SendKeys(StringBy(PreviousWork.fieldPhone, i), _survey.job[i].job_number);
                        SendKeys(StringBy(PreviousWork.fieldJobTitle, i), _survey.job[i].title);
                        DoesNotApply(_survey.job[i].supervizor_surname, StringBy(PreviousWork.fieldSupervizorSurname, i),
                            StringBy(PreviousWork.checkSurnameSupervizorSurnameDontKnow, i));
                        DoesNotApply(_survey.job[i].supervizor_name, StringBy(PreviousWork.fieldSupervizorName, i),
                            StringBy(PreviousWork.checkSurnameSupervizorNameDontKnow, i));
                        AddDate(_survey.job[i].start_date, StringBy(PreviousWork.selectStartDay, i),
                            StringBy(PreviousWork.selectStartMonth, i), StringBy(PreviousWork.fieldStartYear, i));
                        AddDate(_survey.job[i].end_date, StringBy(PreviousWork.selectEndDay, i),
                            StringBy(PreviousWork.selectEndMonth, i), StringBy(PreviousWork.fieldEndYear, i));
                        SendKeys(StringBy(PreviousWork.fieldSpec, i), _survey.job[i].spec);
                    }
                }
                else
                {
                    Click(PreviousWork.checkPreviousJobNo);
                }

                AdditionalPreviousStudy();
                SavePage();
                TrainingInfornation();
            }
            catch (Exception e)
            {
                AdditionalPrevious();
            }
        }

        private void AdditionalPreviousStudy()
        {
            if (_survey.study.Count >= 1)
            {
                Click(PreviousStudy.checkPreviousStudyYes);
                for (int i = 0; i < _survey.study.Count - 1; i++)
                {
                    Click(StringBy(PreviousStudy.btnAddStudy, i));
                }

                for (int i = 0; i < _survey.study.Count; i++)
                {
                    SendKeys(StringBy(PreviousStudy.fieldCompanyName, i), _survey.study[i].company_name);
                    FillLinesAddress(_survey.study[i].address.street, StringBy(PreviousStudy.fieldStreet1, i),
                        StringBy(PreviousStudy.fieldStreet2, i));
                    SendKeys(StringBy(PreviousStudy.fieldCity, i), _survey.study[i].address.city);
                    DoesNotApply(_survey.study[i].address.region, StringBy(PreviousStudy.fieldState, i),
                        StringBy(PreviousStudy.checkStateNotApply, i));
                    DoesNotApply(_survey.study[i].address.index, StringBy(PreviousStudy.fieldZip, i),
                        StringBy(PreviousStudy.checkZipNotApply, i));
                    Select(StringBy(PreviousStudy.selectCountry, i), TranslateEn(_survey.study[i].address.country));
                    SendKeys(StringBy(PreviousStudy.fieldCourse, i), _survey.study[i].spec);

                    AddDate(_survey.study[i].start_date, StringBy(PreviousStudy.selectStartDay, i),
                        StringBy(PreviousStudy.selectStartMonth, i), StringBy(PreviousStudy.fieldStartYear, i));
                    AddDate(_survey.study[i].end_date, StringBy(PreviousStudy.selectEndDay, i),
                        StringBy(PreviousStudy.selectEndMonth, i), StringBy(PreviousStudy.fieldEndYear, i));
                }
            }
            else
            {
                Click(PreviousStudy.checkPreviousStudyNo);
            }
        }

        private void TrainingInfornation()
        {
            Click(TraningInfo.checkClanNo);

            AddAndFillFields(_survey.additive_info.languages, TraningInfo.btnAddLanguage, TraningInfo.fieldLanguage);
            if (CheckBox(_survey.additive_info.countrys.Count > 0, TraningInfo.checkCountryVisitYes,
                    TraningInfo.checkCountryVisitNo))
            {
                AddAndSelectFields(_survey.additive_info.countrys, TraningInfo.btnAddCountry,
                    TraningInfo.selectCountry);
            }

            if (CheckBox(_survey.additive_info.spec_org.Length > 0, TraningInfo.checkProfessionalOrganizationYes,
                    TraningInfo.checkProfessionalOrganizationNo))
            {
                SendKeys(TraningInfo.fieldProfessionalOrganizationName, _survey.additive_info.spec_org);
            }

            Click(TraningInfo.checkSpecialSkillNo);
            if (CheckBox(_survey.additive_info.have_army, TraningInfo.checkMilitaryYes, TraningInfo.checkMilitaryNo))
            {
                Select(TraningInfo.selectCountryArmy, _survey.additive_info.army.country);
                Thread.Sleep(500);
                SendKeys(TraningInfo.fieldBranch, _survey.additive_info.army.division);
                SendKeys(TraningInfo.fieldRank, _survey.additive_info.army.rang);
                SendKeys(TraningInfo.fieldSpeciality, _survey.additive_info.army.specialty);
                AddDate(_survey.additive_info.army.start_date, TraningInfo.fieldStartDay, TraningInfo.selectStartMonth,
                    TraningInfo.fieldStartYear);
                AddDate(_survey.additive_info.army.and_date, TraningInfo.selectEndDay, TraningInfo.selectEndMonth,
                    TraningInfo.fieldEndYear);
            }

            Click(TraningInfo.checkRebelNo);

            SavePage();
        }

        public void BackGroundAndSecury()
        {
            Thread.Sleep(500);
            Driver.Navigate().GoToUrl("https://ceac.state.gov/GenNIV/General/complete/complete_securityandbackground1.aspx?node=SecurityandBackground1");
            
            try
            {
                Click(OnlyNo.checkPublicHealthNo);
                Click(OnlyNo.checkDesorderNo);
                Click(OnlyNo.checkDruguserNo);
                SavePage();
            }
            catch (Exception e)
            {
                
            }

            try
            {
                Click(OnlyNo.checkArrestedNo);
                Click(OnlyNo.checkControlledSubstancedNo);
                Click(OnlyNo.checkProstitutionNo);
                Click(OnlyNo.checkMoneyLaunderingNo);
                Click(OnlyNo.checkHumanTraffickingNo);
                Click(OnlyNo.checkHumanTraffickingRelatedNo);
                Click(OnlyNo.checkServereTraffikingNo);
                SavePage();
            }
            catch{}

            try
            {
                Click(OnlyNo.checkIllegalNo);
                Click(OnlyNo.checkTerroristActivityNo);
                Click(OnlyNo.checkTerroristSupportNo);
                Click(OnlyNo.checkTerroristOrgNo);
                Click(OnlyNo.checkTerroristRelNo);
                Click(OnlyNo.checkGenocideNo);
                Click(OnlyNo.checkTortureNo);
                Click(OnlyNo.checkViolenceNo);
                Click(OnlyNo.checkChildSoldierNo);
                Click(OnlyNo.checkReligiousFreedomNo);
                Click(OnlyNo.checkPopulationControlNo);
                Click(OnlyNo.checkTransplantNo);
                SavePage();
            }
            catch{}

            try
            {
                Click(OnlyNo.checkRemovalHearingNo);
                Click(OnlyNo.checkImigrationFraudNo);
                Click(OnlyNo.checkFailToAttendNo);
                Click(OnlyNo.checkVisaViolationNo);
                Click(OnlyNo.checkDeportNo);
                SavePage();
            }
            catch{}

            try
            {
                Click(OnlyNo.checkChildCustodyNo);
                Click(OnlyNo.checkVoltingViolationNo);
                Click(OnlyNo.checkRenounceExpNo);
                Click(OnlyNo.checkAttWoReimb);
                MessageBox.Show("Анкета заполнена. Нажмите кнопку \"сохранить\" на странице");
            }
            catch
            {
                MessageBox.Show("Произошла ошибка");
            }

        }


        private By StringBy(string id, int n)
        {
            int firstOccurrence = id.IndexOf("100");
            if (firstOccurrence == -1)
            {
                // Если подстрока не найдена, возвращаем исходную строку
                return By.Id(id);
            }

            int secondOccurrence = id.IndexOf("100", firstOccurrence + 1);
            if (secondOccurrence == -1)
            {
                // Если второе вхождение подстроки не найдено, возвращаем исходную строку
                return By.Id(id);
            }

            string prefix = id.Substring(0, secondOccurrence);
            string suffix = id.Substring(secondOccurrence + "100".Length);

            // Преобразуем подстроку в число, прибавляем к нему "n" и преобразуем обратно в строку
            int number = Int32.Parse("100") + n;
            string result = prefix + number.ToString() + suffix;

            return By.Id(result);
        }


        private void SavePage()
        {
            Click(Personal1.btnPersonalZeroSave);
            SuccessSave();
            Click(Personal1.btnPersonalZeroNext);
        }

        public void DoesNotApply<T>(T value, By field, By check)
        {
            if (value != null)
            {
                SendKeys(field, value.ToString());
                return;
            }

            Click(check);
        }

        private void FillLinesAddress(string address, By line1, By line2)
        {
            if (address.Length > 100)
            {
                string firstHalf = address.Substring(0, 100);
                string secondHalf = address.Substring(100);
                SendKeys(line1, firstHalf);
                SendKeys(line2, secondHalf);
                return;
            }

            SendKeys(line1, address);
        }

        private void AddAndFillCompanions<T>(List<T> list, By button, By surname, By name, By relationship)
        {
            for (int i = 0; i < list.Count - 1; i++)
            {
                Driver.FindElements(button)[i].Click();
                Thread.Sleep(1000);
            }

            for (int i = 0; i < list.Count; i++)
            {
                string[] words = _survey.companions[i].name.Split(' ');
                Driver.FindElement(
                        By.Id($"ctl00_SiteContentPlaceHolder_FormView1_dlTravelCompanions_ctl0{i}_tbxSurname"))
                    .SendKeys(TranslateEn(words[0]));
                Driver.FindElement(
                        By.Id($"ctl00_SiteContentPlaceHolder_FormView1_dlTravelCompanions_ctl0{i}_tbxGivenName"))
                    .SendKeys(TranslateEn(words[1]));
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
            for (int i = 0; i < list.Count - 1; i++)
            {
                Driver.FindElements(button)[i].Click();
                Thread.Sleep(1000);
            }

            for (int i = 0; i < list.Count; i++)
            {
                Driver.FindElements(field)[i].SendKeys(list[i].ToString());
            }
        }

        private void AddAndFillFields<T>(List<T> list, string button, string id)
        {
            for (int i = 0; i < list.Count - 1; i++)
            {
                Driver.FindElement(StringBy(button, i)).Click();
                Thread.Sleep(1000);
            }

            for (int i = 0; i < list.Count; i++)
            {
                Driver.FindElement(
                        By.Id($"ctl00_SiteContentPlaceHolder_FormView1_dtlLANGUAGES_ctl0{i}_tbxLANGUAGE_NAME"))
                    .SendKeys(TranslateEn(list[i].ToString()));
            }
        }

        private void AddAndSelectFields<T>(List<T> list, string button, string select)
        {
            for (int i = 0; i < list.Count - 1; i++)
            {
                Driver.FindElement(StringBy(button, i)).Click();
                Thread.Sleep(1000);
            }

            for (int i = 0; i < list.Count; i++)
            {
                Select(
                    By.Id($"ctl00_SiteContentPlaceHolder_FormView1_dtlCountriesVisited_ctl0{i}_ddlCOUNTRIES_VISITED"),
                    TranslateEn(list[i].ToString()));
            }
        }

        //заполняем форму с датой
        private void AddDate(string fullDate, By day, By month, By year)
        {
            AddDate(fullDate);
            Select(day, _date[0]);
            Select(month, _date[1]);
            SendKeys(year, _date[2]);
        }

        //метод расставляет простые чекбоксы. Параметры: булевое поле из анкеты и чекбокс да или нет
        private bool CheckBox(bool answer, By yes, By no)
        {
            if (answer)
            {
                Click(yes);
                return true;
            }

            Click(no);
            return false;
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
            selectElement.SelectByText(TranslateEn(text));
        }

        private void Select(By select, int number)
        {
            IWebElement dropdown = Driver.FindElement(select);
            SelectElement selectElement = new SelectElement(dropdown);
            selectElement.SelectByIndex(number);
        }

        private void Select(By select, string text, int i)
        {
            IWebElement dropdown = Driver.FindElements(select)[i];
            SelectElement selectElement = new SelectElement(dropdown);
            selectElement.SelectByText(text);
        }


        private void SendKeys(By element, string text)
        {
            Driver.FindElement(element).Clear();
            Driver.FindElement(element).SendKeys(TranslateEn(text));
        }

        private void SendKeysTranslite(By element, string text)
        {
            Driver.FindElement(element).Clear();
            Driver.FindElement(element).SendKeys(Transliterate(text));
        }

        private void SendKeysOriginal(By element, string text)
        {
            Driver.FindElement(element).Clear();
            Driver.FindElement(element).SendKeys(text);
        }

        private string Transliterate(string text)
        {
            Dictionary<char, string> dictionary = new Dictionary<char, string>
            {
                { 'а', "a" }, { 'б', "b" }, { 'в', "v" }, { 'г', "g" }, { 'д', "d" }, { 'е', "e" }, { 'ё', "yo" },
                { 'ж', "zh" }, { 'з', "z" }, { 'и', "i" }, { 'й', "y" }, { 'к', "k" }, { 'л', "l" }, { 'м', "m" },
                { 'н', "n" }, { 'о', "o" }, { 'п', "p" }, { 'р', "r" }, { 'с', "s" }, { 'т', "t" }, { 'у', "u" },
                { 'ф', "f" }, { 'х', "h" }, { 'ц', "ts" }, { 'ч', "ch" }, { 'ш', "sh" }, { 'щ', "sch" }, { 'ъ', "" },
                { 'ы', "y" }, { 'ь', "" }, { 'э', "e" }, { 'ю', "yu" }, { 'я', "ya" }, { 'А', "A" }, { 'Б', "B" },
                { 'В', "V" }, { 'Г', "G" }, { 'Д', "D" }, { 'Е', "E" }, { 'Ё', "Yo" }, { 'Ж', "Zh" }, { 'З', "Z" },
                { 'И', "I" }, { 'Й', "Y" }, { 'К', "K" }, { 'Л', "L" }, { 'М', "M" }, { 'Н', "N" }, { 'О', "O" },
                { 'П', "P" }, { 'Р', "R" }, { 'С', "S" }, { 'Т', "T" }, { 'У', "U" }, { 'Ф', "F" }, { 'Х', "H" },
                { 'Ц', "Ts" }, { 'Ч', "Ch" }, { 'Ш', "Sh" }, { 'Щ', "Sch" }, { 'Ъ', "" }, { 'Ы', "Y" }, { 'Ь', "" },
                { 'Э', "E" }, { 'Ю', "Yu" }, { 'Я', "Ya" }
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