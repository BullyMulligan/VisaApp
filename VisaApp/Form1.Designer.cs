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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCompanions);
            this.Controls.Add(this.btnTravelInfornation);
            this.Controls.Add(this.btnPersonalTwo);
            this.Controls.Add(this.btnStartAll);
            this.Controls.Add(this.btnCreateUser);
            this.Controls.Add(this.btnLoadSurvey);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
        }

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