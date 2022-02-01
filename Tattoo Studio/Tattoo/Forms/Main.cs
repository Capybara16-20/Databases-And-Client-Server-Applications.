using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Entities;
using Actions;

namespace Forms
{
    public partial class Main : Form
    {
        private const string moreThanOneRowSelectedMessage = "Выбрано более одной строки.";
        private const string confirmDeleteMessage = "Удалить запись на сеанс?";

        private readonly BusinessLogic bl = new BusinessLogic();

        public Main()
        {
            InitializeComponent();

            SketchesRenew();
            ServiceRecordsRenew();
            SessionRecordsRenew();
        }

        private void btnAddSketch_Click(object sender, EventArgs e) => AddSketch();

        private void btnEditSketch_Click(object sender, EventArgs e) => EditSketch();

        private void btnDeleteSketch_Click(object sender, EventArgs e) => DeleteSketch();

        private void btnAddSessionRecord_Click(object sender, EventArgs e) => AddSessionRecord();

        private void btnEditSessionRecord_Click(object sender, EventArgs e) => EditSessionRecord();

        private void btnDeleteSessionRecord_Click(object sender, EventArgs e) => DeleteSessionRecord();

        private void btnAddServiceRecord_Click(object sender, EventArgs e) => AddServiceRecord();

        private void btnEditServiceRecord_Click(object sender, EventArgs e) => EditServiceRecord();

        private void btnDeleteServiceRecord_Click(object sender, EventArgs e) => DeleteServiceRecord();

        private void SketchesRenew()
        {
            const int idIndex = 0;
            const int styleIndex = 1;
            const int sizeIndex = 2;
            const int timeIndex = 3;
            const string style = "Стиль";
            const string size = "Размер";
            const string time = "Время нанесения/часы";

            List<Sketch> sketches = bl.GetSketches();

            dgvSkethes.DataSource = null;
            dgvSkethes.DataSource = sketches;
            dgvSkethes.Columns[idIndex].Visible = false;
            dgvSkethes.Columns[styleIndex].HeaderText = style;
            dgvSkethes.Columns[sizeIndex].HeaderText = size;
            dgvSkethes.Columns[timeIndex].HeaderText = time;
        }

        private void ServiceRecordsRenew()
        {
            const int idIndex = 0;
            const int masterIndex = 1;
            const int clientIndex = 2;
            const int typeIndex = 3;
            const int dateIndex = 4;
            const int timeIndex = 5;
            const int priceIndex = 6;
            const string master = "Мастер";
            const string client = "Клиент";
            const string type = "Вид услуги";
            const string date = "Дата";
            const string time = "Время";
            const string price = "Цена";

            List<ServiceRecord> records = bl.GetServiceRecords();

            dgvServiceRecords.DataSource = null;
            dgvServiceRecords.DataSource = records;
            dgvServiceRecords.Columns[idIndex].Visible = false;
            dgvServiceRecords.Columns[masterIndex].HeaderText = master;
            dgvServiceRecords.Columns[clientIndex].HeaderText = client;
            dgvServiceRecords.Columns[typeIndex].HeaderText = type;
            dgvServiceRecords.Columns[dateIndex].HeaderText = date;
            dgvServiceRecords.Columns[timeIndex].HeaderText = time;
            dgvServiceRecords.Columns[priceIndex].HeaderText = price;
        }

        private void SessionRecordsRenew()
        {
            const int idIndex = 0;
            const int masterIndex = 1;
            const int clientIndex = 2;
            const int sketchIndex = 3;
            const int workTypeIndex = 4;
            const int dateIndex = 5;
            const int timeIndex = 6;
            const int workTimeIndex = 7;
            const int priceIndex = 8;
            const string master = "Мастер";
            const string client = "Клиент";
            const string sketch = "Эскиз/Стиль-размер-время";
            const string workType = "Вид работы";
            const string date = "Дата";
            const string time = "Время";
            const string workTime = "Время работы/часы";
            const string price = "Цена";

            List<SessionRecord> records = bl.GetSessionRecords();

            dgvSessionRecords.DataSource = null;
            dgvSessionRecords.DataSource = records;
            dgvSessionRecords.Columns[idIndex].Visible = false;
            dgvSessionRecords.Columns[masterIndex].HeaderText = master;
            dgvSessionRecords.Columns[clientIndex].HeaderText = client;
            dgvSessionRecords.Columns[sketchIndex].HeaderText = sketch;
            dgvSessionRecords.Columns[workTypeIndex].HeaderText = workType;
            dgvSessionRecords.Columns[dateIndex].HeaderText = date;
            dgvSessionRecords.Columns[timeIndex].HeaderText = time;
            dgvSessionRecords.Columns[workTimeIndex].HeaderText = workTime;
            dgvSessionRecords.Columns[priceIndex].HeaderText = price;
        }

        private void AddSketch()
        {
            AddSketchForm form = new AddSketchForm(bl);
            form.ShowDialog();

            SketchesRenew();
        }

