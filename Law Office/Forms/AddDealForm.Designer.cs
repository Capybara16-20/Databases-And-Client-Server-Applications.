namespace Forms
{
    partial class AddDealForm
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
            this.labelEmployee = new System.Windows.Forms.Label();
            this.labelCustomer = new System.Windows.Forms.Label();
            this.comboBoxEmployee = new System.Windows.Forms.ComboBox();
            this.comboBoxCustomer = new System.Windows.Forms.ComboBox();
            this.labelLevel = new System.Windows.Forms.Label();
            this.comboBoxLevel = new System.Windows.Forms.ComboBox();
            this.comboBoxAgreement = new System.Windows.Forms.ComboBox();
            this.labelAgreement = new System.Windows.Forms.Label();
            this.buttonAddEmployee = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // labelEmployee
            // 
            this.labelEmployee.AutoSize = true;
            this.labelEmployee.Location = new System.Drawing.Point(12, 42);
            this.labelEmployee.Name = "labelEmployee";
            this.labelEmployee.Size = new System.Drawing.Size(60, 13);
            this.labelEmployee.TabIndex = 16;
            this.labelEmployee.Text = "Сотрудник";
            // 
            // labelCustomer
            // 
            this.labelCustomer.AutoSize = true;
            this.labelCustomer.Location = new System.Drawing.Point(12, 15);
            this.labelCustomer.Name = "labelCustomer";
            this.labelCustomer.Size = new System.Drawing.Size(43, 13);
            this.labelCustomer.TabIndex = 15;
            this.labelCustomer.Text = "Клиент";
            // 
            // comboBoxEmployee
            // 
            this.comboBoxEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEmployee.FormattingEnabled = true;
            this.comboBoxEmployee.Location = new System.Drawing.Point(151, 39);
            this.comboBoxEmployee.Name = "comboBoxEmployee";
            this.comboBoxEmployee.Size = new System.Drawing.Size(295, 21);
            this.comboBoxEmployee.TabIndex = 14;
            this.comboBoxEmployee.Validating += new System.ComponentModel.CancelEventHandler(this.comboBoxEmployee_Validating);
            // 
            // comboBoxCustomer
            // 
            this.comboBoxCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCustomer.FormattingEnabled = true;
            this.comboBoxCustomer.Location = new System.Drawing.Point(151, 12);
            this.comboBoxCustomer.Name = "comboBoxCustomer";
            this.comboBoxCustomer.Size = new System.Drawing.Size(295, 21);
            this.comboBoxCustomer.TabIndex = 13;
            this.comboBoxCustomer.Validating += new System.ComponentModel.CancelEventHandler(this.comboBoxCustomer_Validating);
            // 
            // labelLevel
            // 
            this.labelLevel.AutoSize = true;
            this.labelLevel.Location = new System.Drawing.Point(12, 69);
            this.labelLevel.Name = "labelLevel";
            this.labelLevel.Size = new System.Drawing.Size(133, 13);
            this.labelLevel.TabIndex = 17;
            this.labelLevel.Text = "Уровень безнадёжности";
            // 
            // comboBoxLevel
            // 
            this.comboBoxLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLevel.FormattingEnabled = true;
            this.comboBoxLevel.Location = new System.Drawing.Point(151, 66);
            this.comboBoxLevel.Name = "comboBoxLevel";
            this.comboBoxLevel.Size = new System.Drawing.Size(295, 21);
            this.comboBoxLevel.TabIndex = 18;
            this.comboBoxLevel.Validating += new System.ComponentModel.CancelEventHandler(this.comboBoxLevel_Validating);
            // 
            // comboBoxAgreement
            // 
            this.comboBoxAgreement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAgreement.FormattingEnabled = true;
            this.comboBoxAgreement.Location = new System.Drawing.Point(151, 93);
            this.comboBoxAgreement.Name = "comboBoxAgreement";
            this.comboBoxAgreement.Size = new System.Drawing.Size(295, 21);
            this.comboBoxAgreement.TabIndex = 19;
            this.comboBoxAgreement.Validating += new System.ComponentModel.CancelEventHandler(this.comboBoxAgreement_Validating);
            // 
            // labelAgreement
            // 
            this.labelAgreement.AutoSize = true;
            this.labelAgreement.Location = new System.Drawing.Point(12, 96);
            this.labelAgreement.Name = "labelAgreement";
            this.labelAgreement.Size = new System.Drawing.Size(90, 13);
            this.labelAgreement.TabIndex = 20;
            this.labelAgreement.Text = "Вид соглашения";
            // 
            // buttonAddEmployee
            // 
            this.buttonAddEmployee.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonAddEmployee.Location = new System.Drawing.Point(15, 120);
            this.buttonAddEmployee.Name = "buttonAddEmployee";
            this.buttonAddEmployee.Size = new System.Drawing.Size(431, 27);
            this.buttonAddEmployee.TabIndex = 21;
            this.buttonAddEmployee.Text = "Добавить дело";
            this.buttonAddEmployee.UseVisualStyleBackColor = false;
            this.buttonAddEmployee.Click += new System.EventHandler(this.buttonAddEmployee_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // AddDealForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(458, 155);
            this.Controls.Add(this.buttonAddEmployee);
            this.Controls.Add(this.labelAgreement);
            this.Controls.Add(this.comboBoxAgreement);
            this.Controls.Add(this.comboBoxLevel);
            this.Controls.Add(this.labelLevel);
            this.Controls.Add(this.labelEmployee);
            this.Controls.Add(this.labelCustomer);
            this.Controls.Add(this.comboBoxEmployee);
            this.Controls.Add(this.comboBoxCustomer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AddDealForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEmployee;
        private System.Windows.Forms.Label labelCustomer;
        private System.Windows.Forms.ComboBox comboBoxEmployee;
        private System.Windows.Forms.ComboBox comboBoxCustomer;
        private System.Windows.Forms.Label labelLevel;
        private System.Windows.Forms.ComboBox comboBoxLevel;
        private System.Windows.Forms.ComboBox comboBoxAgreement;
        private System.Windows.Forms.Label labelAgreement;
        private System.Windows.Forms.Button buttonAddEmployee;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}