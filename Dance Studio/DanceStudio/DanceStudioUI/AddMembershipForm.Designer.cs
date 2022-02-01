
namespace DanceStudioUI
{
    partial class AddMembershipForm
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
            this.lClient = new System.Windows.Forms.Label();
            this.lType = new System.Windows.Forms.Label();
            this.lIndividualCount = new System.Windows.Forms.Label();
            this.cbClient = new System.Windows.Forms.ComboBox();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.nudIndividualCount = new System.Windows.Forms.NumericUpDown();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudIndividualCount)).BeginInit();
            this.SuspendLayout();
            // 
            // lClient
            // 
            this.lClient.AutoSize = true;
            this.lClient.Location = new System.Drawing.Point(12, 9);
            this.lClient.Name = "lClient";
            this.lClient.Size = new System.Drawing.Size(46, 15);
            this.lClient.TabIndex = 1;
            this.lClient.Text = "Клиент";
            // 
            // lType
            // 
            this.lType.AutoSize = true;
            this.lType.Location = new System.Drawing.Point(12, 38);
            this.lType.Name = "lType";
            this.lType.Size = new System.Drawing.Size(96, 15);
            this.lType.TabIndex = 2;
            this.lType.Text = "Вид абонемента";
            // 
            // lIndividualCount
            // 
            this.lIndividualCount.AutoSize = true;
            this.lIndividualCount.Location = new System.Drawing.Point(12, 66);
            this.lIndividualCount.Name = "lIndividualCount";
            this.lIndividualCount.Size = new System.Drawing.Size(144, 15);
            this.lIndividualCount.TabIndex = 3;
            this.lIndividualCount.Text = "Количество инд. занятий";
            // 
            // cbClient
            // 
            this.cbClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbClient.FormattingEnabled = true;
            this.cbClient.Location = new System.Drawing.Point(162, 6);
            this.cbClient.Name = "cbClient";
            this.cbClient.Size = new System.Drawing.Size(190, 23);
            this.cbClient.TabIndex = 4;
            // 
            // cbType
            // 
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(162, 35);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(190, 23);
            this.cbType.TabIndex = 5;
            // 
            // nudIndividualCount
            // 
            this.nudIndividualCount.Location = new System.Drawing.Point(162, 64);
            this.nudIndividualCount.Name = "nudIndividualCount";
            this.nudIndividualCount.Size = new System.Drawing.Size(43, 23);
            this.nudIndividualCount.TabIndex = 6;
            // 
            // btnAdd
            // 
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(0, 101);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(364, 30);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // AddMembershipForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 131);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.nudIndividualCount);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.cbClient);
            this.Controls.Add(this.lIndividualCount);
            this.Controls.Add(this.lType);
            this.Controls.Add(this.lClient);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddMembershipForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить абонемент";
            ((System.ComponentModel.ISupportInitialize)(this.nudIndividualCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lClient;
        private System.Windows.Forms.Label lType;
        private System.Windows.Forms.Label lIndividualCount;
        private System.Windows.Forms.ComboBox cbClient;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.NumericUpDown nudIndividualCount;
        private System.Windows.Forms.Button btnAdd;
    }
}