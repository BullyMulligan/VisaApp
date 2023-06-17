namespace VisaApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLoadSurvey = new System.Windows.Forms.Button();
            this.openFileDialogSurvey = new System.Windows.Forms.OpenFileDialog();
            this.btnCreateUser = new System.Windows.Forms.Button();
            this.btnStartAll = new System.Windows.Forms.Button();
            this.btnPersonalTwo = new System.Windows.Forms.Button();
            this.btnTravelInfornation = new System.Windows.Forms.Button();
            this.btnCompanions = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnAdressAndPhone = new System.Windows.Forms.Button();
            this.btnPassportInformation = new System.Windows.Forms.Button();
            this.btnUSContact = new System.Windows.Forms.Button();
            this.btnFamilyInformation = new System.Windows.Forms.Button();
            this.btnSpose = new System.Windows.Forms.Button();
            this.btnWork = new System.Windows.Forms.Button();
            this.btnOnly = new System.Windows.Forms.Button();
            this.Identificator = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.btnChangeStatus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLoadSurvey
            // 
            this.btnLoadSurvey.Location = new System.Drawing.Point(14, 19);
            this.btnLoadSurvey.Name = "btnLoadSurvey";
            this.btnLoadSurvey.Size = new System.Drawing.Size(129, 24);
            this.btnLoadSurvey.TabIndex = 0;
            this.btnLoadSurvey.Text = "Загрузить анкету";
            this.btnLoadSurvey.UseVisualStyleBackColor = true;
            this.btnLoadSurvey.Click += new System.EventHandler(this.btnLoadSurvey_Click);
            // 
            // openFileDialogSurvey
            // 
            this.openFileDialogSurvey.FileName = "openFileDialog1";
            this.openFileDialogSurvey.Filter = "JSON files (*.json)|*.json";
            // 
            // btnCreateUser
            // 
            this.btnCreateUser.Location = new System.Drawing.Point(14, 102);
            this.btnCreateUser.Name = "btnCreateUser";
            this.btnCreateUser.Size = new System.Drawing.Size(129, 26);
            this.btnCreateUser.TabIndex = 1;
            this.btnCreateUser.Text = "Создание юзера";
            this.btnCreateUser.UseVisualStyleBackColor = true;
            this.btnCreateUser.Visible = false;
            this.btnCreateUser.Click += new System.EventHandler(this.btnCreateUser_Click);
            // 
            // btnStartAll
            // 
            this.btnStartAll.Location = new System.Drawing.Point(14, 59);
            this.btnStartAll.Name = "btnStartAll";
            this.btnStartAll.Size = new System.Drawing.Size(129, 26);
            this.btnStartAll.TabIndex = 2;
            this.btnStartAll.Text = "Полное заполнение";
            this.btnStartAll.UseVisualStyleBackColor = true;
            this.btnStartAll.Click += new System.EventHandler(this.btnStartAll_Click);
            // 
            // btnPersonalTwo
            // 
            this.btnPersonalTwo.Location = new System.Drawing.Point(14, 143);
            this.btnPersonalTwo.Name = "btnPersonalTwo";
            this.btnPersonalTwo.Size = new System.Drawing.Size(129, 26);
            this.btnPersonalTwo.TabIndex = 3;
            this.btnPersonalTwo.Text = "PersonalTwo";
            this.btnPersonalTwo.UseVisualStyleBackColor = true;
            this.btnPersonalTwo.Click += new System.EventHandler(this.btnPersonalTwo_Click);
            // 
            // btnTravelInfornation
            // 
            this.btnTravelInfornation.Location = new System.Drawing.Point(14, 185);
            this.btnTravelInfornation.Name = "btnTravelInfornation";
            this.btnTravelInfornation.Size = new System.Drawing.Size(129, 26);
            this.btnTravelInfornation.TabIndex = 4;
            this.btnTravelInfornation.Text = "TravelInfornation";
            this.btnTravelInfornation.UseVisualStyleBackColor = true;
            this.btnTravelInfornation.Click += new System.EventHandler(this.btnTravelInfornation_Click);
            // 
            // btnCompanions
            // 
            this.btnCompanions.Location = new System.Drawing.Point(14, 229);
            this.btnCompanions.Name = "btnCompanions";
            this.btnCompanions.Size = new System.Drawing.Size(129, 26);
            this.btnCompanions.TabIndex = 5;
            this.btnCompanions.Text = "Companions";
            this.btnCompanions.UseVisualStyleBackColor = true;
            this.btnCompanions.Click += new System.EventHandler(this.btnCompanions_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(14, 272);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(129, 26);
            this.btnPrevious.TabIndex = 6;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnAdressAndPhone
            // 
            this.btnAdressAndPhone.Location = new System.Drawing.Point(14, 314);
            this.btnAdressAndPhone.Name = "btnAdressAndPhone";
            this.btnAdressAndPhone.Size = new System.Drawing.Size(129, 26);
            this.btnAdressAndPhone.TabIndex = 7;
            this.btnAdressAndPhone.Text = "Address and Phone";
            this.btnAdressAndPhone.UseVisualStyleBackColor = true;
            this.btnAdressAndPhone.Click += new System.EventHandler(this.btnAdressAndPhone_Click);
            // 
            // btnPassportInformation
            // 
            this.btnPassportInformation.Location = new System.Drawing.Point(14, 356);
            this.btnPassportInformation.Name = "btnPassportInformation";
            this.btnPassportInformation.Size = new System.Drawing.Size(129, 26);
            this.btnPassportInformation.TabIndex = 8;
            this.btnPassportInformation.Text = "Passport Information";
            this.btnPassportInformation.UseVisualStyleBackColor = true;
            this.btnPassportInformation.Click += new System.EventHandler(this.btnPassportInformation_Click);
            // 
            // btnUSContact
            // 
            this.btnUSContact.Location = new System.Drawing.Point(14, 398);
            this.btnUSContact.Name = "btnUSContact";
            this.btnUSContact.Size = new System.Drawing.Size(129, 26);
            this.btnUSContact.TabIndex = 9;
            this.btnUSContact.Text = "U.S.Contact";
            this.btnUSContact.UseVisualStyleBackColor = true;
            this.btnUSContact.Click += new System.EventHandler(this.btnUSContact_Click);
            // 
            // btnFamilyInformation
            // 
            this.btnFamilyInformation.Location = new System.Drawing.Point(15, 441);
            this.btnFamilyInformation.Name = "btnFamilyInformation";
            this.btnFamilyInformation.Size = new System.Drawing.Size(129, 26);
            this.btnFamilyInformation.TabIndex = 10;
            this.btnFamilyInformation.Text = "Famly Information";
            this.btnFamilyInformation.UseVisualStyleBackColor = true;
            this.btnFamilyInformation.Click += new System.EventHandler(this.btnFamilyInformation_Click);
            // 
            // btnSpose
            // 
            this.btnSpose.Location = new System.Drawing.Point(15, 484);
            this.btnSpose.Name = "btnSpose";
            this.btnSpose.Size = new System.Drawing.Size(129, 26);
            this.btnSpose.TabIndex = 11;
            this.btnSpose.Text = "Spouse";
            this.btnSpose.UseVisualStyleBackColor = true;
            this.btnSpose.Click += new System.EventHandler(this.btnSpose_Click);
            // 
            // btnWork
            // 
            this.btnWork.Location = new System.Drawing.Point(15, 527);
            this.btnWork.Name = "btnWork";
            this.btnWork.Size = new System.Drawing.Size(129, 26);
            this.btnWork.TabIndex = 12;
            this.btnWork.Text = "Work";
            this.btnWork.UseVisualStyleBackColor = true;
            this.btnWork.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnOnly
            // 
            this.btnOnly.Location = new System.Drawing.Point(15, 570);
            this.btnOnly.Name = "btnOnly";
            this.btnOnly.Size = new System.Drawing.Size(129, 26);
            this.btnOnly.TabIndex = 13;
            this.btnOnly.Text = "Security";
            this.btnOnly.UseVisualStyleBackColor = true;
            this.btnOnly.Click += new System.EventHandler(this.btnOnly_Click);
            // 
            // Identificator
            // 
            this.Identificator.Location = new System.Drawing.Point(679, 18);
            this.Identificator.Name = "Identificator";
            this.Identificator.Size = new System.Drawing.Size(109, 25);
            this.Identificator.TabIndex = 15;
            this.Identificator.Text = "Идентификатор";
            // 
            // labelName
            // 
            this.labelName.Location = new System.Drawing.Point(545, 18);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(109, 25);
            this.labelName.TabIndex = 16;
            this.labelName.Text = "Имя";
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Items.AddRange(new object[] { "0 - Пользователь не создан", "1 - Персональная информация(стр.1)", "2 - Персональная информация(стр.2)", "3 - Информация о путешествии", "4 - Компаньоны", "5 - Предыдущие путешествия", "6 - Адреса и телефоны", "7 - Информация о паспорте", "8 - Контакты в USA", "9 - Информация о семье", "10 - Информация о супруге", "11 - Работа", "12 - Жмем только \"нет\"" });
            this.comboBoxStatus.Location = new System.Drawing.Point(542, 66);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(96, 21);
            this.comboBoxStatus.TabIndex = 17;
            // 
            // btnChangeStatus
            // 
            this.btnChangeStatus.Location = new System.Drawing.Point(664, 61);
            this.btnChangeStatus.Name = "btnChangeStatus";
            this.btnChangeStatus.Size = new System.Drawing.Size(124, 28);
            this.btnChangeStatus.TabIndex = 18;
            this.btnChangeStatus.Text = "Изменить статус";
            this.btnChangeStatus.UseVisualStyleBackColor = true;
            this.btnChangeStatus.Click += new System.EventHandler(this.btnChangeStatus_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 608);
            this.Controls.Add(this.btnChangeStatus);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.Identificator);
            this.Controls.Add(this.btnOnly);
            this.Controls.Add(this.btnWork);
            this.Controls.Add(this.btnSpose);
            this.Controls.Add(this.btnFamilyInformation);
            this.Controls.Add(this.btnUSContact);
            this.Controls.Add(this.btnPassportInformation);
            this.Controls.Add(this.btnAdressAndPhone);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnCompanions);
            this.Controls.Add(this.btnTravelInfornation);
            this.Controls.Add(this.btnPersonalTwo);
            this.Controls.Add(this.btnStartAll);
            this.Controls.Add(this.btnCreateUser);
            this.Controls.Add(this.btnLoadSurvey);
            this.Name = "Form1";
            this.Text = "VisaAll";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnChangeStatus;

        private System.Windows.Forms.ComboBox comboBoxStatus;

        private System.Windows.Forms.Label labelName;

        private System.Windows.Forms.Label Identificator;

        private System.Windows.Forms.Button btnOnly;

        private System.Windows.Forms.Button btnWork;

        private System.Windows.Forms.Button btnSpose;

        private System.Windows.Forms.Button btnFamilyInformation;

        private System.Windows.Forms.Button btnUSContact;

        private System.Windows.Forms.Button btnPassportInformation;

        private System.Windows.Forms.Button btnAdressAndPhone;

        private System.Windows.Forms.Button btnPrevious;

        private System.Windows.Forms.Button btnCreateUser;

        private System.Windows.Forms.Button btnPersonalTwo;
        private System.Windows.Forms.Button btnTravelInfornation;
        private System.Windows.Forms.Button btnCompanions;

        private System.Windows.Forms.Button btnStartAll;

        private System.Windows.Forms.Button btnLoadSurvey;
        private System.Windows.Forms.OpenFileDialog openFileDialogSurvey;

        #endregion
    }
}