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
using System.Text.Json;

namespace VisaApp
{
    public partial class Form1 : Form
    {
        private MyData survey;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenSurvey();
            Sel selenium = new Sel(survey);
            selenium.StartPage();
            Sel.Driver.Quit();
        }

        private void OpenSurvey()
        {
            if (openFileDialogSurvey.ShowDialog()== DialogResult.OK)
            {
                DeserializedJson();
                MessageBox.Show(survey.full_name.name);
            }
            else
            {
                MessageBox.Show("Выберите файл анкеты!");
            }
        }

        private void DeserializedJson()
        {
            string json  = File.ReadAllText(openFileDialogSurvey.FileName);
            MessageBox.Show(json);
            survey = new MyData();
            survey = JsonSerializer.Deserialize<MyData>(json);
        }
    }
}