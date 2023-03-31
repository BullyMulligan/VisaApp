
using OpenQA.Selenium;

namespace VisaApp
{
    public static class Capcha
    {
        //Страница капчи
        public static By selectLocation = By.Id("ctl00_SiteContentPlaceHolder_ucLocation_ddlLocation");
        public static By fieldCapcha = By.Id("ctl00_SiteContentPlaceHolder_ucLocation_IdentifyCaptcha1_txtCodeTextBox");
        public static By btnStartApplication = By.Id("ctl00_SiteContentPlaceHolder_newApplication");
        public static By btnContinueApplication = By.Id("ctl00_SiteContentPlaceHolder_lnkRetrieve");
    }
    public static class CreateUser
    {
        //страница создания Юзера
        public static By checkBoxAgree = By.Id("ctl00_SiteContentPlaceHolder_chkbxPrivacyAct");
        public static By labelTourID = By.Id("ctl00_SiteContentPlaceHolder_lblBarcode");
        public static By fieldSecretPassword = By.Id("ctl00_SiteContentPlaceHolder_txtAnswer");
        public static By btnContinue = By.Id("ctl00_SiteContentPlaceHolder_btnContinue");
    }
    public static class ContinueUser
    {
        //страница продолжения заполнения юзера
        public static By fieldId = By.Id("ctl00_SiteContentPlaceHolder_ApplicationRecovery1_tbxApplicationID");
        public static By btnContinueChange = By.Id("ctl00_SiteContentPlaceHolder_ApplicationRecovery1_btnBarcodeSubmit");
        public static By fieldFiveLetName = By.Id("ctl00_SiteContentPlaceHolder_ApplicationRecovery1_txbSurname");
        public static By fieldYearOfBirth = By.Id("ctl00_SiteContentPlaceHolder_ApplicationRecovery1_txbDOBYear");
        public static By fieldMnM = By.Id("ctl00_SiteContentPlaceHolder_ApplicationRecovery1_txbAnswer");
        public static By btnContinueChangeAgain =By.Id("ctl00_SiteContentPlaceHolder_ApplicationRecovery1_btnRetrieve");
    }
    public static class SavePage
    {
        //Страницы оповещения о сохранении
        public static By btnSuccessSave = By.Id("ctl00_btnContinueApp");
    }
    public static class Personal1
    {
        //страница Personal1
        public static By fieldSurname = By.Id("ctl00_SiteContentPlaceHolder_FormView1_tbxAPP_SURNAME");
        public static By fieldName = By.Id("ctl00_SiteContentPlaceHolder_FormView1_tbxAPP_GIVEN_NAME");
        public static By fieldFullName = By.Id("ctl00_SiteContentPlaceHolder_FormView1_tbxAPP_FULL_NAME_NATIVE");
        public static By checkBoxOtherNameYes = By.Id("ctl00_SiteContentPlaceHolder_FormView1_rblOtherNames_0");
        public static By checkBoxOtherNameNo = By.Id("ctl00_SiteContentPlaceHolder_FormView1_rblOtherNames_1");
        public static By fieldOtherSurname = By.Id("ctl00_SiteContentPlaceHolder_FormView1_DListAlias_ctl00_tbxSURNAME");
        public static By fieldOtherName = By.Id("ctl00_SiteContentPlaceHolder_FormView1_DListAlias_ctl00_tbxGIVEN_NAME");
        public static By checkBoxTeleCode = By.Id("ctl00_SiteContentPlaceHolder_FormView1_rblTelecodeQuestion_1");
        public static By selectBoxSex = By.Id("ctl00_SiteContentPlaceHolder_FormView1_ddlAPP_GENDER");
        public static By selectMaritalStatus = By.Id("ctl00_SiteContentPlaceHolder_FormView1_ddlAPP_MARITAL_STATUS");
        public static By selectBirthDateDay = By.Id("ctl00_SiteContentPlaceHolder_FormView1_ddlDOBDay");
        public static By selectBirthDateMonth = By.Id("ctl00_SiteContentPlaceHolder_FormView1_ddlDOBMonth");
        public static By fieldBirthDateYear = By.Id("ctl00_SiteContentPlaceHolder_FormView1_tbxDOBYear");
        public static By fieldBirthCity = By.Id("ctl00_SiteContentPlaceHolder_FormView1_tbxAPP_POB_CITY");
        public static By checkBoxRegionNotApply = By.Id("ctl00_SiteContentPlaceHolder_FormView1_cbexAPP_POB_ST_PROVINCE_NA");
        public static By selectBirthCountry = By.Id("ctl00_SiteContentPlaceHolder_FormView1_ddlAPP_POB_CNTRY");
        public static By btnPersonalZeroSave = By.Id("ctl00_SiteContentPlaceHolder_UpdateButton2");
        public static By btnPersonalZeroNext = By.Id("ctl00_SiteContentPlaceHolder_UpdateButton3");
    }
    public static class Personal2
    {
        //Personal2
        public static By selectNationality = By.Id("ctl00_SiteContentPlaceHolder_FormView1_ddlAPP_NATL");
        public static By checkHaveAnyNationalityYes = By.Id("ctl00_SiteContentPlaceHolder_FormView1_rblAPP_OTH_NATL_IND_0");
        public static By checkHaveAnyNationalityNo = By.Id("ctl00_SiteContentPlaceHolder_FormView1_rblAPP_OTH_NATL_IND_1");
        
