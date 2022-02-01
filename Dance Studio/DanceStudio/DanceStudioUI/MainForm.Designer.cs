
namespace DanceStudioUI
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabClients = new System.Windows.Forms.TabPage();
            this.tlpClients = new System.Windows.Forms.TableLayoutPanel();
            this.pClients = new System.Windows.Forms.Panel();
            this.btnEditClient = new System.Windows.Forms.Button();
            this.btnRemoveClient = new System.Windows.Forms.Button();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.dgvClients = new System.Windows.Forms.DataGridView();
            this.tabMemberships = new System.Windows.Forms.TabPage();
            this.tlpMemberships = new System.Windows.Forms.TableLayoutPanel();
            this.pMemberships = new System.Windows.Forms.Panel();
            this.btnRemoveMembership = new System.Windows.Forms.Button();
            this.btnEditMembership = new System.Windows.Forms.Button();
            this.btnAddMembership = new System.Windows.Forms.Button();
            this.dgvMemberships = new System.Windows.Forms.DataGridView();
            this.tabGroups = new System.Windows.Forms.TabPage();
            this.dgvGroups = new System.Windows.Forms.DataGridView();
            this.tabControl.SuspendLayout();
            this.tabClients.SuspendLayout();
            this.tlpClients.SuspendLayout();
            this.pClients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).BeginInit();
            this.tabMemberships.SuspendLayout();
            this.tlpMemberships.SuspendLayout();
            this.pMemberships.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemberships)).BeginInit();
            this.tabGroups.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroups)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabClients);
            this.tabControl.Controls.Add(this.tabMemberships);
            this.tabControl.Controls.Add(this.tabGroups);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(784, 461);
            this.tabControl.TabIndex = 0;
            // 
            // tabClients
            // 
            this.tabClients.Controls.Add(this.tlpClients);
            this.tabClients.Location = new System.Drawing.Point(4, 24);
            this.tabClients.Name = "tabClients";
            this.tabClients.Padding = new System.Windows.Forms.Padding(3);
            this.tabClients.Size = new System.Drawing.Size(776, 433);
            this.tabClients.TabIndex = 0;
            this.tabClients.Text = "Клиенты";
            this.tabClients.UseVisualStyleBackColor = true;
            // 
            // tlpClients
            // 
            this.tlpClients.ColumnCount = 1;
            this.tlpClients.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpClients.Controls.Add(this.pClients, 0, 0);
            this.tlpClients.Controls.Add(this.dgvClients, 0, 1);
            this.tlpClients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpClients.Location = new System.Drawing.Point(3, 3);
            this.tlpClients.Name = "tlpClients";
            this.tlpClients.RowCount = 2;
            this.tlpClients.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpClients.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpClients.Size = new System.Drawing.Size(770, 427);
            this.tlpClients.TabIndex = 1;
            // 
            // pClients
            // 
            this.pClients.Controls.Add(this.btnEditClient);
            this.pClients.Controls.Add(this.btnRemoveClient);
            this.pClients.Controls.Add(this.btnAddClient);
            this.pClients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pClients.Location = new System.Drawing.Point(3, 3);
            this.pClients.Name = "pClients";
            this.pClients.Size = new System.Drawing.Size(764, 34);
            this.pClients.TabIndex = 0;
            // 
            // btnEditClient
            // 
            this.btnEditClient.BackColor = System.Drawing.SystemColors.Control;
            this.btnEditClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditClient.Location = new System.Drawing.Point(120, 5);
            this.btnEditClient.Name = "btnEditClient";
            this.btnEditClient.Size = new System.Drawing.Size(100, 25);
            this.btnEditClient.TabIndex = 2;
            this.btnEditClient.Text = "Изменить";
            this.btnEditClient.UseVisualStyleBackColor = false;
            this.btnEditClient.Click += new System.EventHandler(this.btnEditClient_Click);
            // 
            // btnRemoveClient
            // 
            this.btnRemoveClient.BackColor = System.Drawing.SystemColors.Control;
            this.btnRemoveClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveClient.Location = new System.Drawing.Point(230, 5);
            this.btnRemoveClient.Name = "btnRemoveClient";
            this.btnRemoveClient.Size = new System.Drawing.Size(100, 25);
            this.btnRemoveClient.TabIndex = 1;
            this.btnRemoveClient.Text = "Удалить";
            this.btnRemoveClient.UseVisualStyleBackColor = false;
            this.btnRemoveClient.Click += new System.EventHandler(this.btnRemoveClient_Click);
            // 
            // btnAddClient
            // 
            this.btnAddClient.BackColor = System.Drawing.SystemColors.Control;
            this.btnAddClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddClient.Location = new System.Drawing.Point(10, 5);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(100, 25);
            this.btnAddClient.TabIndex = 0;
            this.btnAddClient.Text = "Добавить";
            this.btnAddClient.UseVisualStyleBackColor = false;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // dgvClients
            // 
            this.dgvClients.AllowUserToAddRows = false;
            this.dgvClients.AllowUserToDeleteRows = false;
            this.dgvClients.AllowUserToResizeColumns = false;
            this.dgvClients.AllowUserToResizeRows = false;
            this.dgvClients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvClients.Location = new System.Drawing.Point(3, 43);
            this.dgvClients.Name = "dgvClients";
            this.dgvClients.RowTemplate.Height = 25;
            this.dgvClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClients.Size = new System.Drawing.Size(764, 381);
            this.dgvClients.TabIndex = 1;
            // 
            // tabMemberships
            // 
            this.tabMemberships.Controls.Add(this.tlpMemberships);
            this.tabMemberships.Location = new System.Drawing.Point(4, 24);
            this.tabMemberships.Name = "tabMemberships";
            this.tabMemberships.Padding = new System.Windows.Forms.Padding(3);
            this.tabMemberships.Size = new System.Drawing.Size(776, 433);
            this.tabMemberships.TabIndex = 1;
            this.tabMemberships.Text = "Абонементы";
            this.tabMemberships.UseVisualStyleBackColor = true;
            // 
            // tlpMemberships
            // 
            this.tlpMemberships.ColumnCount = 1;
            this.tlpMemberships.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMemberships.Controls.Add(this.pMemberships, 0, 0);
            this.tlpMemberships.Controls.Add(this.dgvMemberships, 0, 1);
            this.tlpMemberships.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMemberships.Location = new System.Drawing.Point(3, 3);
            this.tlpMemberships.Name = "tlpMemberships";
            this.tlpMemberships.RowCount = 2;
            this.tlpMemberships.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpMemberships.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMemberships.Size = new System.Drawing.Size(770, 427);
            this.tlpMemberships.TabIndex = 0;
            // 
            // pMemberships
            // 
            this.pMemberships.Controls.Add(this.btnRemoveMembership);
            this.pMemberships.Controls.Add(this.btnEditMembership);
            this.pMemberships.Controls.Add(this.btnAddMembership);
            this.pMemberships.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pMemberships.Location = new System.Drawing.Point(3, 3);
            this.pMemberships.Name = "pMemberships";
            this.pMemberships.Size = new System.Drawing.Size(764, 34);
            this.pMemberships.TabIndex = 0;
            // 
            // btnRemoveMembership
            // 
            this.btnRemoveMembership.BackColor = System.Drawing.SystemColors.Control;
            this.btnRemoveMembership.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveMembership.Location = new System.Drawing.Point(230, 5);
            this.btnRemoveMembership.Name = "btnRemoveMembership";
            this.btnRemoveMembership.Size = new System.Drawing.Size(100, 25);
            this.btnRemoveMembership.TabIndex = 2;
            this.btnRemoveMembership.Text = "Удалить";
            this.btnRemoveMembership.UseVisualStyleBackColor = false;
            this.btnRemoveMembership.Click += new System.EventHandler(this.btnRemoveMembership_Click);
            // 
            // btnEditMembership
            // 
            this.btnEditMembership.BackColor = System.Drawing.SystemColors.Control;
            this.btnEditMembership.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditMembership.Location = new System.Drawing.Point(120, 5);
            this.btnEditMembership.Name = "btnEditMembership";
            this.btnEditMembership.Size = new System.Drawing.Size(100, 25);
            this.btnEditMembership.TabIndex = 1;
            this.btnEditMembership.Text = "Изменить";
            this.btnEditMembership.UseVisualStyleBackColor = false;
            this.btnEditMembership.Click += new System.EventHandler(this.btnEditMembership_Click);
            // 
            // btnAddMembership
            // 
            this.btnAddMembership.BackColor = System.Drawing.SystemColors.Control;
            this.btnAddMembership.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMembership.Location = new System.Drawing.Point(10, 5);
            this.btnAddMembership.Name = "btnAddMembership";
            this.btnAddMembership.Size = new System.Drawing.Size(100, 25);
            this.btnAddMembership.TabIndex = 0;
            this.btnAddMembership.Text = "Добавить";
            this.btnAddMembership.UseVisualStyleBackColor = false;
            this.btnAddMembership.Click += new System.EventHandler(this.btnAddMembership_Click);
            // 
            // dgvMemberships
            // 
            this.dgvMemberships.AllowUserToAddRows = false;
            this.dgvMemberships.AllowUserToDeleteRows = false;
            this.dgvMemberships.AllowUserToResizeColumns = false;
            this.dgvMemberships.AllowUserToResizeRows = false;
            this.dgvMemberships.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMemberships.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMemberships.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMemberships.Location = new System.Drawing.Point(3, 43);
            this.dgvMemberships.Name = "dgvMemberships";
            this.dgvMemberships.RowTemplate.Height = 25;
            this.dgvMemberships.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMemberships.Size = new System.Drawing.Size(764, 381);
            this.dgvMemberships.TabIndex = 1;
            // 
            // tabGroups
            // 
            this.tabGroups.Controls.Add(this.dgvGroups);
            this.tabGroups.Location = new System.Drawing.Point(4, 24);
            this.tabGroups.Name = "tabGroups";
            this.tabGroups.Size = new System.Drawing.Size(776, 433);
            this.tabGroups.TabIndex = 2;
            this.tabGroups.Text = "Группы";
            this.tabGroups.UseVisualStyleBackColor = true;
            // 
            // dgvGroups
            // 
            this.dgvGroups.AllowUserToAddRows = false;
            this.dgvGroups.AllowUserToDeleteRows = false;
            this.dgvGroups.AllowUserToResizeColumns = false;
            this.dgvGroups.AllowUserToResizeRows = false;
            this.dgvGroups.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGroups.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGroups.Location = new System.Drawing.Point(0, 0);
            this.dgvGroups.Name = "dgvGroups";
            this.dgvGroups.RowTemplate.Height = 25;
            this.dgvGroups.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGroups.Size = new System.Drawing.Size(776, 433);
            this.dgvGroups.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.tabControl);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Танцевальная студия";
            this.tabControl.ResumeLayout(false);
            this.tabClients.ResumeLayout(false);
            this.tlpClients.ResumeLayout(false);
            this.pClients.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).EndInit();
            this.tabMemberships.ResumeLayout(false);
            this.tlpMemberships.ResumeLayout(false);
            this.pMemberships.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemberships)).EndInit();
            this.tabGroups.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroups)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabClients;
        private System.Windows.Forms.TableLayoutPanel tlpClients;
        private System.Windows.Forms.Panel pClients;
        private System.Windows.Forms.Button btnRemoveClient;
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.DataGridView dgvClients;
        private System.Windows.Forms.TabPage tabMemberships;
        private System.Windows.Forms.TabPage tabGroups;
        private System.Windows.Forms.TableLayoutPanel tlpMemberships;
        private System.Windows.Forms.Panel pMemberships;
        private System.Windows.Forms.Button btnAddMembership;
        private System.Windows.Forms.Button btnRemoveMembership;
        private System.Windows.Forms.Button btnEditMembership;
        private System.Windows.Forms.DataGridView dgvMemberships;
        private System.Windows.Forms.DataGridView dgvGroups;
        private System.Windows.Forms.Button btnEditClient;
    }
}

