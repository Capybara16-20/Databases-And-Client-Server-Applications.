using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Actions;
using Entities;

namespace Forms
{
    public partial class AddSessionRecordForm : Form
    {
        private const string notSelectedMessage = "Данные не выбраны.";
        private const string incorrectDateMessage = "Некорректная дата.";

        private readonly List<Master> masters;
        private readonly List<Client> clients;
        private readonly List<Sketch> sketches;
        private readonly List<WorkType> workTypes;
        private readonly BusinessLogic bl;

        public AddSessionRecordForm(BusinessLogic bl)
        {
            InitializeComponent();

            this.bl = bl;
            masters = bl.GetMasters();
            cbMaster.Items.AddRange(masters.Select(n => n.FullName).ToArray());

            clients = bl.GetClients();
            cbClient.Items.AddRange(clients.Select(n => n.FullName).ToArray());

            sketches = bl.GetSketches();
            cbSketch.Items.AddRange(sketches.Select(n => GetSketchInfo(n.Style, n.Size, n.Time)).ToArray());

            workTypes = bl.GetWorkTypes();
            cbWorkType.Items.AddRange(workTypes.Select(n => n.Name).ToArray());

            dtpDateTime.Format = DateTimePickerFormat.Custom;
            dtpDateTime.CustomFormat = "MM/dd/yyyy hh:mm";
        }

        private void btnAddSessionRecord_Click(object sender, EventArgs e) => AddSessionRecord();

        private void AddSessionRecord()
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

            bl.AddSessionRecord(master, client, sketch, workType, dateTime);

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
