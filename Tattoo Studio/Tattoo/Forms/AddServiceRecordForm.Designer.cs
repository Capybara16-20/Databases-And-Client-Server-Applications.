
namespace Forms
{
    partial class AddServiceRecordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddServiceRecordForm));
            this.btnAddServiceRecord = new System.Windows.Forms.Button();
            this.lbDateTime = new System.Windows.Forms.Label();
            this.lbServiceType = new System.Windows.Forms.Label();
            this.lbClient = new System.Windows.Forms.Label();
            this.lbMaster = new System.Windows.Forms.Label();
            this.dtpDateTime = new System.Windows.Forms.DateTimePicker();
            this.cbServiceType = new System.Windows.Forms.ComboBox();
            this.cbClient = new System.Windows.Forms.ComboBox();
            this.cbMaster = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnAddServiceRecord
            // 
            this.btnAddServiceRecord.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAddServiceRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddServiceRecord.Location = new System.Drawing.Point(0, 141);
            this.btnAddServiceRecord.Name = "btnAddServiceRecord";
            this.btnAddServiceRecord.Size = new System.Drawing.Size(304, 40);
            this.btnAddServiceRecord.TabIndex = 21;
            this.btnAddServiceRecord.Text = "Создать запись";
            this.btnAddServiceRecord.UseVisualStyleBackColor = true;
            this.btnAddServiceRecord.Click += new System.EventHandler(this.btnAddServiceRecord_Click);
            // 
            // lbDateTime
            // 
            this.lbDateTime.AutoSize = true;
            this.lbDateTime.Location = new System.Drawing.Point(11, 105);
            this.lbDateTime.Name = "lbDateTime";
            this.lbDateTime.Size = new System.Drawing.Size(71, 15);
            this.lbDateTime.TabIndex = 20;
            this.lbDateTime.Text = "Дата/время";
            // 
            // lbServiceType
            // 
            this.lbServiceType.AutoSize = true;
            this.lbServiceType.Location = new System.Drawing.Point(11, 81);
            this.lbServiceType.Name = "lbServiceType";
            this.lbServiceType.Size = new System.Drawing.Size(67, 15);
            this.lbServiceType.TabIndex = 18;
            this.lbServiceType.Text = "Вид услуги";
            // 
            // lbClient
            // 
            this.lbClient.AutoSize = true;
            this.lbClient.Location = new System.Drawing.Point(11, 52);
            this.lbClient.Name = "lbClient";
            this.lbClient.Size = new System.Drawing.Size(46, 15);
            this.lbClient.TabIndex = 17;
            this.lbClient.Text = "Клиент";
            // 
            // lbMaster
            // 
            this.lbMaster.AutoSize = true;
            this.lbMaster.Location = new System.Drawing.Point(11, 23);
            this.lbMaster.Name = "lbMaster";
            this.lbMaster.Size = new System.Drawing.Size(48, 15);
            this.lbMaster.TabIndex = 16;
            this.lbMaster.Text = "Мастер";
            // 
            // dtpDateTime
            // 
            this.dtpDateTime.Location = new System.Drawing.Point(88, 99);
            this.dtpDateTime.Name = "dtpDateTime";
            this.dtpDateTime.Size = new System.Drawing.Size(200, 23);
            this.dtpDateTime.TabIndex = 15;
            // 
            // cbServiceType
            // 
            this.cbServiceType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbServiceType.FormattingEnabled = true;
            this.cbServiceType.Location = new System.Drawing.Point(88, 70);
            this.cbServiceType.Name = "cbServiceType";
            this.cbServiceType.Size = new System.Drawing.Size(200, 23);
            this.cbServiceType.TabIndex = 13;
            // 
            // cbClient
            // 
            this.cbClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbClient.FormattingEnabled = true;
            this.cbClient.Location = new System.Drawing.Point(88, 41);
            this.cbClient.Name = "cbClient";
            this.cbClient.Size = new System.Drawing.Size(200, 23);
            this.cbClient.TabIndex = 12;
            // 
            // cbMaster
            // 
            this.cbMaster.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbMaster.FormattingEnabled = true;
            this.cbMaster.Location = new System.Drawing.Point(88, 12);
            this.cbMaster.Name = "cbMaster";
            this.cbMaster.Size = new System.Drawing.Size(200, 23);
            this.cbMaster.TabIndex = 11;
            // 
            // AddServiceRecordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 181);
            this.Controls.Add(this.btnAddServiceRecord);
            this.Controls.Add(this.lbDateTime);
            this.Controls.Add(this.lbServiceType);
            this.Controls.Add(this.lbClient);
            this.Controls.Add(this.lbMaster);
            this.Controls.Add(this.dtpDateTime);
            this.Controls.Add(this.cbServiceType);
            this.Controls.Add(this.cbClient);
            this.Controls.Add(this.cbMaster);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddServiceRecordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление записи на услугу";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddServiceRecord;
        private System.Windows.Forms.Label lbDateTime;
        private System.Windows.Forms.Label lbServiceType;
        private System.Windows.Forms.Label lbClient;
        private System.Windows.Forms.Label lbMaster;
        private System.Windows.Forms.DateTimePicker dtpDateTime;
        private System.Windows.Forms.ComboBox cbServiceType;
        private System.Windows.Forms.ComboBox cbClient;
        private System.Windows.Forms.ComboBox cbMaster;
    }
}