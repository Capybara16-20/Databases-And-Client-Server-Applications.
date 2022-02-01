using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Actions;
using Entities;

namespace Forms
{
    public partial class EditServiceRecordForm : Form
    {
        private const string notSelectedMessage = "Данные не выбраны.";
        private const string incorrectDateMessage = "Некорректная дата.";

        private readonly List<Master> masters;
        private readonly List<Client> clients;
        private readonly List<ServiceType> serviceTypes;
        private readonly BusinessLogic bl;
        private readonly int id;

        public EditServiceRecordForm(BusinessLogic bl, int id, string master,
            string client, string type, DateTime dateTime)
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

            serviceTypes = bl.GetServiceTypes();
            cbServiceType.Items.AddRange(serviceTypes.Select(n => n.Name).ToArray());
            cbServiceType.SelectedItem = type;

            dtpDateTime.Format = DateTimePickerFormat.Custom;
            dtpDateTime.CustomFormat = "MM/dd/yyyy hh:mm";
            dtpDateTime.Value = dateTime;
        }

        private void btnEditServiceRecord_Click(object sender, EventArgs e) => EditServiceRecord();

        private void EditServiceRecord()
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
            ServiceType type = serviceTypes[cbServiceType.SelectedIndex];
            DateTime dateTime = dtpDateTime.Value;
            bl.EditServiceRecord(id, master, client, type, dateTime);

            Close();
        }

        private bool IsSelected()
        {
            return cbMaster.SelectedIndex != -1 && cbClient.SelectedIndex != -1
                && cbServiceType.SelectedIndex != -1;
        }

        private bool IsDateCorrect()
        {
            return dtpDateTime.Value >= DateTime.Now;
        }
    }
}
