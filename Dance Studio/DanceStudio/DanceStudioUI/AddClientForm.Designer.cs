
namespace DanceStudioUI
{
    partial class AddClientForm
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
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.lSurname = new System.Windows.Forms.Label();
            this.lName = new System.Windows.Forms.Label();
            this.lPatronymic = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbPatronymic = new System.Windows.Forms.TextBox();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.lBirthDate = new System.Windows.Forms.Label();
            this.lPhone = new System.Windows.Forms.Label();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbSurname
            // 
            this.tbSurname.Location = new System.Drawing.Point(109, 9);
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.Size = new System.Drawing.Size(200, 23);
            this.tbSurname.TabIndex = 0;
            // 
            // lSurname
            // 
            this.lSurname.AutoSize = true;
            this.lSurname.Location = new System.Drawing.Point(12, 12);
            this.lSurname.Name = "lSurname";
            this.lSurname.Size = new System.Drawing.Size(58, 15);
            this.lSurname.TabIndex = 1;
            this.lSurname.Text = "Фамилия";
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Location = new System.Drawing.Point(12, 41);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(31, 15);
            this.lName.TabIndex = 2;
            this.lName.Text = "Имя";
            // 
            // lPatronymic
            // 
            this.lPatronymic.AutoSize = true;
            this.lPatronymic.Location = new System.Drawing.Point(12, 70);
            this.lPatronymic.Name = "lPatronymic";
            this.lPatronymic.Size = new System.Drawing.Size(58, 15);
            this.lPatronymic.TabIndex = 3;
            this.lPatronymic.Text = "Отчество";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(109, 38);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(200, 23);
            this.tbName.TabIndex = 4;
            // 
            // tbPatronymic
            // 
            this.tbPatronymic.Location = new System.Drawing.Point(109, 67);
            this.tbPatronymic.Name = "tbPatronymic";
            this.tbPatronymic.Size = new System.Drawing.Size(200, 23);
            this.tbPatronymic.TabIndex = 5;
            // 
            // btnAddClient
            // 
            this.btnAddClient.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAddClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddClient.Location = new System.Drawing.Point(0, 161);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(324, 30);
            this.btnAddClient.TabIndex = 6;
            this.btnAddClient.Text = "Добавить клиента";
            this.btnAddClient.UseVisualStyleBackColor = true;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.Location = new System.Drawing.Point(109, 96);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(200, 23);
            this.dtpBirthDate.TabIndex = 7;
            // 
            // lBirthDate
            // 
            this.lBirthDate.AutoSize = true;
            this.lBirthDate.Location = new System.Drawing.Point(12, 102);
            this.lBirthDate.Name = "lBirthDate";
            this.lBirthDate.Size = new System.Drawing.Size(90, 15);
            this.lBirthDate.TabIndex = 8;
            this.lBirthDate.Text = "Дата рождения";
            // 
            // lPhone
            // 
            this.lPhone.AutoSize = true;
            this.lPhone.Location = new System.Drawing.Point(12, 128);
            this.lPhone.Name = "lPhone";
            this.lPhone.Size = new System.Drawing.Size(55, 15);
            this.lPhone.TabIndex = 9;
            this.lPhone.Text = "Телефон";
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(109, 125);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(200, 23);
            this.tbPhone.TabIndex = 10;
            // 
            // AddClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 191);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.lPhone);
            this.Controls.Add(this.lBirthDate);
            this.Controls.Add(this.dtpBirthDate);
            this.Controls.Add(this.btnAddClient);
            this.Controls.Add(this.tbPatronymic);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lPatronymic);
            this.Controls.Add(this.lName);
            this.Controls.Add(this.lSurname);
            this.Controls.Add(this.tbSurname);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddClientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление клиента";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbSurname;
        private System.Windows.Forms.Label lSurname;
        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.Label lPatronymic;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbPatronymic;
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.Label lBirthDate;
        private System.Windows.Forms.Label lPhone;
        private System.Windows.Forms.TextBox tbPhone;
    }
}