
namespace Forms
{
    partial class AddSessionRecordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSessionRecordForm));
            this.cbMaster = new System.Windows.Forms.ComboBox();
            this.cbClient = new System.Windows.Forms.ComboBox();
            this.cbSketch = new System.Windows.Forms.ComboBox();
            this.cbWorkType = new System.Windows.Forms.ComboBox();
            this.dtpDateTime = new System.Windows.Forms.DateTimePicker();
            this.lbMaster = new System.Windows.Forms.Label();
            this.lbClient = new System.Windows.Forms.Label();
            this.lbSketch = new System.Windows.Forms.Label();
            this.lbWorkType = new System.Windows.Forms.Label();
            this.lbDateTime = new System.Windows.Forms.Label();
            this.btnAddSessionRecord = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbMaster
            // 
            this.cbMaster.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbMaster.FormattingEnabled = true;
            this.cbMaster.Location = new System.Drawing.Point(89, 12);
            this.cbMaster.Name = "cbMaster";
            this.cbMaster.Size = new System.Drawing.Size(200, 23);
            this.cbMaster.TabIndex = 0;
            // 
            // cbClient
            // 
            this.cbClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbClient.FormattingEnabled = true;
            this.cbClient.Location = new System.Drawing.Point(89, 41);
            this.cbClient.Name = "cbClient";
            this.cbClient.Size = new System.Drawing.Size(200, 23);
            this.cbClient.TabIndex = 1;
            // 
            // cbSketch
            // 
            this.cbSketch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSketch.FormattingEnabled = true;
            this.cbSketch.Location = new System.Drawing.Point(89, 70);
            this.cbSketch.Name = "cbSketch";
            this.cbSketch.Size = new System.Drawing.Size(200, 23);
            this.cbSketch.TabIndex = 2;
            // 
            // cbWorkType
            // 
            this.cbWorkType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbWorkType.FormattingEnabled = true;
            this.cbWorkType.Location = new System.Drawing.Point(89, 99);
            this.cbWorkType.Name = "cbWorkType";
            this.cbWorkType.Size = new System.Drawing.Size(200, 23);
            this.cbWorkType.TabIndex = 3;
            // 
            // dtpDateTime
            // 
            this.dtpDateTime.Location = new System.Drawing.Point(89, 128);
            this.dtpDateTime.Name = "dtpDateTime";
            this.dtpDateTime.Size = new System.Drawing.Size(200, 23);
            this.dtpDateTime.TabIndex = 4;
            // 
            // lbMaster
            // 
            this.lbMaster.AutoSize = true;
            this.lbMaster.Location = new System.Drawing.Point(12, 15);
            this.lbMaster.Name = "lbMaster";
            this.lbMaster.Size = new System.Drawing.Size(48, 15);
            this.lbMaster.TabIndex = 5;
            this.lbMaster.Text = "Мастер";
            // 
            // lbClient
            // 
            this.lbClient.AutoSize = true;
            this.lbClient.Location = new System.Drawing.Point(12, 44);
            this.lbClient.Name = "lbClient";
            this.lbClient.Size = new System.Drawing.Size(46, 15);
            this.lbClient.TabIndex = 6;
            this.lbClient.Text = "Клиент";
            // 
            // lbSketch
            // 
            this.lbSketch.AutoSize = true;
            this.lbSketch.Location = new System.Drawing.Point(12, 73);
            this.lbSketch.Name = "lbSketch";
            this.lbSketch.Size = new System.Drawing.Size(38, 15);
            this.lbSketch.TabIndex = 7;
            this.lbSketch.Text = "Эскиз";
            // 
            // lbWorkType
            // 
            this.lbWorkType.AutoSize = true;
            this.lbWorkType.Location = new System.Drawing.Point(12, 102);
            this.lbWorkType.Name = "lbWorkType";
            this.lbWorkType.Size = new System.Drawing.Size(71, 15);
            this.lbWorkType.TabIndex = 8;
            this.lbWorkType.Text = "Вид работы";
            // 
            // lbDateTime
            // 
            this.lbDateTime.AutoSize = true;
            this.lbDateTime.Location = new System.Drawing.Point(12, 134);
            this.lbDateTime.Name = "lbDateTime";
            this.lbDateTime.Size = new System.Drawing.Size(71, 15);
            this.lbDateTime.TabIndex = 9;
            this.lbDateTime.Text = "Дата/время";
            // 
            // btnAddSessionRecord
            // 
            this.btnAddSessionRecord.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAddSessionRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSessionRecord.Location = new System.Drawing.Point(0, 171);
            this.btnAddSessionRecord.Name = "btnAddSessionRecord";
            this.btnAddSessionRecord.Size = new System.Drawing.Size(304, 40);
            this.btnAddSessionRecord.TabIndex = 10;
            this.btnAddSessionRecord.Text = "Создать запись";
            this.btnAddSessionRecord.UseVisualStyleBackColor = true;
            this.btnAddSessionRecord.Click += new System.EventHandler(this.btnAddSessionRecord_Click);
            // 
            // AddSessionRecordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 211);
            this.Controls.Add(this.btnAddSessionRecord);
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
            this.Name = "AddSessionRecordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление записи на сеанс";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbMaster;
        private System.Windows.Forms.ComboBox cbClient;
        private System.Windows.Forms.ComboBox cbSketch;
        private System.Windows.Forms.ComboBox cbWorkType;
        private System.Windows.Forms.DateTimePicker dtpDateTime;
        private System.Windows.Forms.Label lbMaster;
        private System.Windows.Forms.Label lbClient;
        private System.Windows.Forms.Label lbSketch;
        private System.Windows.Forms.Label lbWorkType;
        private System.Windows.Forms.Label lbDateTime;
        private System.Windows.Forms.Button btnAddSessionRecord;
    }
}