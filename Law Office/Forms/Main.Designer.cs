namespace Forms
{
    partial class Main
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.employeesGrid = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dealGrid = new System.Windows.Forms.DataGridView();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.добавитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.paymentsGrid = new System.Windows.Forms.DataGridView();
            this.ColumnCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEmployee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAgreementType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSpeciality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnExperience = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStatistics = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRankingPlace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip3 = new System.Windows.Forms.MenuStrip();
            this.изменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ColumnDeal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPaymentType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStatusOfPayment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeesGrid)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dealGrid)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsGrid)).BeginInit();
            this.menuStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(684, 461);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.employeesGrid);
            this.tabPage1.Controls.Add(this.menuStrip1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(676, 435);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Сотрудники";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // employeesGrid
            // 
            this.employeesGrid.AllowUserToAddRows = false;
            this.employeesGrid.AllowUserToDeleteRows = false;
            this.employeesGrid.BackgroundColor = System.Drawing.Color.Wheat;
            this.employeesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeesGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnFullName,
            this.ColumnSpeciality,
            this.ColumnExperience,
            this.ColumnSalary,
            this.ColumnStatistics,
            this.ColumnRankingPlace});
            this.employeesGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeesGrid.Location = new System.Drawing.Point(3, 27);
            this.employeesGrid.Name = "employeesGrid";
            this.employeesGrid.ReadOnly = true;
            this.employeesGrid.Size = new System.Drawing.Size(670, 405);
            this.employeesGrid.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.удалитьToolStripMenuItem,
            this.удалитьToolStripMenuItem3});
            this.menuStrip1.Location = new System.Drawing.Point(3, 3);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(670, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.BackColor = System.Drawing.Color.SandyBrown;
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.удалитьToolStripMenuItem.Text = "Изменить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.изменитьToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem3
            // 
            this.удалитьToolStripMenuItem3.BackColor = System.Drawing.Color.Salmon;
            this.удалитьToolStripMenuItem3.Name = "удалитьToolStripMenuItem3";
            this.удалитьToolStripMenuItem3.Size = new System.Drawing.Size(63, 20);
            this.удалитьToolStripMenuItem3.Text = "Удалить";
            this.удалитьToolStripMenuItem3.Click += new System.EventHandler(this.удалитьToolStripMenuItem3_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dealGrid);
            this.tabPage2.Controls.Add(this.menuStrip2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(676, 435);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Дела";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dealGrid
            // 
            this.dealGrid.AllowUserToAddRows = false;
            this.dealGrid.AllowUserToDeleteRows = false;
            this.dealGrid.BackgroundColor = System.Drawing.Color.Wheat;
            this.dealGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dealGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCustomer,
            this.ColumnEmployee,
            this.ColumnLevel,
            this.ColumnAgreementType,
            this.ColumnStage,
            this.ColumnStatus});
            this.dealGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dealGrid.Location = new System.Drawing.Point(3, 27);
            this.dealGrid.Name = "dealGrid";
            this.dealGrid.ReadOnly = true;
            this.dealGrid.Size = new System.Drawing.Size(670, 405);
            this.dealGrid.TabIndex = 1;
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem1,
            this.удалитьToolStripMenuItem2,
            this.удалитьToolStripMenuItem1});
            this.menuStrip2.Location = new System.Drawing.Point(3, 3);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(670, 24);
            this.menuStrip2.TabIndex = 0;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // добавитьToolStripMenuItem1
            // 
            this.добавитьToolStripMenuItem1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.добавитьToolStripMenuItem1.Name = "добавитьToolStripMenuItem1";
            this.добавитьToolStripMenuItem1.Size = new System.Drawing.Size(71, 20);
            this.добавитьToolStripMenuItem1.Text = "Добавить";
            this.добавитьToolStripMenuItem1.Click += new System.EventHandler(this.добавитьToolStripMenuItem1_Click);
            // 
            // удалитьToolStripMenuItem2
            // 
            this.удалитьToolStripMenuItem2.BackColor = System.Drawing.Color.SandyBrown;
            this.удалитьToolStripMenuItem2.Name = "удалитьToolStripMenuItem2";
            this.удалитьToolStripMenuItem2.Size = new System.Drawing.Size(73, 20);
            this.удалитьToolStripMenuItem2.Text = "Изменить";
            this.удалитьToolStripMenuItem2.Click += new System.EventHandler(this.изменитьToolStripMenuItem2_Click);
            // 
            // удалитьToolStripMenuItem1
            // 
            this.удалитьToolStripMenuItem1.BackColor = System.Drawing.Color.Salmon;
            this.удалитьToolStripMenuItem1.Name = "удалитьToolStripMenuItem1";
            this.удалитьToolStripMenuItem1.Size = new System.Drawing.Size(63, 20);
            this.удалитьToolStripMenuItem1.Text = "Удалить";
            this.удалитьToolStripMenuItem1.Click += new System.EventHandler(this.удалитьToolStripMenuItem1_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.paymentsGrid);
            this.tabPage3.Controls.Add(this.menuStrip3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(676, 435);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Оплата";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // paymentsGrid
            // 
            this.paymentsGrid.AllowUserToAddRows = false;
            this.paymentsGrid.AllowUserToDeleteRows = false;
            this.paymentsGrid.BackgroundColor = System.Drawing.Color.Wheat;
            this.paymentsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.paymentsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnDeal,
            this.ColumnPaymentType,
            this.ColumnSum,
            this.ColumnStatusOfPayment});
            this.paymentsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paymentsGrid.Location = new System.Drawing.Point(3, 27);
            this.paymentsGrid.Name = "paymentsGrid";
            this.paymentsGrid.ReadOnly = true;
            this.paymentsGrid.Size = new System.Drawing.Size(670, 405);
            this.paymentsGrid.TabIndex = 0;
            // 
            // ColumnCustomer
            // 
            this.ColumnCustomer.HeaderText = "Клиент";
            this.ColumnCustomer.Name = "ColumnCustomer";
            this.ColumnCustomer.ReadOnly = true;
            this.ColumnCustomer.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnEmployee
            // 
            this.ColumnEmployee.HeaderText = "Сотрудник";
            this.ColumnEmployee.Name = "ColumnEmployee";
            this.ColumnEmployee.ReadOnly = true;
            this.ColumnEmployee.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnLevel
            // 
            this.ColumnLevel.HeaderText = "Уровень безнадёжности";
            this.ColumnLevel.Name = "ColumnLevel";
            this.ColumnLevel.ReadOnly = true;
            this.ColumnLevel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnAgreementType
            // 
            this.ColumnAgreementType.HeaderText = "Вид соглашения";
            this.ColumnAgreementType.Name = "ColumnAgreementType";
            this.ColumnAgreementType.ReadOnly = true;
            this.ColumnAgreementType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnStage
            // 
            this.ColumnStage.HeaderText = "Стадия";
            this.ColumnStage.Name = "ColumnStage";
            this.ColumnStage.ReadOnly = true;
            this.ColumnStage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnStatus
            // 
            this.ColumnStatus.HeaderText = "Статус завершения";
            this.ColumnStatus.Name = "ColumnStatus";
            this.ColumnStatus.ReadOnly = true;
            this.ColumnStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // columnFullName
            // 
            this.columnFullName.HeaderText = "ФИО";
            this.columnFullName.Name = "columnFullName";
            this.columnFullName.ReadOnly = true;
            this.columnFullName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnSpeciality
            // 
            this.ColumnSpeciality.HeaderText = "Специальность";
            this.ColumnSpeciality.Name = "ColumnSpeciality";
            this.ColumnSpeciality.ReadOnly = true;
            this.ColumnSpeciality.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnExperience
            // 
            this.ColumnExperience.HeaderText = "Стаж";
            this.ColumnExperience.Name = "ColumnExperience";
            this.ColumnExperience.ReadOnly = true;
            this.ColumnExperience.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnSalary
            // 
            this.ColumnSalary.HeaderText = "Зарплата";
            this.ColumnSalary.Name = "ColumnSalary";
            this.ColumnSalary.ReadOnly = true;
            this.ColumnSalary.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnStatistics
            // 
            this.ColumnStatistics.HeaderText = "Статистика";
            this.ColumnStatistics.Name = "ColumnStatistics";
            this.ColumnStatistics.ReadOnly = true;
            this.ColumnStatistics.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnRankingPlace
            // 
            this.ColumnRankingPlace.HeaderText = "Место в рейтинге";
            this.ColumnRankingPlace.Name = "ColumnRankingPlace";
            this.ColumnRankingPlace.ReadOnly = true;
            this.ColumnRankingPlace.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // menuStrip3
            // 
            this.menuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.изменитьToolStripMenuItem});
            this.menuStrip3.Location = new System.Drawing.Point(3, 3);
            this.menuStrip3.Name = "menuStrip3";
            this.menuStrip3.Size = new System.Drawing.Size(670, 24);
            this.menuStrip3.TabIndex = 1;
            this.menuStrip3.Text = "menuStrip3";
            // 
            // изменитьToolStripMenuItem
            // 
            this.изменитьToolStripMenuItem.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            this.изменитьToolStripMenuItem.Size = new System.Drawing.Size(148, 20);
            this.изменитьToolStripMenuItem.Text = "Пометить оплаченным";
            this.изменитьToolStripMenuItem.Click += new System.EventHandler(this.изменитьToolStripMenuItem_Click_1);
            // 
            // ColumnDeal
            // 
            this.ColumnDeal.HeaderText = "Номер дела";
            this.ColumnDeal.Name = "ColumnDeal";
            this.ColumnDeal.ReadOnly = true;
            this.ColumnDeal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnPaymentType
            // 
            this.ColumnPaymentType.HeaderText = "Вид оплаты";
            this.ColumnPaymentType.Name = "ColumnPaymentType";
            this.ColumnPaymentType.ReadOnly = true;
            this.ColumnPaymentType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnSum
            // 
            this.ColumnSum.HeaderText = "Сумма";
            this.ColumnSum.Name = "ColumnSum";
            this.ColumnSum.ReadOnly = true;
            this.ColumnSum.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnStatusOfPayment
            // 
            this.ColumnStatusOfPayment.HeaderText = "Статус оплаты";
            this.ColumnStatusOfPayment.Name = "ColumnStatusOfPayment";
            this.ColumnStatusOfPayment.ReadOnly = true;
            this.ColumnStatusOfPayment.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnStatusOfPayment.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Адвокатское бюро";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeesGrid)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dealGrid)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsGrid)).EndInit();
            this.menuStrip3.ResumeLayout(false);
            this.menuStrip3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView employeesGrid;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dealGrid;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView paymentsGrid;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAgreementType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStage;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSpeciality;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnExperience;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStatistics;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRankingPlace;
        private System.Windows.Forms.MenuStrip menuStrip3;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDeal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPaymentType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSum;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStatusOfPayment;
    }
}

