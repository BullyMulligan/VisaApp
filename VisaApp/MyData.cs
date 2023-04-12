//класс анкеты с данными

using System.Collections.Generic;

namespace VisaApp
{
    public class MyData
    {
        public int survey_status { get; set; }
        public string unique_id { get; set; }
        
        public FullName full_name { get; set; }
        public string second_name { get; set; }
        public int marital_status { get; set; }
        public string birth_date { get; set; }
        public int sex { get; set; }
        
        public string birth_sity { get; set; }
        public string birth_country { get; set; }
        public Sitizenship sitizenship { get; set; }
        public StayInUSA stay_in_usa { get; set; }
        public InfoAboutTravel info_about_travel { get; set; }
        public List<Person> companions { get; set; }
        public bool have_been_to_USA { get; set; }
        public string date_arrival { get; set; }
        public string time_arrival { get; set; }
        public int unit_arrival { get; set; }
        public bool have_driver_doc { get; set; }
        public string driver_doc_number { get; set; }
        public string driver_doc_state { get; set; }
        public bool have_visa_before { get; set; }
        public string date_issue_visa { get; set; }
        public string visa_number { get; set; }
        public bool same_type_visa { get; set; }
        public bool same_country { get; set; }
        public bool fingers_prints { get; set; }
        public bool loss_visa { get; set; }
        public string year_loss_visa { get; set; }
        public string loss_explain { get; set; }
        public bool cancelled_visa { get; set; }
        public string cancel_explain { get; set; }
        public bool rejection_visa { get; set; }
        public string rejection_reason { get; set; }
        public bool greencard { get; set; }
        public string imigration_explain{ get; set; }
        public Address address { get; set; }
        public Address real_address { get; set; }
        public string personal_number { get; set; }
        public string additive_number { get; set; }
        public string job_number { get; set; }
        public List<string> numbers_of_fives_years { get; set; }
        public string email { get; set; }
        public List<string> email_adresses { get; set; }
        public List<PublicLink> public_links { get; set; }
        public Passport passport { get; set; }
        public Inviter inviter { get; set; }
        public Person father { get; set; }
        public Person mother { get; set; }
        public Person spouse { get; set; }
        public List<InfoAboutJobAndStudy> job { get; set; }
        public List<InfoAboutJobAndStudy> study {get; set;}
        public AdditiveInfo additive_info { get; set; }

        public class Army
        {
            public string country {get; set;}
            public string division {get; set;}
            public string rang {get; set;}
            public string specialty {get; set;}
            public string start_date{get; set;}
            public string and_date{get; set;}
        }
        public class Inviter
        {
            public bool have_invite { get; set; }
            public string name { get; set; }
            public string surname { get; set; }
            public string company_name { get; set; }
            public int relationship { get; set; }
            public Address address { get; set; }
            public string number { get; set; }
            public string email { get; set; }
        }
        public class AdditiveInfo
        {
            public List<string> languages{get;set;}
            public List<string> countrys{get;set;}
            public string spec_org{get;set;}
            public bool have_spec_skill{get;set;}
            public bool have_army{get;set;}
            public Army army { get; set; }
            public bool have_spec_group{get;set;}
        }

        public class InfoAboutJobAndStudy
        {
            public int kind_of_activity{get;set;}
            public string company_name { get; set; }
            public Address address{get;set;}
            public string job_number{get;set;}
            public string start_date{get;set;}
            public string end_date{get;set;}
            public string wages{get;set;}
            public string spec{get;set;}
            public string title { get; set; }
            public string supervizor_surname { get; set; }
            public string supervizor_name { get; set; }
            public string course { get; set; }
        }

        public class Passport
        {
            public int passport_type { get;set; }
            public string number{get;set;}
            public string country{get;set;}
            public string region{get;set;}
            public string city{get;set;}
            public string issuedate{get;set;}
            public string endDate{get;set;}
            public bool isLoss{get;set;}
            public string loss_passport_number { get;set; }
            public string loss_passport_country { get;set; }
            public string loss_passport_explain{ get;set; }
        }
        public class PublicLink
        {
            public int linl_soc_web{get;set;}
            public string link_to_account{get;set;}
        }
        public class Address
        {
            public string street{get;set;}
            public string city{get;set;}
            public string region{get;set;}
            public string index{get;set;}
            public string country{get;set;}
        }

        public class Person
        {
            public string name {get;set;}
            public string surname { get; set; }
            public string birth_date { get; set; }
            public bool is_sitizen_usa { get; set; }
            public string birth_country { get; set; }
            public string birht_city { get; set; }
            public int address { get; set; }
            public int usa_status { get; set; }
            public int status {get;set;}
        }
    
        public class InfoAboutTravel
        {
            public int visa_char {get;set;}
            public int visa_type {get;set;}
            public string travel_goal {get;set;}
            public string arrival_date {get;set;}
            public string arrival_city {get;set;}
            public string departure_date{get;set;}
            public string departure_city {get;set;}
            public List<string> travel_places {get;set;}
            public Address stop_address {get;set;}
            public string hotel_number { get; set; }
            public int payer {get;set;}
            public bool have_group { get; set; }
            public string group_name { get; set; }
        }

        public class StayInUSA
        {
            public string national_identification_number{get;set;}
            public string social_security_number{get;set;}
            public string taxpayer_number{get;set;}
            
        }
        public class Sitizenship
        {
            public string sitizenship { get; set; }
            public bool second_sitizenship{ get; set; }
            public string second_sitizen_country { get; set; }
            public bool second_passport_availability{ get; set; }
            public string number_second_passport{ get; set; }
            public bool permanent_resident{ get; set; }
            public string second_country{ get; set; }
        }

        public class FullName
        {
            public string name {get;set;}
            public string surnname {get;set;}
            public string fathername {get;set;}

            public FullName(string _name, string _surnname, string _fathername)
            {
                name = _name;
                surnname = _surnname;
                fathername = _fathername;
            }
            public FullName() { }
        
        }
        public class BirthDate
        {
            public int birth_day {get;set;}
            public int birth_month {get;set;}
            public int birth_year {get;set;}
        }
        
        
        
    }
}