using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Actions;
using Entities;

namespace Forms
{
    public partial class EditSessionRecordForm : Form
    {
        private const string notSelectedMessage = "Данные не выбраны.";
        private const string incorrectDateMessage = "Некорректная дата.";

        private readonly List<Master> masters;
        private readonly List<Client> clients;
        private readonly List<Sketch> sketches;
        private readonly List<WorkType> workTypes;
        private readonly BusinessLogic bl;
        private readonly int id;

        public EditSessionRecordForm(BusinessLogic bl, int id, string master, 
            string client, string sketch, string type, DateTime dateTime)
        {
            InitializeComponent();

            this.bl = bl;
            this.id = id;
            masters = bl.GetMasters();
            cbMaster.Items.AddRange(masters.Select(n => n.FullName).ToArray());
            cbMaster.SelectedItem = master;

            clients = bl.GetClients();
            cbClient.Items.AddRange(clients.Select(n => n.FullName).ToArray());
            cbClient.SelectedItem = client;

            sketches = bl.GetSketches();
            cbSketch.Items.AddRange(sketches.Select(n => GetSketchInfo(n.Style, n.Size, n.Time)).ToArray());
            cbSketch.SelectedItem = sketch;

            workTypes = bl.GetWorkTypes();
            cbWorkType.Items.AddRange(workTypes.Select(n => n.Name).ToArray());
            cbWorkType.SelectedItem = type;

            dtpDateTime.Format = DateTimePickerFormat.Custom;
            dtpDateTime.CustomFormat = "MM/dd/yyyy hh:mm";
            dtpDateTime.Value = dateTime;
        }

        private void btnEditSessionRecord_Click(object sender, EventArgs e) => EditSessionRecord();

        private void EditSessionRecord()
        {
            if (!IsSelected())
            {
                MessageBox.Show(notSelectedMessage);
                return;
            }
            if (!IsDateCorrect())
            {
                MessageBox.Show(incorrectDateMessage);
                return;
            }

            Master master = masters[cbMaster.SelectedIndex];
            Client client = clients[cbClient.SelectedIndex];
            Sketch sketch = sketches[cbSketch.SelectedIndex];
            WorkType workType = workTypes[cbWorkType.SelectedIndex];
            DateTime dateTime = dtpDateTime.Value;
            bl.EditSessionRecord(id, master, client, sketch, workType, dateTime);

            Close();
        }

        private bool IsSelected()
        {
            return cbMaster.SelectedIndex != -1 && cbClient.SelectedIndex != -1
                && cbSketch.SelectedIndex != -1 && cbWorkType.SelectedIndex != -1;
        }

        private bool IsDateCorrect()
        {
            return dtpDateTime.Value >= DateTime.Now;
        }

        private string GetSketchInfo(string sketchStyle, string sketchSize, double sketchTime)
        {
            return string.Format("{0} | {1} | {2}", sketchStyle, sketchSize, sketchTime);
        }
    }
}
