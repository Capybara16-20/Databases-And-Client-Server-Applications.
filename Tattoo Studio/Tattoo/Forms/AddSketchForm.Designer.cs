﻿
namespace Forms
{
    partial class AddSketchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSketchForm));
            this.btnAddSketch = new System.Windows.Forms.Button();
            this.cbStyle = new System.Windows.Forms.ComboBox();
            this.lbStyle = new System.Windows.Forms.Label();
            this.cbSize = new System.Windows.Forms.ComboBox();
            this.lbSize = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddSketch
            // 
            this.btnAddSketch.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAddSketch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSketch.Location = new System.Drawing.Point(0, 81);
            this.btnAddSketch.Name = "btnAddSketch";
            this.btnAddSketch.Size = new System.Drawing.Size(234, 40);
            this.btnAddSketch.TabIndex = 0;
            this.btnAddSketch.Text = "Создать эскиз";
            this.btnAddSketch.UseVisualStyleBackColor = true;
            this.btnAddSketch.Click += new System.EventHandler(this.btnAddSketch_Click);
            // 
            // cbStyle
            // 
            this.cbStyle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbStyle.FormattingEnabled = true;
            this.cbStyle.Location = new System.Drawing.Point(65, 12);
            this.cbStyle.Name = "cbStyle";
            this.cbStyle.Size = new System.Drawing.Size(150, 23);
            this.cbStyle.TabIndex = 1;
            // 
            // lbStyle
            // 
            this.lbStyle.AutoSize = true;
            this.lbStyle.Location = new System.Drawing.Point(12, 15);
            this.lbStyle.Name = "lbStyle";
            this.lbStyle.Size = new System.Drawing.Size(40, 15);
            this.lbStyle.TabIndex = 2;
            this.lbStyle.Text = "Стиль";
            // 
            // cbSize
            // 
            this.cbSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSize.FormattingEnabled = true;
            this.cbSize.Location = new System.Drawing.Point(65, 41);
            this.cbSize.Name = "cbSize";
            this.cbSize.Size = new System.Drawing.Size(150, 23);
            this.cbSize.TabIndex = 3;
            // 
            // lbSize
            // 
            this.lbSize.AutoSize = true;
            this.lbSize.Location = new System.Drawing.Point(12, 44);
            this.lbSize.Name = "lbSize";
            this.lbSize.Size = new System.Drawing.Size(47, 15);
            this.lbSize.TabIndex = 4;
            this.lbSize.Text = "Размер";
            // 
            // AddSketchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 121);
            this.Controls.Add(this.lbSize);
            this.Controls.Add(this.cbSize);
            this.Controls.Add(this.lbStyle);
            this.Controls.Add(this.cbStyle);
            this.Controls.Add(this.btnAddSketch);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddSketchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Создание эскиза";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddSketch;
        private System.Windows.Forms.ComboBox cbStyle;
        private System.Windows.Forms.Label lbStyle;
        private System.Windows.Forms.ComboBox cbSize;
        private System.Windows.Forms.Label lbSize;
    }
}