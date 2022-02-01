
namespace Forms
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabSketches = new System.Windows.Forms.TabPage();
            this.tlpSketches = new System.Windows.Forms.TableLayoutPanel();
            this.pSketchesMenu = new System.Windows.Forms.Panel();
            this.tlpSketchesMenu = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddSketch = new System.Windows.Forms.Button();
            this.btnEditSketch = new System.Windows.Forms.Button();
            this.btnDeleteSketch = new System.Windows.Forms.Button();
            this.dgvSkethes = new System.Windows.Forms.DataGridView();
            this.tabRecords = new System.Windows.Forms.TabPage();
            this.tlpSessionRecords = new System.Windows.Forms.TableLayoutPanel();
            this.dgvSessionRecords = new System.Windows.Forms.DataGridView();
            this.pSessionRecordsMenu = new System.Windows.Forms.Panel();
            this.tlpSessionRecordsMenu = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddSessionRecord = new System.Windows.Forms.Button();
            this.btnEditSessionRecord = new System.Windows.Forms.Button();
            this.btnDeleteSessionRecord = new System.Windows.Forms.Button();
            this.tabSrviceRecords = new System.Windows.Forms.TabPage();
            this.tlpServiceRecords = new System.Windows.Forms.TableLayoutPanel();
            this.pServiceRecordsMenu = new System.Windows.Forms.Panel();
            this.tlpServiceRecordsMenu = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddServiceRecord = new System.Windows.Forms.Button();
            this.btnEditServiceRecord = new System.Windows.Forms.Button();
            this.btnDeleteServiceRecord = new System.Windows.Forms.Button();
            this.dgvServiceRecords = new System.Windows.Forms.DataGridView();
            this.tabControl.SuspendLayout();
            this.tabSketches.SuspendLayout();
            this.tlpSketches.SuspendLayout();
            this.pSketchesMenu.SuspendLayout();
            this.tlpSketchesMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSkethes)).BeginInit();
            this.tabRecords.SuspendLayout();
            this.tlpSessionRecords.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSessionRecords)).BeginInit();
            this.pSessionRecordsMenu.SuspendLayout();
            this.tlpSessionRecordsMenu.SuspendLayout();
            this.tabSrviceRecords.SuspendLayout();
            this.tlpServiceRecords.SuspendLayout();
            this.pServiceRecordsMenu.SuspendLayout();
            this.tlpServiceRecordsMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServiceRecords)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabSketches);
            this.tabControl.Controls.Add(this.tabRecords);
            this.tabControl.Controls.Add(this.tabSrviceRecords);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(784, 461);
            this.tabControl.TabIndex = 0;
            // 
            // tabSketches
            // 
            this.tabSketches.Controls.Add(this.tlpSketches);
            this.tabSketches.Location = new System.Drawing.Point(4, 24);
            this.tabSketches.Name = "tabSketches";
            this.tabSketches.Padding = new System.Windows.Forms.Padding(3);
            this.tabSketches.Size = new System.Drawing.Size(776, 433);
            this.tabSketches.TabIndex = 0;
            this.tabSketches.Text = "Эскизы";
            this.tabSketches.UseVisualStyleBackColor = true;
            // 
            // tlpSketches
            // 
            this.tlpSketches.ColumnCount = 1;
            this.tlpSketches.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSketches.Controls.Add(this.pSketchesMenu, 0, 0);
            this.tlpSketches.Controls.Add(this.dgvSkethes, 0, 1);
            this.tlpSketches.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSketches.Location = new System.Drawing.Point(3, 3);
            this.tlpSketches.Name = "tlpSketches";
            this.tlpSketches.RowCount = 2;
            this.tlpSketches.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpSketches.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSketches.Size = new System.Drawing.Size(770, 427);
            this.tlpSketches.TabIndex = 0;
            // 
            // pSketchesMenu
            // 
            this.pSketchesMenu.Controls.Add(this.tlpSketchesMenu);
            this.pSketchesMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pSketchesMenu.Location = new System.Drawing.Point(3, 3);
            this.pSketchesMenu.Name = "pSketchesMenu";
            this.pSketchesMenu.Size = new System.Drawing.Size(764, 34);
            this.pSketchesMenu.TabIndex = 0;
            // 
            // tlpSketchesMenu
            // 
            this.tlpSketchesMenu.ColumnCount = 3;
            this.tlpSketchesMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpSketchesMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpSketchesMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpSketchesMenu.Controls.Add(this.btnAddSketch, 0, 0);
            this.tlpSketchesMenu.Controls.Add(this.btnEditSketch, 1, 0);
            this.tlpSketchesMenu.Controls.Add(this.btnDeleteSketch, 2, 0);
            this.tlpSketchesMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSketchesMenu.Location = new System.Drawing.Point(0, 0);
            this.tlpSketchesMenu.Name = "tlpSketchesMenu";
            this.tlpSketchesMenu.RowCount = 1;
            this.tlpSketchesMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSketchesMenu.Size = new System.Drawing.Size(764, 34);
            this.tlpSketchesMenu.TabIndex = 0;
            // 
            // btnAddSketch
            // 
            this.btnAddSketch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddSketch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSketch.Location = new System.Drawing.Point(3, 3);
            this.btnAddSketch.Name = "btnAddSketch";
            this.btnAddSketch.Size = new System.Drawing.Size(248, 28);
            this.btnAddSketch.TabIndex = 0;
            this.btnAddSketch.Text = "Создать";
            this.btnAddSketch.UseVisualStyleBackColor = true;
            this.btnAddSketch.Click += new System.EventHandler(this.btnAddSketch_Click);
            // 
            // btnEditSketch
            // 
            this.btnEditSketch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEditSketch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditSketch.Location = new System.Drawing.Point(257, 3);
            this.btnEditSketch.Name = "btnEditSketch";
            this.btnEditSketch.Size = new System.Drawing.Size(248, 28);
            this.btnEditSketch.TabIndex = 1;
            this.btnEditSketch.Text = "Обновить";
            this.btnEditSketch.UseVisualStyleBackColor = true;
            this.btnEditSketch.Click += new System.EventHandler(this.btnEditSketch_Click);
            // 
            // btnDeleteSketch
            // 
            this.btnDeleteSketch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeleteSketch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteSketch.Location = new System.Drawing.Point(511, 3);
            this.btnDeleteSketch.Name = "btnDeleteSketch";
            this.btnDeleteSketch.Size = new System.Drawing.Size(250, 28);
            this.btnDeleteSketch.TabIndex = 2;
            this.btnDeleteSketch.Text = "Удалить";
            this.btnDeleteSketch.UseVisualStyleBackColor = true;
            this.btnDeleteSketch.Click += new System.EventHandler(this.btnDeleteSketch_Click);
            // 
            // dgvSkethes
            // 
            this.dgvSkethes.AllowUserToAddRows = false;
            this.dgvSkethes.AllowUserToDeleteRows = false;
            this.dgvSkethes.AllowUserToResizeColumns = false;
            this.dgvSkethes.AllowUserToResizeRows = false;
            this.dgvSkethes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSkethes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSkethes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSkethes.Location = new System.Drawing.Point(3, 43);
            this.dgvSkethes.Name = "dgvSkethes";
            this.dgvSkethes.RowTemplate.Height = 25;
            this.dgvSkethes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSkethes.Size = new System.Drawing.Size(764, 381);
            this.dgvSkethes.TabIndex = 1;
            // 
            // tabRecords
            // 
            this.tabRecords.Controls.Add(this.tlpSessionRecords);
            this.tabRecords.Location = new System.Drawing.Point(4, 24);
            this.tabRecords.Name = "tabRecords";
            this.tabRecords.Padding = new System.Windows.Forms.Padding(3);
            this.tabRecords.Size = new System.Drawing.Size(776, 433);
            this.tabRecords.TabIndex = 1;
            this.tabRecords.Text = "Записи на сеанс";
            this.tabRecords.UseVisualStyleBackColor = true;
            // 
            // tlpSessionRecords
            // 
            this.tlpSessionRecords.ColumnCount = 1;
            this.tlpSessionRecords.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSessionRecords.Controls.Add(this.dgvSessionRecords, 0, 1);
            this.tlpSessionRecords.Controls.Add(this.pSessionRecordsMenu, 0, 0);
            this.tlpSessionRecords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSessionRecords.Location = new System.Drawing.Point(3, 3);
            this.tlpSessionRecords.Name = "tlpSessionRecords";
            this.tlpSessionRecords.RowCount = 2;
            this.tlpSessionRecords.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpSessionRecords.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSessionRecords.Size = new System.Drawing.Size(770, 427);
            this.tlpSessionRecords.TabIndex = 0;
            // 
            // dgvSessionRecords
            // 
            this.dgvSessionRecords.AllowUserToAddRows = false;
            this.dgvSessionRecords.AllowUserToDeleteRows = false;
            this.dgvSessionRecords.AllowUserToResizeColumns = false;
            this.dgvSessionRecords.AllowUserToResizeRows = false;
            this.dgvSessionRecords.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSessionRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSessionRecords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSessionRecords.Location = new System.Drawing.Point(3, 43);
            this.dgvSessionRecords.Name = "dgvSessionRecords";
            this.dgvSessionRecords.RowTemplate.Height = 25;
            this.dgvSessionRecords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSessionRecords.Size = new System.Drawing.Size(764, 381);
            this.dgvSessionRecords.TabIndex = 0;
            // 
            // pSessionRecordsMenu
            // 
            this.pSessionRecordsMenu.Controls.Add(this.tlpSessionRecordsMenu);
            this.pSessionRecordsMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pSessionRecordsMenu.Location = new System.Drawing.Point(3, 3);
            this.pSessionRecordsMenu.Name = "pSessionRecordsMenu";
            this.pSessionRecordsMenu.Size = new System.Drawing.Size(764, 34);
            this.pSessionRecordsMenu.TabIndex = 1;
            // 
            // tlpSessionRecordsMenu
            // 
            this.tlpSessionRecordsMenu.ColumnCount = 3;
            this.tlpSessionRecordsMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpSessionRecordsMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpSessionRecordsMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpSessionRecordsMenu.Controls.Add(this.btnAddSessionRecord, 0, 0);
            this.tlpSessionRecordsMenu.Controls.Add(this.btnEditSessionRecord, 1, 0);
            this.tlpSessionRecordsMenu.Controls.Add(this.btnDeleteSessionRecord, 2, 0);
            this.tlpSessionRecordsMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSessionRecordsMenu.Location = new System.Drawing.Point(0, 0);
            this.tlpSessionRecordsMenu.Name = "tlpSessionRecordsMenu";
            this.tlpSessionRecordsMenu.RowCount = 1;
            this.tlpSessionRecordsMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSessionRecordsMenu.Size = new System.Drawing.Size(764, 34);
            this.tlpSessionRecordsMenu.TabIndex = 0;
            // 
            // btnAddSessionRecord
            // 
            this.btnAddSessionRecord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddSessionRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSessionRecord.Location = new System.Drawing.Point(3, 3);
            this.btnAddSessionRecord.Name = "btnAddSessionRecord";
            this.btnAddSessionRecord.Size = new System.Drawing.Size(248, 28);
            this.btnAddSessionRecord.TabIndex = 0;
            this.btnAddSessionRecord.Text = "Создать";
            this.btnAddSessionRecord.UseVisualStyleBackColor = true;
            this.btnAddSessionRecord.Click += new System.EventHandler(this.btnAddSessionRecord_Click);
            // 
            // btnEditSessionRecord
            // 
            this.btnEditSessionRecord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEditSessionRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditSessionRecord.Location = new System.Drawing.Point(257, 3);
            this.btnEditSessionRecord.Name = "btnEditSessionRecord";
            this.btnEditSessionRecord.Size = new System.Drawing.Size(248, 28);
            this.btnEditSessionRecord.TabIndex = 1;
            this.btnEditSessionRecord.Text = "Обновить";
            this.btnEditSessionRecord.UseVisualStyleBackColor = true;
            this.btnEditSessionRecord.Click += new System.EventHandler(this.btnEditSessionRecord_Click);
            // 
            // btnDeleteSessionRecord
            // 
            this.btnDeleteSessionRecord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeleteSessionRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteSessionRecord.Location = new System.Drawing.Point(511, 3);
            this.btnDeleteSessionRecord.Name = "btnDeleteSessionRecord";
            this.btnDeleteSessionRecord.Size = new System.Drawing.Size(250, 28);
            this.btnDeleteSessionRecord.TabIndex = 2;
            this.btnDeleteSessionRecord.Text = "Удалить";
            this.btnDeleteSessionRecord.UseVisualStyleBackColor = true;
            this.btnDeleteSessionRecord.Click += new System.EventHandler(this.btnDeleteSessionRecord_Click);
            // 
            // tabSrviceRecords
            // 
            this.tabSrviceRecords.Controls.Add(this.tlpServiceRecords);
            this.tabSrviceRecords.Location = new System.Drawing.Point(4, 24);
            this.tabSrviceRecords.Name = "tabSrviceRecords";
            this.tabSrviceRecords.Size = new System.Drawing.Size(776, 433);
            this.tabSrviceRecords.TabIndex = 2;
            this.tabSrviceRecords.Text = "Записи на услуги";
            this.tabSrviceRecords.UseVisualStyleBackColor = true;
            // 
            // tlpServiceRecords
            // 
            this.tlpServiceRecords.ColumnCount = 1;
            this.tlpServiceRecords.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpServiceRecords.Controls.Add(this.pServiceRecordsMenu, 0, 0);
            this.tlpServiceRecords.Controls.Add(this.dgvServiceRecords, 0, 1);
            this.tlpServiceRecords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpServiceRecords.Location = new System.Drawing.Point(0, 0);
            this.tlpServiceRecords.Name = "tlpServiceRecords";
            this.tlpServiceRecords.RowCount = 2;
            this.tlpServiceRecords.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpServiceRecords.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpServiceRecords.Size = new System.Drawing.Size(776, 433);
            this.tlpServiceRecords.TabIndex = 0;
            // 
            // pServiceRecordsMenu
            // 
            this.pServiceRecordsMenu.Controls.Add(this.tlpServiceRecordsMenu);
            this.pServiceRecordsMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pServiceRecordsMenu.Location = new System.Drawing.Point(3, 3);
            this.pServiceRecordsMenu.Name = "pServiceRecordsMenu";
            this.pServiceRecordsMenu.Size = new System.Drawing.Size(770, 34);
            this.pServiceRecordsMenu.TabIndex = 0;
            // 
            // tlpServiceRecordsMenu
            // 
            this.tlpServiceRecordsMenu.ColumnCount = 3;
            this.tlpServiceRecordsMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpServiceRecordsMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpServiceRecordsMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpServiceRecordsMenu.Controls.Add(this.btnAddServiceRecord, 0, 0);
            this.tlpServiceRecordsMenu.Controls.Add(this.btnEditServiceRecord, 1, 0);
            this.tlpServiceRecordsMenu.Controls.Add(this.btnDeleteServiceRecord, 2, 0);
            this.tlpServiceRecordsMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpServiceRecordsMenu.Location = new System.Drawing.Point(0, 0);
            this.tlpServiceRecordsMenu.Name = "tlpServiceRecordsMenu";
            this.tlpServiceRecordsMenu.RowCount = 1;
            this.tlpServiceRecordsMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpServiceRecordsMenu.Size = new System.Drawing.Size(770, 34);
            this.tlpServiceRecordsMenu.TabIndex = 0;
            // 
            // btnAddServiceRecord
            // 
            this.btnAddServiceRecord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddServiceRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddServiceRecord.Location = new System.Drawing.Point(3, 3);
            this.btnAddServiceRecord.Name = "btnAddServiceRecord";
            this.btnAddServiceRecord.Size = new System.Drawing.Size(250, 28);
            this.btnAddServiceRecord.TabIndex = 0;
            this.btnAddServiceRecord.Text = "Создать";
            this.btnAddServiceRecord.UseVisualStyleBackColor = true;
            this.btnAddServiceRecord.Click += new System.EventHandler(this.btnAddServiceRecord_Click);
            // 
            // btnEditServiceRecord
            // 
            this.btnEditServiceRecord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEditServiceRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditServiceRecord.Location = new System.Drawing.Point(259, 3);
            this.btnEditServiceRecord.Name = "btnEditServiceRecord";
            this.btnEditServiceRecord.Size = new System.Drawing.Size(250, 28);
            this.btnEditServiceRecord.TabIndex = 1;
            this.btnEditServiceRecord.Text = "Изменить";
            this.btnEditServiceRecord.UseVisualStyleBackColor = true;
            this.btnEditServiceRecord.Click += new System.EventHandler(this.btnEditServiceRecord_Click);
            // 
            // btnDeleteServiceRecord
            // 
            this.btnDeleteServiceRecord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeleteServiceRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteServiceRecord.Location = new System.Drawing.Point(515, 3);
            this.btnDeleteServiceRecord.Name = "btnDeleteServiceRecord";
            this.btnDeleteServiceRecord.Size = new System.Drawing.Size(252, 28);
            this.btnDeleteServiceRecord.TabIndex = 2;
            this.btnDeleteServiceRecord.Text = "Удалить";
            this.btnDeleteServiceRecord.UseVisualStyleBackColor = true;
            this.btnDeleteServiceRecord.Click += new System.EventHandler(this.btnDeleteServiceRecord_Click);
            // 
            // dgvServiceRecords
            // 
            this.dgvServiceRecords.AllowUserToAddRows = false;
            this.dgvServiceRecords.AllowUserToDeleteRows = false;
            this.dgvServiceRecords.AllowUserToResizeColumns = false;
            this.dgvServiceRecords.AllowUserToResizeRows = false;
            this.dgvServiceRecords.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvServiceRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServiceRecords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvServiceRecords.Location = new System.Drawing.Point(3, 43);
            this.dgvServiceRecords.Name = "dgvServiceRecords";
            this.dgvServiceRecords.RowTemplate.Height = 25;
            this.dgvServiceRecords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvServiceRecords.Size = new System.Drawing.Size(770, 387);
            this.dgvServiceRecords.TabIndex = 1;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.tabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tattoo";
            this.tabControl.ResumeLayout(false);
            this.tabSketches.ResumeLayout(false);
            this.tlpSketches.ResumeLayout(false);
            this.pSketchesMenu.ResumeLayout(false);
            this.tlpSketchesMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSkethes)).EndInit();
            this.tabRecords.ResumeLayout(false);
            this.tlpSessionRecords.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSessionRecords)).EndInit();
            this.pSessionRecordsMenu.ResumeLayout(false);
            this.tlpSessionRecordsMenu.ResumeLayout(false);
            this.tabSrviceRecords.ResumeLayout(false);
            this.tlpServiceRecords.ResumeLayout(false);
            this.pServiceRecordsMenu.ResumeLayout(false);
            this.tlpServiceRecordsMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServiceRecords)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabSketches;
        private System.Windows.Forms.TabPage tabRecords;
        private System.Windows.Forms.TableLayoutPanel tlpSketches;
        private System.Windows.Forms.Panel pSketchesMenu;
        private System.Windows.Forms.TableLayoutPanel tlpSketchesMenu;
        private System.Windows.Forms.Button btnAddSketch;
        private System.Windows.Forms.Button btnEditSketch;
        private System.Windows.Forms.Button btnDeleteSketch;
        private System.Windows.Forms.DataGridView dgvSkethes;
        private System.Windows.Forms.TableLayoutPanel tlpSessionRecords;
        private System.Windows.Forms.DataGridView dgvSessionRecords;
        private System.Windows.Forms.Panel pSessionRecordsMenu;
        private System.Windows.Forms.TableLayoutPanel tlpSessionRecordsMenu;
        private System.Windows.Forms.Button btnAddSessionRecord;
        private System.Windows.Forms.Button btnEditSessionRecord;
        private System.Windows.Forms.Button btnDeleteSessionRecord;
        private System.Windows.Forms.TabPage tabSrviceRecords;
        private System.Windows.Forms.TableLayoutPanel tlpServiceRecords;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Panel pServiceRecordsMenu;
        private System.Windows.Forms.TableLayoutPanel tlpServiceRecordsMenu;
        private System.Windows.Forms.Button btnAddServiceRecord;
        private System.Windows.Forms.Button btnEditServiceRecord;
        private System.Windows.Forms.Button btnDeleteServiceRecord;
        private System.Windows.Forms.DataGridView dgvServiceRecords;
    }
}

