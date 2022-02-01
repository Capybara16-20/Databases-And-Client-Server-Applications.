
namespace Forms
{
    partial class EditSessionRecordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditSessionRecordForm));
            this.btnEditSessionRecord = new System.Windows.Forms.Button();
            this.lbDateTime = new System.Windows.Forms.Label();
            this.lbWorkType = new System.Windows.Forms.Label();
            this.lbSketch = new System.Windows.Forms.Label();
            this.lbClient = new System.Windows.Forms.Label();
            this.lbMaster = new System.Windows.Forms.Label();
            this.dtpDateTime = new System.Windows.Forms.DateTimePicker();
            this.cbWorkType = new System.Windows.Forms.ComboBox();
            this.cbSketch = new System.Windows.Forms.ComboBox();
            this.cbClient = new System.Windows.Forms.ComboBox();
            this.cbMaster = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnEditSessionRecord
            // 
            this.btnEditSessionRecord.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnEditSessionRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditSessionRecord.Location = new System.Drawing.Point(0, 171);
            this.btnEditSessionRecord.Name = "btnEditSessionRecord";
            this.btnEditSessionRecord.Size = new System.Drawing.Size(304, 40);
            this.btnEditSessionRecord.TabIndex = 21;
            this.btnEditSessionRecord.Text = "Обновить запись";
            this.btnEditSessionRecord.UseVisualStyleBackColor = true;
            this.btnEditSessionRecord.Click += new System.EventHandler(this.btnEditSessionRecord_Click);
            // 
            // lbDateTime
            // 
            this.lbDateTime.AutoSize = true;
            this.lbDateTime.Location = new System.Drawing.Point(12, 134);
            this.lbDateTime.Name = "lbDateTime";
            this.lbDateTime.Size = new System.Drawing.Size(71, 15);
            this.lbDateTime.TabIndex = 20;
            this.lbDateTime.Text = "Дата/время";
            // 
            // lbWorkType
            // 
            this.lbWorkType.AutoSize = true;
            this.lbWorkType.Location = new System.Drawing.Point(12, 102);
            this.lbWorkType.Name = "lbWorkType";
            this.lbWorkType.Size = new System.Drawing.Size(71, 15);
            this.lbWorkType.TabIndex = 19;
            this.lbWorkType.Text = "Вид работы";
            // 
            // lbSketch
            // 
            this.lbSketch.AutoSize = true;
            this.lbSketch.Location = new System.Drawing.Point(12, 73);
            this.lbSketch.Name = "lbSketch";
            this.lbSketch.Size = new System.Drawing.Size(38, 15);
            this.lbSketch.TabIndex = 18;
            this.lbSketch.Text = "Эскиз";
            // 
            // lbClient
            // 
            this.lbClient.AutoSize = true;
            this.lbClient.Location = new System.Drawing.Point(12, 44);
            this.lbClient.Name = "lbClient";
            this.lbClient.Size = new System.Drawing.Size(46, 15);
            this.lbClient.TabIndex = 17;
            this.lbClient.Text = "Клиент";
            // 
            // lbMaster
            // 
            this.lbMaster.AutoSize = true;
            this.lbMaster.Location = new System.Drawing.Point(12, 15);
            this.lbMaster.Name = "lbMaster";
            this.lbMaster.Size = new System.Drawing.Size(48, 15);
            this.lbMaster.TabIndex = 16;
            this.lbMaster.Text = "Мастер";
            // 
            // dtpDateTime
            // 
            this.dtpDateTime.Location = new System.Drawing.Point(89, 128);
            this.dtpDateTime.Name = "dtpDateTime";
            this.dtpDateTime.Size = new System.Drawing.Size(200, 23);
            this.dtpDateTime.TabIndex = 15;
            // 
            // cbWorkType
            // 
            this.cbWorkType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbWorkType.FormattingEnabled = true;
            this.cbWorkType.Location = new System.Drawing.Point(89, 99);
            this.cbWorkType.Name = "cbWorkType";
            this.cbWorkType.Size = new System.Drawing.Size(200, 23);
            this.cbWorkType.TabIndex = 14;
            // 
            // cbSketch
            // 
            this.cbSketch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSketch.FormattingEnabled = true;
            this.cbSketch.Location = new System.Drawing.Point(89, 70);
            this.cbSketch.Name = "cbSketch";
            this.cbSketch.Size = new System.Drawing.Size(200, 23);
            this.cbSketch.TabIndex = 13;
            // 
            // cbClient
            // 
            this.cbClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbClient.FormattingEnabled = true;
            this.cbClient.Location = new System.Drawing.Point(89, 41);
            this.cbClient.Name = "cbClient";
            this.cbClient.Size = new System.Drawing.Size(200, 23);
            this.cbClient.TabIndex = 12;
            // 
            // cbMaster
            // 
            this.cbMaster.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbMaster.FormattingEnabled = true;
            this.cbMaster.Location = new System.Drawing.Point(89, 12);
            this.cbMaster.Name = "cbMaster";
            this.cbMaster.Size = new System.Drawing.Size(200, 23);
            this.cbMaster.TabIndex = 11;
            // 
            // EditSessionRecordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 211);
            this.Controls.Add(this.btnEditSessionRecord);
            this.Controls.Add(this.lbDateTime);
            this.Controls.Add(this.lbWorkType);
            this.Controls.Add(this.lbSketch);
            this.Controls.Add(this.lbClient);
            this.Controls.Add(this.lbMaster);
            this.Controls.Add(this.dtpDateTime);
            this.Controls.Add(this.cbWorkType);
            this.Controls.Add(this.cbSketch);
            this.Controls.Add(this.cbClient);
            this.Controls.Add(this.cbMaster);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditSessionRecordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Обновление записи на сеанс";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEditSessionRecord;
        private System.Windows.Forms.Label lbDateTime;
        private System.Windows.Forms.Label lbWorkType;
        private System.Windows.Forms.Label lbSketch;
        private System.Windows.Forms.Label lbClient;
        private System.Windows.Forms.Label lbMaster;
        private System.Windows.Forms.DateTimePicker dtpDateTime;
        private System.Windows.Forms.ComboBox cbWorkType;
        private System.Windows.Forms.ComboBox cbSketch;
        private System.Windows.Forms.ComboBox cbClient;
        private System.Windows.Forms.ComboBox cbMaster;
    }
}