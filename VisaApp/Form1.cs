using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using OpenQA.Selenium.Chrome;
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
        }

        private void btnLoadSurvey_Click(object sender, EventArgs e)
        {
            OpenSurvey();
            VisibleButtons();
        }
        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            Sel selenium = new Sel(survey);
            survey=selenium.CreateUser();
            SaveSurvey();
            selenium.PersonalOne();
            survey.survey_status = 1;
            VisibleButtons();
        }

        

        private void btnPersonalTwo_Click(object sender, EventArgs e)
        {
            Sel selenium = new Sel(survey);
            selenium.NextPage();
            selenium.PersonalTwo();
            survey.survey_status = 2;
            VisibleButtons();

        }

        private void btnTravelInfornation_Click(object sender, EventArgs e)
        {
            Sel selenium = new Sel(survey);
            selenium.NextPage(); 
            //selenium.NextPage();
            selenium.TravelInfornation();
            survey.survey_status = 3;
            VisibleButtons();
        }

        private void btnCompanions_Click(object sender, EventArgs e)
        {
            Sel selenium = new Sel(survey);
            selenium.NextPage();
            //selenium.NextPage();
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
                {btnCompanions,3}
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
            Sel selenium = new Sel(survey);
            survey=selenium.CreateUser();
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

            VisibleButtons();
        }
    }
}