        private void EditSketch()
        {
            const int idIndex = 0;
            const int styleIndex = 1;
            const int sizeIndex = 2;

            if (dgvSkethes.SelectedRows.Count > 1)
            {
                MessageBox.Show(moreThanOneRowSelectedMessage);
                return;
            }

            int id = int.Parse(dgvSkethes.SelectedRows[0].Cells[idIndex].Value.ToString());
            string style = dgvSkethes.SelectedRows[0].Cells[styleIndex].Value.ToString();
            string size = dgvSkethes.SelectedRows[0].Cells[sizeIndex].Value.ToString();

            EditSketchForm form = new EditSketchForm(bl, id, style, size);
            form.ShowDialog();

            SketchesRenew();
        }

        private void DeleteSketch()
        {
            const int idIndex = 0;

            if (dgvSkethes.SelectedRows.Count > 1)
            {
                MessageBox.Show(moreThanOneRowSelectedMessage);
                return;
            }

            int id = int.Parse(dgvSkethes.SelectedRows[0].Cells[idIndex].Value.ToString());
            string errorMessage;
            bl.DeleteSketch(id, out errorMessage);

            if (!string.IsNullOrEmpty(errorMessage))
                MessageBox.Show(errorMessage);
            else
                SketchesRenew();
        }

        private void AddSessionRecord()
        {
            AddSessionRecordForm form = new AddSessionRecordForm(bl);
            form.ShowDialog();

            SessionRecordsRenew();
        }

        private void EditSessionRecord()
        {
            const int idIndex = 0;
            const int masterIndex = 1;
            const int clientIndex = 2;
            const int sketchIndex = 3;
            const int typeIndex = 4;
            const int dateIndex = 5;
            const int timeIndex = 6;

            if (dgvSessionRecords.SelectedRows.Count > 1)
            {
                MessageBox.Show(moreThanOneRowSelectedMessage);
                return;
            }

            int id = int.Parse(dgvSessionRecords.SelectedRows[0].Cells[idIndex].Value.ToString());
            string master = dgvSessionRecords.SelectedRows[0].Cells[masterIndex].Value.ToString();
            string client = dgvSessionRecords.SelectedRows[0].Cells[clientIndex].Value.ToString();
            string sketch = dgvSessionRecords.SelectedRows[0].Cells[sketchIndex].Value.ToString();
            string type = dgvSessionRecords.SelectedRows[0].Cells[typeIndex].Value.ToString();
            string date = dgvSessionRecords.SelectedRows[0].Cells[dateIndex].Value.ToString();
            string time = dgvSessionRecords.SelectedRows[0].Cells[timeIndex].Value.ToString();
            DateTime dateTime = DateTime.Parse(date);
            dateTime = dateTime.Date + TimeSpan.Parse(time);

            EditSessionRecordForm form = new EditSessionRecordForm(bl, id, master, client, sketch, type, dateTime);
            form.ShowDialog();

            SessionRecordsRenew();
        }

        private void DeleteSessionRecord()
        {
            const int idIndex = 0;

            if (dgvSessionRecords.SelectedRows.Count > 1)
            {
                MessageBox.Show(moreThanOneRowSelectedMessage);
                return;
            }

            int id = int.Parse(dgvSessionRecords.SelectedRows[0].Cells[idIndex].Value.ToString());

            DialogResult dialogResult = MessageBox.Show(confirmDeleteMessage, "Удаление записи", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                bl.DeleteSessionRecord(id);

                SessionRecordsRenew();
            }
        }

        private void AddServiceRecord()
        {
            AddServiceRecordForm form = new AddServiceRecordForm(bl);
            form.ShowDialog();

            ServiceRecordsRenew();
        }

        private void EditServiceRecord()
        {
            const int idIndex = 0;
            const int masterIndex = 1;
            const int clientIndex = 2;
            const int typeIndex = 3;
            const int dateIndex = 4;
            const int timeIndex = 5;

            if (dgvServiceRecords.SelectedRows.Count > 1)
            {
                MessageBox.Show(moreThanOneRowSelectedMessage);
                return;
            }

            int id = int.Parse(dgvServiceRecords.SelectedRows[0].Cells[idIndex].Value.ToString());
            string master = dgvServiceRecords.SelectedRows[0].Cells[masterIndex].Value.ToString();
            string client = dgvServiceRecords.SelectedRows[0].Cells[clientIndex].Value.ToString();
            string type = dgvServiceRecords.SelectedRows[0].Cells[typeIndex].Value.ToString();
            string date = dgvServiceRecords.SelectedRows[0].Cells[dateIndex].Value.ToString();
            string time = dgvServiceRecords.SelectedRows[0].Cells[timeIndex].Value.ToString();
            DateTime dateTime = DateTime.Parse(date);
            dateTime = dateTime.Date + TimeSpan.Parse(time);

            EditServiceRecordForm form = new EditServiceRecordForm(bl, id, master, client, type, dateTime);
            form.ShowDialog();

            ServiceRecordsRenew();
        }

        private void DeleteServiceRecord()
        {
            const int idIndex = 0;

            if (dgvServiceRecords.SelectedRows.Count > 1)
            {
                MessageBox.Show(moreThanOneRowSelectedMessage);
                return;
            }

            int id = int.Parse(dgvServiceRecords.SelectedRows[0].Cells[idIndex].Value.ToString());

            DialogResult dialogResult = MessageBox.Show(confirmDeleteMessage, "Удаление записи", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                bl.DeleteServiceRecord(id);

                ServiceRecordsRenew();
            }
        }
    }
}