        public static By selectOtherCountryNation = By.Id("ctl00_SiteContentPlaceHolder_FormView1_dtlOTHER_NATL_ctl00_ddlOTHER_NATL");
        public static By checkOtherPassportYes = By.Id("ctl00_SiteContentPlaceHolder_FormView1_dtlOTHER_NATL_ctl00_rblOTHER_PPT_IND_0");
        public static By checkOtherPassportNo = By.Id("ctl00_SiteContentPlaceHolder_FormView1_dtlOTHER_NATL_ctl00_rblOTHER_PPT_IND_1");
        public static By fieldOtherPassportNumber = By.Id("ctl00_SiteContentPlaceHolder_FormView1_dtlOTHER_NATL_ctl00_tbxOTHER_PPT_NUM");

        public static By checkPermanentResidentYes = By.Id("ctl00_SiteContentPlaceHolder_FormView1_rblPermResOtherCntryInd_0");
        public static By checkPermanentResidentNo = By.Id("ctl00_SiteContentPlaceHolder_FormView1_rblPermResOtherCntryInd_1");
        
        public static By selectOtherPermanentCountry = By.Id("ctl00_SiteContentPlaceHolder_FormView1_dtlOthPermResCntry_ctl00_ddlOthPermResCntry");
        
        public static By fieldNationalIdentificationNumber = By.Id("ctl00_SiteContentPlaceHolder_FormView1_tbxAPP_NATIONAL_ID");
        public static By checkNationalIdentificationNumber = By.Id("ctl00_SiteContentPlaceHolder_FormView1_cbexAPP_NATIONAL_ID_NA");
        public static By fieldSocialNumberOne = By.Id("ctl00_SiteContentPlaceHolder_FormView1_tbxAPP_SSN1");
        public static By fieldSocialNumberTwo = By.Id("ctl00_SiteContentPlaceHolder_FormView1_tbxAPP_SSN2");
        public static By fieldSocialNumberThree = By.Id("ctl00_SiteContentPlaceHolder_FormView1_tbxAPP_SSN3");
        public static By checkSocialNumber = By.Id("ctl00_SiteContentPlaceHolder_FormView1_cbexAPP_SSN_NA");
        public static By fieldTaxpayerId = By.Id("ctl00_SiteContentPlaceHolder_FormView1_tbxAPP_TAX_ID");
        public static By checkTaxpayerId = By.Id("ctl00_SiteContentPlaceHolder_FormView1_cbexAPP_TAX_ID_NA");

    }
    public static class Travel
    {
        //Travel
        public static By selectVisaTypeChar = By.Id("ctl00_SiteContentPlaceHolder_FormView1_dlPrincipalAppTravel_ctl00_ddlPurposeOfTrip");
        public static By selectVisaType = By.Id("ctl00_SiteContentPlaceHolder_FormView1_dlPrincipalAppTravel_ctl00_ddlOtherPurpose");
        
        public static By checkHaveTravelPlansYes = By.Id("ctl00_SiteContentPlaceHolder_FormView1_rblSpecificTravel_0");
        
