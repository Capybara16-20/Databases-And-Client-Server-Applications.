
namespace DanceStudioUI
{
    partial class EditClientForm
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
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.lPhone = new System.Windows.Forms.Label();
            this.lBirthDate = new System.Windows.Forms.Label();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.btnEditClient = new System.Windows.Forms.Button();
            this.tbPatronymic = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lPatronymic = new System.Windows.Forms.Label();
            this.lName = new System.Windows.Forms.Label();
            this.lSurname = new System.Windows.Forms.Label();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(109, 125);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(200, 23);
            this.tbPhone.TabIndex = 21;
            // 
            // lPhone
            // 
            this.lPhone.AutoSize = true;
            this.lPhone.Location = new System.Drawing.Point(12, 128);
            this.lPhone.Name = "lPhone";
            this.lPhone.Size = new System.Drawing.Size(55, 15);
            this.lPhone.TabIndex = 20;
            this.lPhone.Text = "Телефон";
            // 
            // lBirthDate
            // 
            this.lBirthDate.AutoSize = true;
            this.lBirthDate.Location = new System.Drawing.Point(12, 102);
            this.lBirthDate.Name = "lBirthDate";
            this.lBirthDate.Size = new System.Drawing.Size(90, 15);
            this.lBirthDate.TabIndex = 19;
            this.lBirthDate.Text = "Дата рождения";
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.Location = new System.Drawing.Point(109, 96);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(200, 23);
            this.dtpBirthDate.TabIndex = 18;
            // 
            // btnEditClient
            // 
            this.btnEditClient.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnEditClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditClient.Location = new System.Drawing.Point(0, 161);
            this.btnEditClient.Name = "btnEditClient";
            this.btnEditClient.Size = new System.Drawing.Size(324, 30);
            this.btnEditClient.TabIndex = 17;
            this.btnEditClient.Text = "Изменить клиента";
            this.btnEditClient.UseVisualStyleBackColor = true;
            this.btnEditClient.Click += new System.EventHandler(this.btnEditClient_Click);
            // 
            // tbPatronymic
            // 
            this.tbPatronymic.Location = new System.Drawing.Point(109, 67);
            this.tbPatronymic.Name = "tbPatronymic";
            this.tbPatronymic.Size = new System.Drawing.Size(200, 23);
            this.tbPatronymic.TabIndex = 16;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(109, 38);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(200, 23);
            this.tbName.TabIndex = 15;
            // 
            // lPatronymic
            // 
            this.lPatronymic.AutoSize = true;
            this.lPatronymic.Location = new System.Drawing.Point(12, 70);
            this.lPatronymic.Name = "lPatronymic";
            this.lPatronymic.Size = new System.Drawing.Size(58, 15);
            this.lPatronymic.TabIndex = 14;
            this.lPatronymic.Text = "Отчество";
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Location = new System.Drawing.Point(12, 41);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(31, 15);
            this.lName.TabIndex = 13;
            this.lName.Text = "Имя";
            // 
            // lSurname
            // 
            this.lSurname.AutoSize = true;
            this.lSurname.Location = new System.Drawing.Point(12, 12);
            this.lSurname.Name = "lSurname";
            this.lSurname.Size = new System.Drawing.Size(58, 15);
            this.lSurname.TabIndex = 12;
            this.lSurname.Text = "Фамилия";
            // 
            // tbSurname
            // 
            this.tbSurname.Location = new System.Drawing.Point(109, 9);
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.Size = new System.Drawing.Size(200, 23);
            this.tbSurname.TabIndex = 11;
            // 
            // EditClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 191);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.lPhone);
            this.Controls.Add(this.lBirthDate);
            this.Controls.Add(this.dtpBirthDate);
            this.Controls.Add(this.btnEditClient);
            this.Controls.Add(this.tbPatronymic);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lPatronymic);
            this.Controls.Add(this.lName);
            this.Controls.Add(this.lSurname);
            this.Controls.Add(this.tbSurname);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditClientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изменение клиента";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.Label lPhone;
        private System.Windows.Forms.Label lBirthDate;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.Button btnEditClient;
        private System.Windows.Forms.TextBox tbPatronymic;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lPatronymic;
        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.Label lSurname;
        private System.Windows.Forms.TextBox tbSurname;
    }
}