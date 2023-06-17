using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace VisaApp
{
    public partial class Form1 : Form
    {
        private MyData survey;
        public Form1()
        {
            InitializeComponent();
            //VisibleButtons();
        }
        private void OpenSurvey()
        {
            if (openFileDialogSurvey.ShowDialog()== DialogResult.OK)
            {
                DeserializedJson();
            }
            else
            {
                MessageBox.Show("Выберите файл анкеты!");
            }
            VisibleButtons();
        }
        private void SaveSurvey()
        {
            if (string.IsNullOrEmpty(openFileDialogSurvey.FileName))
            {
                MessageBox.Show("Выберите файл анкеты!");
                return;
            }

            // Создаем объект JsonSerializerSettings для указания настроек сериализации
            var settings = new JsonSerializerSettings
            {
                Formatting = Formatting.Indented, // Устанавливаем форматирование JSON
                NullValueHandling = NullValueHandling.Ignore // Игнорируем null значения при сериализации
            };

            // Сериализуем объект survey в JSON строку
            var serializedJson = JsonConvert.SerializeObject(survey, settings);

            try
            {
                File.WriteAllText(openFileDialogSurvey.FileName, serializedJson);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении файла: {ex.Message}");
            }
        }


        private void DeserializedJson()
        {
            string json  = File.ReadAllText(openFileDialogSurvey.FileName);
            survey = new MyData();
            survey = JsonSerializer.Deserialize<MyData>(json);
            Identificator.Text = survey.unique_id;
            labelName.Text = $"{survey.full_name.surnname} {survey.full_name.name}";
            comboBoxStatus.SelectedItem = survey.survey_status;
        }

        private void btnLoadSurvey_Click(object sender, EventArgs e)
        {
            OpenSurvey();
            VisibleButtons();
        }
        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            Sel selenium = new Sel(survey);
            selenium.Setup();
            survey=selenium.CreateUser();
            SaveSurvey();
            selenium.PersonalOne();
            survey.survey_status = 1;
            VisibleButtons();
        }

        

        private void btnPersonalTwo_Click(object sender, EventArgs e)
        {
            Sel selenium = new Sel(survey);
            selenium.ContinueChangeUser();
            //selenium.NextPage();
            selenium.PersonalTwo();
            survey.survey_status = 2;
            VisibleButtons();

        }

        private void btnTravelInfornation_Click(object sender, EventArgs e)
        {
            Sel selenium = new Sel(survey);
            selenium.ContinueChangeUser();
            //selenium.NextPage(); 
            //selenium.NextPage();
            selenium.TravelInfornation();
            survey.survey_status = 3;
            VisibleButtons();
        }

        private void btnCompanions_Click(object sender, EventArgs e)
        {
            Sel selenium = new Sel(survey);
            selenium.ContinueChangeUser();
            selenium.TravelCompanionsInformation();
            survey.survey_status = 4;
            VisibleButtons();

        }

        void VisibleButtons()
        {
            
            Dictionary<Button, int> buttons = new Dictionary<Button, int>()
            {
                {btnCreateUser,0},
                {btnStartAll,0},
                {btnPersonalTwo,1},
                {btnTravelInfornation,2},
                {btnCompanions,3},
                {btnPrevious,4},
                {btnAdressAndPhone,5},
                {btnPassportInformation,6},
                {btnUSContact,7},
                {btnFamilyInformation,8},
                {btnSpose,9},
                {btnWork,10},
                {btnOnly,11}
            };
            foreach (var button in buttons)
            {
                if (survey.survey_status != button.Value)
                {
                    button.Key.Visible = false;
                }
                else
                {
                    button.Key.Visible = true;
                }
            }
        }

        private void btnStartAll_Click(object sender, EventArgs e)
        {
            try
            {
                Sel selenium = new Sel(survey);
                survey = selenium.CreateUser();
                SaveSurvey();
                selenium.PersonalOne();
                survey.survey_status = 1;
                SaveSurvey();
                selenium.PersonalTwo();
                survey.survey_status = 2;
                SaveSurvey();
                selenium.TravelInfornation();
                survey.survey_status = 3;
                SaveSurvey();
                selenium.TravelCompanionsInformation();
                survey.survey_status = 4;
                SaveSurvey();
                selenium.AddPrevious();
                survey.survey_status = 5;
                SaveSurvey();
                selenium.AddressAndPhone();
                survey.survey_status = 6;
                SaveSurvey();
                selenium.AddPassport();
                survey.survey_status = 7;
                SaveSurvey();
                selenium.USContact();
                survey.survey_status = 8;
                SaveSurvey();
                selenium.Family();
                survey.survey_status = 9;
                SaveSurvey();
                selenium.AddSpouse();
                survey.survey_status = 10;
                SaveSurvey();
                selenium.AdditionalWork();
                survey.survey_status = 11;
                SaveSurvey();
                selenium.BackGroundAndSecury();
                survey.survey_status = 12;
                SaveSurvey();
                VisibleButtons();
            }
            catch (Exception)
            {
                
            }
            VisibleButtons();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            Sel selenium = new Sel(survey);
            selenium.ContinueChangeUser();
            selenium.AddPrevious();
            survey.survey_status = 5;
            SaveSurvey();
        }

        private void btnAdressAndPhone_Click(object sender, EventArgs e)
        {
            Sel selenium = new Sel(survey);
            selenium.ContinueChangeUser();
            selenium.AddressAndPhone();
            survey.survey_status = 6;
            SaveSurvey();
        }

        private void btnPassportInformation_Click(object sender, EventArgs e)
        {
            Sel selenium = new Sel(survey);
            selenium.ContinueChangeUser();
            selenium.AddPassport();
            survey.survey_status = 7;
            SaveSurvey();
        }

        private void btnUSContact_Click(object sender, EventArgs e)
        {
            Sel selenium = new Sel(survey);
            selenium.ContinueChangeUser();
            selenium.USContact();
            survey.survey_status = 8;
            SaveSurvey();
        }

        private void btnFamilyInformation_Click(object sender, EventArgs e)
        {
            Sel selenium = new Sel(survey);
            selenium.ContinueChangeUser();
            selenium.Family();
            survey.survey_status = 9;
            SaveSurvey();
        }

        private void btnSpose_Click(object sender, EventArgs e)
        {
            Sel selenium = new Sel(survey);
            selenium.ContinueChangeUser();
            selenium.AddSpouse();
            survey.survey_status = 10;
            SaveSurvey();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sel selenium = new Sel(survey);
            selenium.ContinueChangeUser();
            selenium.AdditionalWork();
            survey.survey_status = 11;
            SaveSurvey();
        }

        private void btnOnly_Click(object sender, EventArgs e)
        {
            Sel selenium = new Sel(survey);
            selenium.ContinueChangeUser();
            selenium.BackGroundAndSecury();
            survey.survey_status = 12;
            SaveSurvey();
        }

        private void btnChangeStatus_Click(object sender, EventArgs e)
        {
            survey.survey_status = comboBoxStatus.SelectedIndex;
            SaveSurvey();
            VisibleButtons();
        }
    }
}