        public static By selectDateArrivalDay = By.Id("ctl00_SiteContentPlaceHolder_FormView1_ddlARRIVAL_US_DTEDay");
        public static By selectDateArrivalMonht = By.Id("ctl00_SiteContentPlaceHolder_FormView1_ddlARRIVAL_US_DTEMonth");
        public static By fieldDateArrivalYear = By.Id("ctl00_SiteContentPlaceHolder_FormView1_tbxARRIVAL_US_DTEYear");
        public static By fieldArrivalCity = By.Id("ctl00_SiteContentPlaceHolder_FormView1_tbxArriveCity");
        
        public static By selectDateDepartureDay = By.Id("ctl00_SiteContentPlaceHolder_FormView1_ddlDEPARTURE_US_DTEDay");
        public static By selectDateDepartureMonht = By.Id("ctl00_SiteContentPlaceHolder_FormView1_ddlDEPARTURE_US_DTEMonth");
        public static By fieldDateDepartureYear = By.Id("ctl00_SiteContentPlaceHolder_FormView1_tbxDEPARTURE_US_DTEYear");
        public static By fieldDepartureCity = By.Id("ctl00_SiteContentPlaceHolder_FormView1_tbxDepartCity");
        
        public static By fieldLocation = By.Id("ctl00_SiteContentPlaceHolder_FormView1_dtlTravelLoc_ctl00_tbxSPECTRAVEL_LOCATION");
        
        public static By btnAddLocationTravel = By.XPath("//div[@class='field full']//a[text()='Add Another']");
        public static By fieldAddLocationTravel = By.XPath("//table[@id='ctl00_SiteContentPlaceHolder_FormView1_dtlTravelLoc']//input");

        public static By fieldWillStayStreet1 = By.Id("ctl00_SiteContentPlaceHolder_FormView1_tbxStreetAddress1");
        public static By fieldWillStayStreet2 = By.Id("ctl00_SiteContentPlaceHolder_FormView1_tbxStreetAddress2");
        public static By fieldWillStayCity = By.Id("ctl00_SiteContentPlaceHolder_FormView1_tbxCity");
        public static By selectWillStayState = By.Id("ctl00_SiteContentPlaceHolder_FormView1_ddlTravelState");
        public static By fieldWillStayIndex = By.Id("ctl00_SiteContentPlaceHolder_FormView1_tbZIPCode");
        public static By selectPayerPerson = By.Id("ctl00_SiteContentPlaceHolder_FormView1_ddlWhoIsPaying");

    }
    public static class Companions
    {
        //Travel Companions
        public static By checkHaveCompanionYes = By.Id("ctl00_SiteContentPlaceHolder_FormView1_rblOtherPersonsTravelingWithYou_0");
        public static By checkHaveCompanionNo = By.Id("ctl00_SiteContentPlaceHolder_FormView1_rblOtherPersonsTravelingWithYou_1");
        
        public static By checkHaveOrganizationYes = By.Id("ctl00_SiteContentPlaceHolder_FormView1_rblGroupTravel_0");
        public static By checkHaveOrganizationNo = By.Id("ctl00_SiteContentPlaceHolder_FormView1_rblGroupTravel_1");
        public static By fieldGroupName = By.Id("ctl00_SiteContentPlaceHolder_FormView1_tbxGroupName");
        
        public static By fieldSurnameCompanion = By.Id("ctl00_SiteContentPlaceHolder_FormView1_dlTravelCompanions_ctl00_tbxSurname");
        public static By fieldNameCompanion = By.Id("ctl00_SiteContentPlaceHolder_FormView1_dlTravelCompanions_ctl00_tbxGivenName");
        public static By selectRelationShip = By.XPath("//table[@id='ctl00_SiteContentPlaceHolder_FormView1_dlTravelCompanions']//select");
        
        public static By btnAddCompanion = By.XPath("//A[text()='Add Another']");
    }
    static public class Previous
    {
        public static By checkHaveBeenUSAYes = By.Id("");
        public static By checkHaveBeenUSANo = By.Id("");
        public static By select = By.Id("");
        public static By select = By.Id("");
        public static By field = By.Id("");
        public static By field = By.Id("");
        public static By field = By.Id("");
        
        public static By check = By.Id("");
        public static By check = By.Id("");
        
        public static By check = By.Id("");
        public static By check = By.Id("");
        
        public static By check = By.Id("");
        public static By check = By.Id("");
    }
}