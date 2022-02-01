
namespace Forms
{
    partial class EditServiceRecordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditServiceRecordForm));
            this.btnEditServiceRecord = new System.Windows.Forms.Button();
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
            // btnEditServiceRecord
            // 
            this.btnEditServiceRecord.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnEditServiceRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditServiceRecord.Location = new System.Drawing.Point(0, 141);
            this.btnEditServiceRecord.Name = "btnEditServiceRecord";
            this.btnEditServiceRecord.Size = new System.Drawing.Size(304, 40);
            this.btnEditServiceRecord.TabIndex = 30;
            this.btnEditServiceRecord.Text = "Обновить запись";
            this.btnEditServiceRecord.UseVisualStyleBackColor = true;
            this.btnEditServiceRecord.Click += new System.EventHandler(this.btnEditServiceRecord_Click);
            // 
            // lbDateTime
            // 
            this.lbDateTime.AutoSize = true;
            this.lbDateTime.Location = new System.Drawing.Point(11, 105);
            this.lbDateTime.Name = "lbDateTime";
            this.lbDateTime.Size = new System.Drawing.Size(71, 15);
            this.lbDateTime.TabIndex = 29;
            this.lbDateTime.Text = "Дата/время";
            // 
            // lbServiceType
            // 
            this.lbServiceType.AutoSize = true;
            this.lbServiceType.Location = new System.Drawing.Point(11, 73);
            this.lbServiceType.Name = "lbServiceType";
            this.lbServiceType.Size = new System.Drawing.Size(67, 15);
            this.lbServiceType.TabIndex = 28;
            this.lbServiceType.Text = "Вид услуги";
            // 
            // lbClient
            // 
            this.lbClient.AutoSize = true;
            this.lbClient.Location = new System.Drawing.Point(11, 44);
            this.lbClient.Name = "lbClient";
            this.lbClient.Size = new System.Drawing.Size(46, 15);
            this.lbClient.TabIndex = 27;
            this.lbClient.Text = "Клиент";
            // 
            // lbMaster
            // 
            this.lbMaster.AutoSize = true;
            this.lbMaster.Location = new System.Drawing.Point(11, 15);
            this.lbMaster.Name = "lbMaster";
            this.lbMaster.Size = new System.Drawing.Size(48, 15);
            this.lbMaster.TabIndex = 26;
            this.lbMaster.Text = "Мастер";
            // 
            // dtpDateTime
            // 
            this.dtpDateTime.Location = new System.Drawing.Point(88, 99);
            this.dtpDateTime.Name = "dtpDateTime";
            this.dtpDateTime.Size = new System.Drawing.Size(200, 23);
            this.dtpDateTime.TabIndex = 25;
            // 
            // cbServiceType
            // 
            this.cbServiceType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbServiceType.FormattingEnabled = true;
            this.cbServiceType.Location = new System.Drawing.Point(88, 70);
            this.cbServiceType.Name = "cbServiceType";
            this.cbServiceType.Size = new System.Drawing.Size(200, 23);
            this.cbServiceType.TabIndex = 24;
            // 
            // cbClient
            // 
            this.cbClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbClient.FormattingEnabled = true;
            this.cbClient.Location = new System.Drawing.Point(88, 41);
            this.cbClient.Name = "cbClient";
            this.cbClient.Size = new System.Drawing.Size(200, 23);
            this.cbClient.TabIndex = 23;
            // 
            // cbMaster
            // 
            this.cbMaster.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbMaster.FormattingEnabled = true;
            this.cbMaster.Location = new System.Drawing.Point(88, 12);
            this.cbMaster.Name = "cbMaster";
            this.cbMaster.Size = new System.Drawing.Size(200, 23);
            this.cbMaster.TabIndex = 22;
            // 
            // EditServiceRecordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 181);
            this.Controls.Add(this.btnEditServiceRecord);
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
            this.Name = "EditServiceRecordForm";
            this.Text = "Обновление записи на услугу";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEditServiceRecord;
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