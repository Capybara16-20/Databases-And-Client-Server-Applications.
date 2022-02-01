using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Actions;
using Entities;

namespace Forms
{
    public partial class AddServiceRecordForm : Form
    {
        private const string notSelectedMessage = "Данные не выбраны.";
        private const string incorrectDateMessage = "Некорректная дата.";

        private readonly List<Master> masters;
        private readonly List<Client> clients;
        private readonly List<ServiceType> types;
        private readonly BusinessLogic bl;

        public AddServiceRecordForm(BusinessLogic bl)
        {
            InitializeComponent();

            this.bl = bl;
            masters = bl.GetMasters();
            cbMaster.Items.AddRange(masters.Select(n => n.FullName).ToArray());

            clients = bl.GetClients();
            cbClient.Items.AddRange(clients.Select(n => n.FullName).ToArray());

            types = bl.GetServiceTypes();
            cbServiceType.Items.AddRange(types.Select(n => n.Name).ToArray());

            dtpDateTime.Format = DateTimePickerFormat.Custom;
            dtpDateTime.CustomFormat = "MM/dd/yyyy hh:mm";
        }

        private void btnAddServiceRecord_Click(object sender, EventArgs e) => AddServiceRecord();

        private void AddServiceRecord()
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
            ServiceType type = types[cbServiceType.SelectedIndex];
            DateTime dateTime = dtpDateTime.Value;

            bl.AddServiceRecord(master, client, type, dateTime);

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
