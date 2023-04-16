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
        public static By checkHaveBeenUSAYes = By.Id("ctl00_SiteContentPlaceHolder_FormView1_rblPREV_US_TRAVEL_IND_0");
        public static By checkHaveBeenUSANo = By.Id("ctl00_SiteContentPlaceHolder_FormView1_rblPREV_US_TRAVEL_IND_1");
        public static By selectDateArrivedDay = By.Id("ctl00_SiteContentPlaceHolder_FormView1_dtlPREV_US_VISIT_ctl00_ddlPREV_US_VISIT_DTEDay");
        public static By selectDateArrivedMonth = By.Id("ctl00_SiteContentPlaceHolder_FormView1_dtlPREV_US_VISIT_ctl00_ddlPREV_US_VISIT_DTEMonth");
        public static By fieldDateArrivedYear = By.Id("ctl00_SiteContentPlaceHolder_FormView1_dtlPREV_US_VISIT_ctl00_tbxPREV_US_VISIT_DTEYear");
        public static By fieldLengthOfStay = By.Id("ctl00_SiteContentPlaceHolder_FormView1_dtlPREV_US_VISIT_ctl00_tbxPREV_US_VISIT_LOS");
        public static By selectUnit = By.Id("ctl00_SiteContentPlaceHolder_FormView1_dtlPREV_US_VISIT_ctl00_ddlPREV_US_VISIT_LOS_CD");
        
        public static By checkHaveDriverLicenseYes = By.Id("ctl00_SiteContentPlaceHolder_FormView1_rblPREV_US_DRIVER_LIC_IND_0");
        public static By checkHaveDriverLicenseNo = By.Id("ctl00_SiteContentPlaceHolder_FormView1_rblPREV_US_DRIVER_LIC_IND_1");
        public static By fieldDriverLicenseNumber = By.Id("ctl00_SiteContentPlaceHolder_FormView1_dtlUS_DRIVER_LICENSE_ctl00_tbxUS_DRIVER_LICENSE");
        public static By checkDoNotKnowDriver = By.Id("ctl00_SiteContentPlaceHolder_FormView1_dtlUS_DRIVER_LICENSE_ctl00_cbxUS_DRIVER_LICENSE_NA");
        public static By selectDriverLicenseState = By.Id("ctl00_SiteContentPlaceHolder_FormView1_dtlUS_DRIVER_LICENSE_ctl00_ddlUS_DRIVER_LICENSE_STATE");
        
        public static By checkHaveEvenIssuedUSYes = By.Id("ctl00_SiteContentPlaceHolder_FormView1_rblPREV_VISA_IND_0");
        public static By checkHaveEvenIssuedUSNo = By.Id("ctl00_SiteContentPlaceHolder_FormView1_rblPREV_VISA_IND_1");
        public static By selectDateIssueDay = By.Id("ctl00_SiteContentPlaceHolder_FormView1_ddlPREV_VISA_ISSUED_DTEDay");
        public static By selectDateIssueMonth = By.Id("ctl00_SiteContentPlaceHolder_FormView1_ddlPREV_VISA_ISSUED_DTEMonth");
        public static By fieldDateIssueYear = By.Id("ctl00_SiteContentPlaceHolder_FormView1_tbxPREV_VISA_ISSUED_DTEYear");
        public static By fieldVisaNumber = By.Id("ctl00_SiteContentPlaceHolder_FormView1_tbxPREV_VISA_FOIL_NUMBER");
        public static By checkDoNotKnow = By.Id("ctl00_SiteContentPlaceHolder_FormView1_cbxPREV_VISA_FOIL_NUMBER_NA");
        public static By checkVisaIsSameYes = By.Id("ctl00_SiteContentPlaceHolder_FormView1_rblPREV_VISA_SAME_TYPE_IND_0");
        public static By checkVisaIsSameNo = By.Id("ctl00_SiteContentPlaceHolder_FormView1_rblPREV_VISA_SAME_TYPE_IND_1");
        public static By checkCountryIsSameYes = By.Id("ctl00_SiteContentPlaceHolder_FormView1_rblPREV_VISA_SAME_CNTRY_IND_0");
        public static By checkCountryIsSameNo = By.Id("ctl00_SiteContentPlaceHolder_FormView1_rblPREV_VISA_SAME_CNTRY_IND_1");
        public static By checkHaveTenPrintedYes = By.Id("ctl00_SiteContentPlaceHolder_FormView1_rblPREV_VISA_TEN_PRINT_IND_0");
        public static By checkHaveTenPrintedNo = By.Id("ctl00_SiteContentPlaceHolder_FormView1_rblPREV_VISA_TEN_PRINT_IND_1");
        public static By checkLostVisaYes = By.Id("ctl00_SiteContentPlaceHolder_FormView1_rblPREV_VISA_LOST_IND_0");
        public static By checkLostVisaNo = By.Id("ctl00_SiteContentPlaceHolder_FormView1_rblPREV_VISA_LOST_IND_1");
        public static By fieldLostYear = By.Id("ctl00_SiteContentPlaceHolder_FormView1_tbxPREV_VISA_LOST_YEAR");
        public static By fieldExplain = By.Id("ctl00_SiteContentPlaceHolder_FormView1_tbxPREV_VISA_LOST_EXPL");
        public static By checkCanceledVisaYes = By.Id("ctl00_SiteContentPlaceHolder_FormView1_rblPREV_VISA_CANCELLED_IND_0");
        public static By checkCanceledVisaNo = By.Id("ctl00_SiteContentPlaceHolder_FormView1_rblPREV_VISA_CANCELLED_IND_1");
        public static By fieldCancelExplain = By.Id("ctl00_SiteContentPlaceHolder_FormView1_tbxPREV_VISA_CANCELLED_EXPL");
        
        public static By checkRefusedVisaYes = By.Id("ctl00_SiteContentPlaceHolder_FormView1_rblPREV_VISA_REFUSED_IND_0");
        public static By checkRefusedVisaNo = By.Id("ctl00_SiteContentPlaceHolder_FormView1_rblPREV_VISA_REFUSED_IND_1");
        public static By fieldRefusedExplain = By.Id("ctl00_SiteContentPlaceHolder_FormView1_tbxPREV_VISA_REFUSED_EXPL");
        
        public static By checkTryImmigrantYes = By.Id("ctl00_SiteContentPlaceHolder_FormView1_rblIV_PETITION_IND_0");
        public static By checkTryImmigrantNo = By.Id("ctl00_SiteContentPlaceHolder_FormView1_rblIV_PETITION_IND_1");
        public static By fieldImmigrantExplain = By.Id("ctl00_SiteContentPlaceHolder_FormView1_tbxIV_PETITION_EXPL");
    }

    public class Address
    {
        public static By fieldHomeStreet = By.Id("ctl00_SiteContentPlaceHolder_FormView1_tbxAPP_ADDR_LN1");
        public static By fieldHomeStreet2 = By.Id("ctl00_SiteContentPlaceHolder_FormView1_tbxAPP_ADDR_LN2");
        public static By fieldHomeCity = By.Id("ctl00_SiteContentPlaceHolder_FormView1_tbxAPP_ADDR_CITY");
        public static By fieldHomeState = By.Id("ctl00_SiteContentPlaceHolder_FormView1_tbxAPP_ADDR_STATE");
        public static By checkHomeStateNotApply = By.Id("ctl00_SiteContentPlaceHolder_FormView1_cbexAPP_ADDR_STATE_NA");
        public static By fieldHomeZip = By.Id("ctl00_SiteContentPlaceHolder_FormView1_tbxAPP_ADDR_POSTAL_CD");
        public static By checkHomeZipNotApply = By.Id("ctl00_SiteContentPlaceHolder_FormView1_cbexAPP_ADDR_POSTAL_CD_NA");
        public static By selectHomeCountry = By.Id("ctl00_SiteContentPlaceHolder_FormView1_ddlCountry");
        
        public static By checkMailAddressYes = By.Id("ctl00_SiteContentPlaceHolder_FormView1_rblMailingAddrSame_0");
        public static By checkMailAddressNo = By.Id("ctl00_SiteContentPlaceHolder_FormView1_rblMailingAddrSame_1");
        
        public static By fieldMailStreet = By.Id("ctl00_SiteContentPlaceHolder_FormView1_tbxMAILING_ADDR_LN1");
        public static By fieldMailStreet2 = By.Id("ctl00_SiteContentPlaceHolder_FormView1_tbxMAILING_ADDR_LN2");
        public static By fieldMailCity = By.Id("ctl00_SiteContentPlaceHolder_FormView1_tbxMAILING_ADDR_CITY");
        public static By fieldMailState = By.Id("ctl00_SiteContentPlaceHolder_FormView1_tbxMAILING_ADDR_STATE");
        public static By checkMailStateNotApply = By.Id("ctl00_SiteContentPlaceHolder_FormView1_cbexMAILING_ADDR_STATE_NA");
        public static By fieldMailZip = By.Id("ctl00_SiteContentPlaceHolder_FormView1_tbxMAILING_ADDR_POSTAL_CD");
        public static By checkMailZipNotApply = By.Id("ctl00_SiteContentPlaceHolder_FormView1_cbexMAILING_ADDR_POSTAL_CD_NA");
        public static By selectMailCountry = By.Id("ctl00_SiteContentPlaceHolder_FormView1_ddlMailCountry");
        
        public static By fieldPrimaryPhone = By.Id("ctl00_SiteContentPlaceHolder_FormView1_tbxAPP_HOME_TEL");
        public static By fieldSecondaryPhone = By.Id("ctl00_SiteContentPlaceHolder_FormView1_tbxAPP_MOBILE_TEL");
        public static By checkSecondaryNotApply = By.Id("ctl00_SiteContentPlaceHolder_FormView1_cbexAPP_MOBILE_TEL_NA");
        public static By fieldWorkPhone = By.Id("ctl00_SiteContentPlaceHolder_FormView1_tbxAPP_BUS_TEL");
        public static By checkWorkNotApply = By.Id("ctl00_SiteContentPlaceHolder_FormView1_cbexAPP_BUS_TEL_NA");

        public static By checkHaveAnotherNumbersYes = By.Id("ctl00_SiteContentPlaceHolder_FormView1_rblAddPhone_0");
        public static By checkHaveAnotherNumbersNo = By.Id("ctl00_SiteContentPlaceHolder_FormView1_rblAddPhone_1");

        public static By fieldAdditionalPhone = By.Id("ctl00_SiteContentPlaceHolder_FormView1_dtlAddPhone_ctl00_tbxAddPhoneInfo");
        public static By btnAddPhone = By.Id("ctl00_SiteContentPlaceHolder_FormView1_dtlAddPhone_ctl00_InsertButtonADDL_PHONE");
        
        public static By fieldEmail = By.Id("ctl00_SiteContentPlaceHolder_FormView1_tbxAPP_EMAIL_ADDR");
        
        public static By checkHaveAnotherEmailYes = By.Id("ctl00_SiteContentPlaceHolder_FormView1_rblAddEmail_0");
        public static By checkHaveAnotherEmailNo = By.Id("ctl00_SiteContentPlaceHolder_FormView1_rblAddEmail_1");
        
        public static By fieldAdditionalEmail = By.Id("ctl00_SiteContentPlaceHolder_FormView1_dtlAddEmail_ctl00_tbxAddEmailInfo");
        public static By btnAddEmail = By.Id("ctl00_SiteContentPlaceHolder_FormView1_dtlAddEmail_ctl00_InsertButtonADDL_EMAIL");
        
        public static By checkHaveAnotherSWYes = By.Id("ctl00_SiteContentPlaceHolder_FormView1_rblAddSocial_0");
        public static By checkHaveAnotherSWNo = By.Id("ctl00_SiteContentPlaceHolder_FormView1_rblAddSocial_1");
    }

    public class Passport
    {
        public static By selectPassportType = By.Id("ctl00_SiteContentPlaceHolder_FormView1_ddlPPT_TYPE");
        public static By fieldPassportNumber = By.Id("ctl00_SiteContentPlaceHolder_FormView1_tbxPPT_NUM");
         
        public static By checkNotApply = By.Id("ctl00_SiteContentPlaceHolder_FormView1_cbexPPT_BOOK_NUM_NA");
        public static By selectPassportCountry = By.Id("ctl00_SiteContentPlaceHolder_FormView1_ddlPPT_ISSUED_CNTRY");
        public static By fieldPassportCity = By.Id("ctl00_SiteContentPlaceHolder_FormView1_tbxPPT_ISSUED_IN_CITY");
        public static By fieldPassportState = By.Id("ctl00_SiteContentPlaceHolder_FormView1_tbxPPT_ISSUED_IN_STATE");
        public static By selectPassportIssueCountry = By.Id("ctl00_SiteContentPlaceHolder_FormView1_ddlPPT_ISSUED_IN_CNTRY");
         
        public static By selectIssuanceDay = By.Id("ctl00_SiteContentPlaceHolder_FormView1_ddlPPT_ISSUED_DTEDay");
        public static By selectIssuanceMonth = By.Id("ctl00_SiteContentPlaceHolder_FormView1_ddlPPT_ISSUED_DTEMonth");
        public static By fieldIssuanceYear = By.Id("ctl00_SiteContentPlaceHolder_FormView1_tbxPPT_ISSUEDYear");
         
        public static By selectExpirationDay = By.Id("ctl00_SiteContentPlaceHolder_FormView1_ddlPPT_EXPIRE_DTEDay");
        public static By selectExpirationMonth = By.Id("ctl00_SiteContentPlaceHolder_FormView1_ddlPPT_EXPIRE_DTEMonth");
        public static By fieldExpirationYear = By.Id("ctl00_SiteContentPlaceHolder_FormView1_tbxPPT_EXPIREYear");
        public static By checkNoExpiration = By.Id("ctl00_SiteContentPlaceHolder_FormView1_cbxPPT_EXPIRE_NA");
         
        public static By checkLostPassportYes = By.Id("ctl00_SiteContentPlaceHolder_FormView1_rblLOST_PPT_IND_0");
        public static By checkLostPassportNo = By.Id("ctl00_SiteContentPlaceHolder_FormView1_rblLOST_PPT_IND_1");
         
        public static By fieldLostPassportNumber = By.Id("ctl00_SiteContentPlaceHolder_FormView1_dtlLostPPT_ctl00_tbxLOST_PPT_NUM");
        public static By checkDontKnow = By.Id("ctl00_SiteContentPlaceHolder_FormView1_dtlLostPPT_ctl00_cbxLOST_PPT_NUM_UNKN_IND");
        public static By selectLostPassportCountry = By.Id("ctl00_SiteContentPlaceHolder_FormView1_dtlLostPPT_ctl00_ddlLOST_PPT_NATL");
        public static By fieldExplain = By.Id("ctl00_SiteContentPlaceHolder_FormView1_dtlLostPPT_ctl00_tbxLOST_PPT_EXPL");
    }
    public class USContactInformation
    {
        public static By fieldContactPersonSurname = By.Id("ctl00_SiteContentPlaceHolder_FormView1_tbxUS_POC_SURNAME");
        public static By fieldContactPersonName = By.Id("ctl00_SiteContentPlaceHolder_FormView1_tbxUS_POC_GIVEN_NAME");
        public static By checkDontRnowName = By.Id("ctl00_SiteContentPlaceHolder_FormView1_cbxUS_POC_NAME_NA");
        public static By fieldOrganizationName = By.Id("ctl00_SiteContentPlaceHolder_FormView1_tbxUS_POC_ORGANIZATION");
        public static By checkDontKnowOrganization = By.Id("ctl00_SiteContentPlaceHolder_FormView1_cbxUS_POC_ORG_NA_IND");
        public static By selectRelationship = By.Id("ctl00_SiteContentPlaceHolder_FormView1_ddlUS_POC_REL_TO_APP");

        public static By fieldStreet1 = By.Id("ctl00_SiteContentPlaceHolder_FormView1_tbxUS_POC_ADDR_LN1");
        public static By fieldStreet2 = By.Id("ctl00_SiteContentPlaceHolder_FormView1_tbxUS_POC_ADDR_LN2");
        public static By fieldCity = By.Id("ctl00_SiteContentPlaceHolder_FormView1_tbxUS_POC_ADDR_CITY");
        public static By selectState = By.Id("ctl00_SiteContentPlaceHolder_FormView1_ddlUS_POC_ADDR_STATE");
        public static By fieldZip = By.Id("ctl00_SiteContentPlaceHolder_FormView1_tbxUS_POC_ADDR_POSTAL_CD");
        public static By fieldPhone = By.Id("ctl00_SiteContentPlaceHolder_FormView1_tbxUS_POC_HOME_TEL");
        public static By fieldEmail = By.Id("ctl00_SiteContentPlaceHolder_FormView1_tbxUS_POC_EMAIL_ADDR");
        public static By checkNotApply = By.Id("ctl00_SiteContentPlaceHolder_FormView1_cbexUS_POC_EMAIL_ADDR_NA");
    }

    public class FamilyInfo
    {
        public static By fieldFatherSurname = By.Id("ctl00_SiteContentPlaceHolder_FormView1_tbxFATHER_SURNAME");
        public static By checkFatherSurmaneDontKnow = By.Id("ctl00_SiteContentPlaceHolder_FormView1_cbxFATHER_SURNAME_UNK_IND");
        public static By fieldFatherName = By.Id("ctl00_SiteContentPlaceHolder_FormView1_tbxFATHER_GIVEN_NAME");
        public static By checkFatherNaneDontKnow  = By.Id("ctl00_SiteContentPlaceHolder_FormView1_cbxFATHER_GIVEN_NAME_UNK_IND");
        public static By selectFatherDay = By.Id("ctl00_SiteContentPlaceHolder_FormView1_ddlFathersDOBDay");
        public static By selectFatherMonth = By.Id("ctl00_SiteContentPlaceHolder_FormView1_ddlFathersDOBMonth");
        public static By fieldFatherYear = By.Id("ctl00_SiteContentPlaceHolder_FormView1_tbxFathersDOBYear");
        public static By checkFatherBirthDayDontKnow = By.Id("ctl00_SiteContentPlaceHolder_FormView1_cbxFATHER_DOB_UNK_IND");
        public static By checkFatherInUSYes = By.Id("ctl00_SiteContentPlaceHolder_FormView1_rblFATHER_LIVE_IN_US_IND_0");
        public static By checkFatherInUSNo = By.Id("ctl00_SiteContentPlaceHolder_FormView1_rblFATHER_LIVE_IN_US_IND_1");
        public static By selectFatherStatus = By.Id("ctl00_SiteContentPlaceHolder_FormView1_ddlFATHER_US_STATUS");

        public static By fieldMotherSurname = By.Id("ctl00_SiteContentPlaceHolder_FormView1_tbxMOTHER_SURNAME");
        public static By checkMotherSurmaneDontKnow = By.Id("ctl00_SiteContentPlaceHolder_FormView1_cbxMOTHER_SURNAME_UNK_IND");
        public static By fieldMotherName = By.Id("ctl00_SiteContentPlaceHolder_FormView1_tbxMOTHER_GIVEN_NAME");
        public static By checkMotherNaneDontKnow  = By.Id("ctl00_SiteContentPlaceHolder_FormView1_cbxMOTHER_GIVEN_NAME_UNK_IND");
        public static By selectMotherDay = By.Id("ctl00_SiteContentPlaceHolder_FormView1_ddlMothersDOBDay");
        public static By selectMotherMonth = By.Id("ctl00_SiteContentPlaceHolder_FormView1_ddlMothersDOBMonth");
        public static By fieldMotherYear = By.Id("ctl00_SiteContentPlaceHolder_FormView1_tbxMothersDOBYear");
        public static By checkMotherBirthDayDontKnow = By.Id("ctl00_SiteContentPlaceHolder_FormView1_cbxMOTHER_DOB_UNK_IND");
        public static By checkMotherInUSYes = By.Id("ctl00_SiteContentPlaceHolder_FormView1_rblMOTHER_LIVE_IN_US_IND_0");
        public static By checkMotherInUSNo = By.Id("ctl00_SiteContentPlaceHolder_FormView1_rblMOTHER_LIVE_IN_US_IND_1");
        public static By selectMotherStatus = By.Id("ctl00_SiteContentPlaceHolder_FormView1_ddlMOTHER_US_STATUS");

        public static By checkNo = By.Id("ctl00_SiteContentPlaceHolder_FormView1_rblUS_IMMED_RELATIVE_IND_1");
        public static By checkRelativeNo = By.Id("ctl00_SiteContentPlaceHolder_FormView1_rblUS_OTHER_RELATIVE_IND_1");
    }

    public class Spose
    {
        public static By fieldSurname = By.Id("ctl00_SiteContentPlaceHolder_FormView1_tbxSpouseSurname");
        public static By fieldName = By.Id("ctl00_SiteContentPlaceHolder_FormView1_tbxSpouseGivenName");

        public static By selectBirthDay = By.Id("ctl00_SiteContentPlaceHolder_FormView1_ddlDOBDay");
        public static By selectBirthMonth = By.Id("ctl00_SiteContentPlaceHolder_FormView1_ddlDOBMonth");
        public static By fieldBirthYear = By.Id("ctl00_SiteContentPlaceHolder_FormView1_tbxDOBYear");
         
        public static By selectNationality = By.Id("ctl00_SiteContentPlaceHolder_FormView1_ddlSpouseNatDropDownList");
        public static By fieldCity = By.Id("ctl00_SiteContentPlaceHolder_FormView1_tbxSpousePOBCity");
        public static By checkCityDontKnow = By.Id("ctl00_SiteContentPlaceHolder_FormView1_cbexSPOUSE_POB_CITY_NA");
        public static By selectCountry = By.Id("ctl00_SiteContentPlaceHolder_FormView1_ddlSpousePOBCountry");
        public static By selectAdress = By.Id("ctl00_SiteContentPlaceHolder_FormView1_ddlSpouseAddressType");
    }

    public class Additional
    {
        public static By selectOccupation = By.Id("ctl00_SiteContentPlaceHolder_FormView1_ddlPresentOccupation");
         
        public static By fieldCompanyName = By.Id("ctl00_SiteContentPlaceHolder_FormView1_tbxEmpSchName");
        public static By fieldStreet1 = By.Id("ctl00_SiteContentPlaceHolder_FormView1_tbxEmpSchAddr1");
        public static By fieldStreet2 = By.Id("ctl00_SiteContentPlaceHolder_FormView1_tbxEmpSchAddr2");
        public static By fieldCity = By.Id("ctl00_SiteContentPlaceHolder_FormView1_tbxEmpSchCity");
        public static By fieldState = By.Id("ctl00_SiteContentPlaceHolder_FormView1_tbxWORK_EDUC_ADDR_STATE");
        public static By checkStateNotApply = By.Id("ctl00_SiteContentPlaceHolder_FormView1_cbxWORK_EDUC_ADDR_STATE_NA");
        public static By fieldZip = By.Id("ctl00_SiteContentPlaceHolder_FormView1_tbxWORK_EDUC_ADDR_POSTAL_CD");
        public static By checkZipNotApply = By.Id("ctl00_SiteContentPlaceHolder_FormView1_cbxWORK_EDUC_ADDR_POSTAL_CD_NA");
        public static By fieldPhone = By.Id("ctl00_SiteContentPlaceHolder_FormView1_tbxWORK_EDUC_TEL");
        public static By selectCountry = By.Id("ctl00_SiteContentPlaceHolder_FormView1_ddlEmpSchCountry");
         
        public static By selectStartDay = By.Id("ctl00_SiteContentPlaceHolder_FormView1_ddlEmpDateFromDay");
        public static By selectStartMonth = By.Id("ctl00_SiteContentPlaceHolder_FormView1_ddlEmpDateFromMonth");
        public static By fieldStartYear = By.Id("ctl00_SiteContentPlaceHolder_FormView1_tbxEmpDateFromYear");
         
        public static By fieldWages = By.Id("ctl00_SiteContentPlaceHolder_FormView1_tbxCURR_MONTHLY_SALARY");
        public static By checkWagesNotApply = By.Id("ctl00_SiteContentPlaceHolder_FormView1_cbxCURR_MONTHLY_SALARY_NA");
        public static By fieldSpec = By.Id("ctl00_SiteContentPlaceHolder_FormView1_tbxDescribeDuties");
    }

    public class PreviousWork
    {
        public static By checkPreviousJobYes = By.Id("ctl00_SiteContentPlaceHolder_FormView1_rblPreviouslyEmployed_0");
        public static By checkPreviousJobNo = By.Id("ctl00_SiteContentPlaceHolder_FormView1_rblPreviouslyEmployed_1");
         
        public static string fieldCompanyName = "ctl00_SiteContentPlaceHolder_FormView1_dtlPrevEmpl_ctl00_tbEmployerName";
        public static string fieldStreet1 = "ctl00_SiteContentPlaceHolder_FormView1_dtlPrevEmpl_ctl00_tbEmployerStreetAddress1";
        public static string fieldStreet2 = "ctl00_SiteContentPlaceHolder_FormView1_tbxEmpSchAddr2";
        public static string fieldCity = "ctl00_SiteContentPlaceHolder_FormView1_tbxEmpSchCity";
        public static string fieldState = "ctl00_SiteContentPlaceHolder_FormView1_tbxWORK_EDUC_ADDR_STATE";
        public static string checkStateNotApply = "ctl00_SiteContentPlaceHolder_FormView1_cbxWORK_EDUC_ADDR_STATE_NA";
        public static string fieldZip = "ctl00_SiteContentPlaceHolder_FormView1_tbxWORK_EDUC_ADDR_POSTAL_CD";
        public static string checkZipNotApply = "ctl00_SiteContentPlaceHolder_FormView1_cbxWORK_EDUC_ADDR_POSTAL_CD_NA";
        public static string fieldPhone = "ctl00_SiteContentPlaceHolder_FormView1_tbxWORK_EDUC_TEL";
        public static string selectCountry = "ctl00_SiteContentPlaceHolder_FormView1_ddlEmpSchCountry";

        public static string fieldJobTitle = "ctl00_SiteContentPlaceHolder_FormView1_dtlPrevEmpl_ctl00_tbJobTitle";
        public static string fieldSupervizorSurname = "ctl00_SiteContentPlaceHolder_FormView1_dtlPrevEmpl_ctl00_tbSupervisorSurname";
        public static string checkSurnameSupervizorSurnameDontKnow = "ctl00_SiteContentPlaceHolder_FormView1_dtlPrevEmpl_ctl00_cbxSupervisorSurname_NA";
        public static string fieldSupervizorName = "ctl00_SiteContentPlaceHolder_FormView1_dtlPrevEmpl_ctl00_tbSupervisorGivenName";
        public static string checkSurnameSupervizorNameDontKnow = "ctl00_SiteContentPlaceHolder_FormView1_dtlPrevEmpl_ctl00_cbxSupervisorGivenName_NA";
         
        public static string selectStartDay = "ctl00_SiteContentPlaceHolder_FormView1_dtlPrevEmpl_ctl00_ddlEmpDateFromDay";
        public static string selectStartMonth = "ctl00_SiteContentPlaceHolder_FormView1_dtlPrevEmpl_ctl00_ddlEmpDateFromMonth";
        public static string fieldStartYear = "ctl00_SiteContentPlaceHolder_FormView1_dtlPrevEmpl_ctl00_tbxEmpDateFromYear";
         
        public static string selectEndDay = "ctl00_SiteContentPlaceHolder_FormView1_dtlPrevEmpl_ctl00_ddlEmpDateToDay";
        public static string selectEndMonth = "ctl00_SiteContentPlaceHolder_FormView1_dtlPrevEmpl_ctl00_ddlEmpDateToMonth";
        public static string fieldEndYear = "ctl00_SiteContentPlaceHolder_FormView1_dtlPrevEmpl_ctl00_tbxEmpDateToYear";
         
        public static string fieldSpec = "ctl00_SiteContentPlaceHolder_FormView1_dtlPrevEmpl_ctl00_tbDescribeDuties";

        public static string btnAddJob = "ctl00_SiteContentPlaceHolder_FormView1_dtlPrevEmpl_ctl00_InsertButtonPrevEmpl";
    }
    public class PreviousStudy
   {
        public static By checkPreviousStudyYes = By.Id("ctl00_SiteContentPlaceHolder_FormView1_rblOtherEduc_0");
        public static By checkPreviousStudyNo = By.Id("ctl00_SiteContentPlaceHolder_FormView1_rblOtherEduc_1");
         
        public static string fieldCompanyName = "ctl00_SiteContentPlaceHolder_FormView1_dtlPrevEduc_ctl00_tbxSchoolName";
        public static string fieldStreet1 = "ctl00_SiteContentPlaceHolder_FormView1_dtlPrevEduc_ctl00_tbxSchoolAddr1";
        public static string fieldStreet2 = "ctl00_SiteContentPlaceHolder_FormView1_dtlPrevEduc_ctl00_tbxSchoolAddr2";
        public static string fieldCity = "ctl00_SiteContentPlaceHolder_FormView1_dtlPrevEduc_ctl00_tbxSchoolCity";
        public static string fieldState = "ctl00_SiteContentPlaceHolder_FormView1_dtlPrevEduc_ctl00_tbxEDUC_INST_ADDR_STATE";
        public static string checkStateNotApply = "ctl00_SiteContentPlaceHolder_FormView1_dtlPrevEduc_ctl00_cbxEDUC_INST_ADDR_STATE_NA";
        public static string fieldZip = "ctl00_SiteContentPlaceHolder_FormView1_dtlPrevEduc_ctl00_tbxEDUC_INST_POSTAL_CD";
        public static string checkZipNotApply = "ctl00_SiteContentPlaceHolder_FormView1_dtlPrevEduc_ctl00_cbxEDUC_INST_POSTAL_CD_NA";
        public static string selectCountry = "ctl00_SiteContentPlaceHolder_FormView1_dtlPrevEduc_ctl00_ddlSchoolCountry";
        public static string fieldCourse = "ctl00_SiteContentPlaceHolder_FormView1_dtlPrevEduc_ctl00_tbxSchoolCourseOfStudy";
       
        public static string selectStartDay = "ctl00_SiteContentPlaceHolder_FormView1_dtlPrevEduc_ctl00_ddlSchoolFromDay";
        public static string selectStartMonth = "ctl00_SiteContentPlaceHolder_FormView1_dtlPrevEduc_ctl00_ddlSchoolFromMonth";
        public static string fieldStartYear = "ctl00_SiteContentPlaceHolder_FormView1_dtlPrevEduc_ctl00_tbxSchoolFromYear";
         
        public static string selectEndDay = "ctl00_SiteContentPlaceHolder_FormView1_dtlPrevEduc_ctl00_ddlSchoolToDay";
        public static string selectEndMonth = "ctl00_SiteContentPlaceHolder_FormView1_dtlPrevEduc_ctl00_ddlSchoolToMonth";
        public static string fieldEndYear = "ctl00_SiteContentPlaceHolder_FormView1_dtlPrevEduc_ctl00_tbxSchoolToYear";
         
        public static string btnAddStudy = "ctl00_SiteContentPlaceHolder_FormView1_dtlPrevEduc_ctl00_InsertButtonPrevEduc";
    }

    public static class TraningInfo
    {
        public static By checkClanYes = By.Id("ctl00_SiteContentPlaceHolder_FormView1_rblCLAN_TRIBE_IND_0");
        public static By checkClanNo = By.Id("ctl00_SiteContentPlaceHolder_FormView1_rblCLAN_TRIBE_IND_1");
        public static By ClanName = By.Id("ctl00_SiteContentPlaceHolder_FormView1_tbxCLAN_TRIBE_NAME");
        
        public static string fieldLanguage = "ctl00_SiteContentPlaceHolder_FormView1_dtlLANGUAGES_ctl00_tbxLANGUAGE_NAME";
        public static string btnAddLanguage = "ctl00_SiteContentPlaceHolder_FormView1_dtlLANGUAGES_ctl00_InsertButtonLANGUAGE";
        
        public static By checkCountryVisitYes = By.Id("ctl00_SiteContentPlaceHolder_FormView1_rblCOUNTRIES_VISITED_IND_0");
        public static By checkCountryVisitNo = By.Id("ctl00_SiteContentPlaceHolder_FormView1_rblCOUNTRIES_VISITED_IND_1");
        public static By selectCountry = By.Id("ctl00_SiteContentPlaceHolder_FormView1_dtlCountriesVisited_ctl00_ddlCOUNTRIES_VISITED");
        public static By btnAddCountry = By.Id("ctl00_SiteContentPlaceHolder_FormView1_dtlCountriesVisited_ctl00_InsertButtonCountriesVisited");
        
        public static By checkProfessionalOrganizationYes = By.Id("ctl00_SiteContentPlaceHolder_FormView1_rblORGANIZATION_IND_0");
        public static By checkProfessionalOrganizationNo = By.Id("ctl00_SiteContentPlaceHolder_FormView1_rblORGANIZATION_IND_1");
        public static By fieldProfessionalOrganizationName = By.Id("ctl00_SiteContentPlaceHolder_FormView1_dtlORGANIZATIONS_ctl00_tbxORGANIZATION_NAME");
        
        public static By checkSpecialSkillYes = By.Id("ctl00_SiteContentPlaceHolder_FormView1_rblSPECIALIZED_SKILLS_IND_0");
        public static By checkSpecialSkillNo = By.Id("ctl00_SiteContentPlaceHolder_FormView1_rblSPECIALIZED_SKILLS_IND_1");
        public static By checkSpecialSkill = By.Id("ctl00_SiteContentPlaceHolder_FormView1_tbxSPECIALIZED_SKILLS_EXPL");
        
        public static By checkMilitaryYes = By.Id("ctl00_SiteContentPlaceHolder_FormView1_dtlMILITARY_SERVICE_ctl00_ddlMILITARY_SVC_CNTRY");
        public static By checkMilitaryNo = By.Id("ctl00_SiteContentPlaceHolder_FormView1_dtlMILITARY_SERVICE_ctl00_tbxMILITARY_SVC_BRANCH");
        public static By selectCountryArmy = By.Id("ctl00_SiteContentPlaceHolder_FormView1_dtlMILITARY_SERVICE_ctl00_ddlMILITARY_SVC_CNTRY");
        public static By fieldBranch = By.Id("ctl00_SiteContentPlaceHolder_FormView1_dtlMILITARY_SERVICE_ctl00_tbxMILITARY_SVC_BRANCH");
        public static By fieldRank = By.Id("ctl00_SiteContentPlaceHolder_FormView1_dtlMILITARY_SERVICE_ctl00_tbxMILITARY_SVC_RANK");
        public static By fieldSpeciality = By.Id("ctl00_SiteContentPlaceHolder_FormView1_dtlMILITARY_SERVICE_ctl00_tbxMILITARY_SVC_SPECIALTY");
        public static By fieldStartDay = By.Id("ctl00_SiteContentPlaceHolder_FormView1_dtlMILITARY_SERVICE_ctl00_ddlMILITARY_SVC_FROMDay");
        public static By selectStartMonth = By.Id("ctl00_SiteContentPlaceHolder_FormView1_dtlMILITARY_SERVICE_ctl00_ddlMILITARY_SVC_FROMMonth");
        public static By fieldStartYear = By.Id("ctl00_SiteContentPlaceHolder_FormView1_dtlMILITARY_SERVICE_ctl00_tbxMILITARY_SVC_FROMYear");
        public static By selectEndDay = By.Id("ctl00_SiteContentPlaceHolder_FormView1_dtlMILITARY_SERVICE_ctl00_ddlMILITARY_SVC_TODay");
        public static By selectEndMonth = By.Id("ctl00_SiteContentPlaceHolder_FormView1_dtlMILITARY_SERVICE_ctl00_ddlMILITARY_SVC_TOMonth");
        public static By fieldEndYear = By.Id("ctl00_SiteContentPlaceHolder_FormView1_dtlMILITARY_SERVICE_ctl00_tbxMILITARY_SVC_TOYear");
        
        public static By checkRebelYes = By.Id("ctl00_SiteContentPlaceHolder_FormView1_rblINSURGENT_ORG_IND_0");
        public static By checkRebelNo = By.Id("ctl00_SiteContentPlaceHolder_FormView1_rblINSURGENT_ORG_IND_1");
        public static By fieldExplain = By.Id("ctl00_SiteContentPlaceHolder_FormView1_tbxINSURGENT_ORG_EXPL");
        
        
    }
}