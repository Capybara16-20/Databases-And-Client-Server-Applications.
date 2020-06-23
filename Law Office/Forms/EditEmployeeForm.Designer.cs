namespace Forms
{
    partial class EditEmployeeForm
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
            this.components = new System.ComponentModel.Container();
            this.buttonEditEmployee = new System.Windows.Forms.Button();
            this.labelExperience = new System.Windows.Forms.Label();
            this.labelSpeciality = new System.Windows.Forms.Label();
            this.comboBoxExperience = new System.Windows.Forms.ComboBox();
            this.comboBoxSpeciality = new System.Windows.Forms.ComboBox();
            this.labelPatronymic = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxPatronymic = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelSurname = new System.Windows.Forms.Label();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonEditEmployee
            // 
            this.buttonEditEmployee.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonEditEmployee.Location = new System.Drawing.Point(15, 144);
            this.buttonEditEmployee.Name = "buttonEditEmployee";
            this.buttonEditEmployee.Size = new System.Drawing.Size(233, 27);
            this.buttonEditEmployee.TabIndex = 24;
            this.buttonEditEmployee.Text = "Обновить сотрудника";
            this.buttonEditEmployee.UseVisualStyleBackColor = false;
            this.buttonEditEmployee.Click += new System.EventHandler(this.buttonEditEmployee_Click);
            // 
            // labelExperience
            // 
            this.labelExperience.AutoSize = true;
            this.labelExperience.Location = new System.Drawing.Point(12, 120);
            this.labelExperience.Name = "labelExperience";
            this.labelExperience.Size = new System.Drawing.Size(33, 13);
            this.labelExperience.TabIndex = 23;
            this.labelExperience.Text = "Стаж";
            // 
            // labelSpeciality
            // 
            this.labelSpeciality.AutoSize = true;
            this.labelSpeciality.Location = new System.Drawing.Point(12, 93);
            this.labelSpeciality.Name = "labelSpeciality";
            this.labelSpeciality.Size = new System.Drawing.Size(85, 13);
            this.labelSpeciality.TabIndex = 22;
            this.labelSpeciality.Text = "Специальность";
            // 
            // comboBoxExperience
            // 
            this.comboBoxExperience.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxExperience.FormattingEnabled = true;
            this.comboBoxExperience.Location = new System.Drawing.Point(103, 117);
            this.comboBoxExperience.Name = "comboBoxExperience";
            this.comboBoxExperience.Size = new System.Drawing.Size(145, 21);
            this.comboBoxExperience.TabIndex = 21;
            this.comboBoxExperience.Validating += new System.ComponentModel.CancelEventHandler(this.comboBoxExperience_Validating);
            // 
            // comboBoxSpeciality
            // 
            this.comboBoxSpeciality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSpeciality.FormattingEnabled = true;
            this.comboBoxSpeciality.Location = new System.Drawing.Point(103, 90);
            this.comboBoxSpeciality.Name = "comboBoxSpeciality";
            this.comboBoxSpeciality.Size = new System.Drawing.Size(145, 21);
            this.comboBoxSpeciality.TabIndex = 20;
            this.comboBoxSpeciality.Validating += new System.ComponentModel.CancelEventHandler(this.comboBoxSpeciality_Validating);
            // 
            // labelPatronymic
            // 
            this.labelPatronymic.AutoSize = true;
            this.labelPatronymic.Location = new System.Drawing.Point(12, 67);
            this.labelPatronymic.Name = "labelPatronymic";
            this.labelPatronymic.Size = new System.Drawing.Size(54, 13);
            this.labelPatronymic.TabIndex = 19;
            this.labelPatronymic.Text = "Отчество";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(12, 41);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(29, 13);
            this.labelName.TabIndex = 18;
            this.labelName.Text = "Имя";
            // 
            // textBoxPatronymic
            // 
            this.textBoxPatronymic.Location = new System.Drawing.Point(103, 64);
            this.textBoxPatronymic.Name = "textBoxPatronymic";
            this.textBoxPatronymic.Size = new System.Drawing.Size(145, 20);
            this.textBoxPatronymic.TabIndex = 17;
            this.textBoxPatronymic.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxPatronymic_Validating);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(103, 38);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(145, 20);
            this.textBoxName.TabIndex = 16;
            this.textBoxName.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxName_Validating);
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new System.Drawing.Point(12, 15);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(56, 13);
            this.labelSurname.TabIndex = 15;
            this.labelSurname.Text = "Фамилия";
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(103, 12);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(145, 20);
            this.textBoxSurname.TabIndex = 14;
            this.textBoxSurname.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxSurname_Validating);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // EditEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 182);
            this.Controls.Add(this.buttonEditEmployee);
            this.Controls.Add(this.labelExperience);
            this.Controls.Add(this.labelSpeciality);
            this.Controls.Add(this.comboBoxExperience);
            this.Controls.Add(this.comboBoxSpeciality);
            this.Controls.Add(this.labelPatronymic);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxPatronymic);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelSurname);
            this.Controls.Add(this.textBoxSurname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "EditEmployeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изменение";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEditEmployee;
        private System.Windows.Forms.Label labelExperience;
        private System.Windows.Forms.Label labelSpeciality;
        private System.Windows.Forms.ComboBox comboBoxExperience;
        private System.Windows.Forms.ComboBox comboBoxSpeciality;
        private System.Windows.Forms.Label labelPatronymic;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxPatronymic;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}