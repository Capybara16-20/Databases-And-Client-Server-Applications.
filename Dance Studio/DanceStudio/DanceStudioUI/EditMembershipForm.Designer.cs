﻿
namespace DanceStudioUI
{
    partial class EditMembershipForm
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
            this.btnEdit = new System.Windows.Forms.Button();
            this.nudIndividualCount = new System.Windows.Forms.NumericUpDown();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.cbClient = new System.Windows.Forms.ComboBox();
            this.lIndividualCount = new System.Windows.Forms.Label();
            this.lType = new System.Windows.Forms.Label();
            this.lClient = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudIndividualCount)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEdit
            // 
            this.btnEdit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Location = new System.Drawing.Point(0, 101);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(364, 30);
            this.btnEdit.TabIndex = 14;
            this.btnEdit.Text = "Изменить";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // nudIndividualCount
            // 
            this.nudIndividualCount.Location = new System.Drawing.Point(162, 61);
            this.nudIndividualCount.Name = "nudIndividualCount";
            this.nudIndividualCount.Size = new System.Drawing.Size(43, 23);
            this.nudIndividualCount.TabIndex = 13;
            // 
            // cbType
            // 
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(162, 32);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(190, 23);
            this.cbType.TabIndex = 12;
            // 
            // cbClient
            // 
            this.cbClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbClient.FormattingEnabled = true;
            this.cbClient.Location = new System.Drawing.Point(162, 3);
            this.cbClient.Name = "cbClient";
            this.cbClient.Size = new System.Drawing.Size(190, 23);
            this.cbClient.TabIndex = 11;
            // 
            // lIndividualCount
            // 
            this.lIndividualCount.AutoSize = true;
            this.lIndividualCount.Location = new System.Drawing.Point(12, 63);
            this.lIndividualCount.Name = "lIndividualCount";
            this.lIndividualCount.Size = new System.Drawing.Size(144, 15);
            this.lIndividualCount.TabIndex = 10;
            this.lIndividualCount.Text = "Количество инд. занятий";
            // 
            // lType
            // 
            this.lType.AutoSize = true;
            this.lType.Location = new System.Drawing.Point(12, 35);
            this.lType.Name = "lType";
            this.lType.Size = new System.Drawing.Size(96, 15);
            this.lType.TabIndex = 9;
            this.lType.Text = "Вид абонемента";
            // 
            // lClient
            // 
            this.lClient.AutoSize = true;
            this.lClient.Location = new System.Drawing.Point(12, 6);
            this.lClient.Name = "lClient";
            this.lClient.Size = new System.Drawing.Size(46, 15);
            this.lClient.TabIndex = 8;
            this.lClient.Text = "Клиент";
            // 
            // EditMembershipForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 131);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.nudIndividualCount);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.cbClient);
            this.Controls.Add(this.lIndividualCount);
            this.Controls.Add(this.lType);
            this.Controls.Add(this.lClient);
            this.Name = "EditMembershipForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditMembershipForm";
            ((System.ComponentModel.ISupportInitialize)(this.nudIndividualCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.NumericUpDown nudIndividualCount;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.ComboBox cbClient;
        private System.Windows.Forms.Label lIndividualCount;
        private System.Windows.Forms.Label lType;
        private System.Windows.Forms.Label lClient;
    }
}