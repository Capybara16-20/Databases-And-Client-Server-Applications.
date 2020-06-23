namespace Forms
{
    partial class AddEmployeeForm
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.labelSurname = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxPatronymic = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelPatronymic = new System.Windows.Forms.Label();
            this.comboBoxSpeciality = new System.Windows.Forms.ComboBox();
            this.comboBoxExperience = new System.Windows.Forms.ComboBox();
            this.labelSpeciality = new System.Windows.Forms.Label();
            this.labelExperience = new System.Windows.Forms.Label();
            this.buttonAddEmployee = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(103, 12);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(145, 20);
            this.textBoxSurname.TabIndex = 3;
            this.textBoxSurname.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxSurname_Validating);
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new System.Drawing.Point(12, 15);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(56, 13);
            this.labelSurname.TabIndex = 4;
            this.labelSurname.Text = "Фамилия";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(103, 38);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(145, 20);
            this.textBoxName.TabIndex = 5;
            this.textBoxName.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxName_Validating);
            // 
            // textBoxPatronymic
            // 
            this.textBoxPatronymic.Location = new System.Drawing.Point(103, 64);
            this.textBoxPatronymic.Name = "textBoxPatronymic";
            this.textBoxPatronymic.Size = new System.Drawing.Size(145, 20);
            this.textBoxPatronymic.TabIndex = 6;
            this.textBoxPatronymic.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxPatronymic_Validating);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(12, 41);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(29, 13);
            this.labelName.TabIndex = 7;
            this.labelName.Text = "Имя";
            // 
            // labelPatronymic
            // 
            this.labelPatronymic.AutoSize = true;
            this.labelPatronymic.Location = new System.Drawing.Point(12, 67);
            this.labelPatronymic.Name = "labelPatronymic";
            this.labelPatronymic.Size = new System.Drawing.Size(54, 13);
            this.labelPatronymic.TabIndex = 8;
            this.labelPatronymic.Text = "Отчество";
            // 
            // comboBoxSpeciality
            // 
            this.comboBoxSpeciality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSpeciality.FormattingEnabled = true;
            this.comboBoxSpeciality.Location = new System.Drawing.Point(103, 90);
            this.comboBoxSpeciality.Name = "comboBoxSpeciality";
            this.comboBoxSpeciality.Size = new System.Drawing.Size(145, 21);
            this.comboBoxSpeciality.TabIndex = 9;
            this.comboBoxSpeciality.Validating += new System.ComponentModel.CancelEventHandler(this.comboBoxSpeciality_Validating);
            // 
            // comboBoxExperience
            // 
            this.comboBoxExperience.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxExperience.FormattingEnabled = true;
            this.comboBoxExperience.Location = new System.Drawing.Point(103, 117);
            this.comboBoxExperience.Name = "comboBoxExperience";
            this.comboBoxExperience.Size = new System.Drawing.Size(145, 21);
            this.comboBoxExperience.TabIndex = 10;
            this.comboBoxExperience.Validating += new System.ComponentModel.CancelEventHandler(this.comboBoxExperience_Validating);
            // 
            // labelSpeciality
            // 
            this.labelSpeciality.AutoSize = true;
            this.labelSpeciality.Location = new System.Drawing.Point(12, 93);
            this.labelSpeciality.Name = "labelSpeciality";
            this.labelSpeciality.Size = new System.Drawing.Size(85, 13);
            this.labelSpeciality.TabIndex = 11;
            this.labelSpeciality.Text = "Специальность";
            // 
            // labelExperience
            // 
            this.labelExperience.AutoSize = true;
            this.labelExperience.Location = new System.Drawing.Point(12, 120);
            this.labelExperience.Name = "labelExperience";
            this.labelExperience.Size = new System.Drawing.Size(33, 13);
            this.labelExperience.TabIndex = 12;
            this.labelExperience.Text = "Стаж";
            // 
            // buttonAddEmployee
            // 
            this.buttonAddEmployee.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonAddEmployee.Location = new System.Drawing.Point(15, 144);
            this.buttonAddEmployee.Name = "buttonAddEmployee";
            this.buttonAddEmployee.Size = new System.Drawing.Size(233, 27);
            this.buttonAddEmployee.TabIndex = 13;
            this.buttonAddEmployee.Text = "Добавить сотрудника";
            this.buttonAddEmployee.UseVisualStyleBackColor = false;
            this.buttonAddEmployee.Click += new System.EventHandler(this.buttonAddEmployee_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // AddEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(260, 183);
            this.Controls.Add(this.buttonAddEmployee);
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
            this.Name = "AddEmployeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxPatronymic;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelPatronymic;
        private System.Windows.Forms.ComboBox comboBoxSpeciality;
        private System.Windows.Forms.ComboBox comboBoxExperience;
        private System.Windows.Forms.Label labelSpeciality;
        private System.Windows.Forms.Label labelExperience;
        private System.Windows.Forms.Button buttonAddEmployee;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}