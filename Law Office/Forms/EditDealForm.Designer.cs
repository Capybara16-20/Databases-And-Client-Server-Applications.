namespace Forms
{
    partial class EditDealForm
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
            this.buttonAddEmployee = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.comboBoxStage = new System.Windows.Forms.ComboBox();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.labelStage = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAddEmployee
            // 
            this.buttonAddEmployee.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonAddEmployee.Location = new System.Drawing.Point(18, 66);
            this.buttonAddEmployee.Name = "buttonAddEmployee";
            this.buttonAddEmployee.Size = new System.Drawing.Size(431, 27);
            this.buttonAddEmployee.TabIndex = 30;
            this.buttonAddEmployee.Text = "Обновить дело";
            this.buttonAddEmployee.UseVisualStyleBackColor = false;
            this.buttonAddEmployee.Click += new System.EventHandler(this.buttonEditDeal_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // comboBoxStage
            // 
            this.comboBoxStage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStage.FormattingEnabled = true;
            this.comboBoxStage.Location = new System.Drawing.Point(153, 12);
            this.comboBoxStage.Name = "comboBoxStage";
            this.comboBoxStage.Size = new System.Drawing.Size(295, 21);
            this.comboBoxStage.TabIndex = 31;
            this.comboBoxStage.Validating += new System.ComponentModel.CancelEventHandler(this.comboBox1_Validating);
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(153, 39);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(295, 21);
            this.comboBoxStatus.TabIndex = 32;
            this.comboBoxStatus.Validating += new System.ComponentModel.CancelEventHandler(this.comboBoxStatus_Validating);
            // 
            // labelStage
            // 
            this.labelStage.AutoSize = true;
            this.labelStage.Location = new System.Drawing.Point(15, 15);
            this.labelStage.Name = "labelStage";
            this.labelStage.Size = new System.Drawing.Size(70, 13);
            this.labelStage.TabIndex = 33;
            this.labelStage.Text = "Стадия дела";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(15, 42);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(106, 13);
            this.labelStatus.TabIndex = 34;
            this.labelStatus.Text = "Статус завершения";
            // 
            // EditDealForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 103);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.labelStage);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.comboBoxStage);
            this.Controls.Add(this.buttonAddEmployee);
            this.Name = "EditDealForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изменение";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddEmployee;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelStage;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.ComboBox comboBoxStage;
    }
}