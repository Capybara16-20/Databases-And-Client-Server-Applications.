using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DanceStudioBL;
using DanceStudioEntities;

namespace DanceStudioUI
{
    public partial class MainForm : Form
    {
        private const string moreThanOneRowSelectedMessage = "Выбрано более одной строки.";

        private readonly  BusinessLogic bl = new BusinessLogic();

        public MainForm()
        {
            InitializeComponent();

            ClientsRenew();
            MembershipsRenew();
            GroupsRenew();
        }

        private void btnAddClient_Click(object sender, System.EventArgs e) => AddClient();

        private void btnEditClient_Click(object sender, System.EventArgs e) => EditClient();

        private void btnRemoveClient_Click(object sender, System.EventArgs e) => RemoveClient();

        private void btnAddMembership_Click(object sender, System.EventArgs e) => AddMembership();

        private void btnEditMembership_Click(object sender, System.EventArgs e) => EditMembership();

        private void btnRemoveMembership_Click(object sender, System.EventArgs e) => RemoveMembership();

        private void ClientsRenew()
        {
            const int idIndex = 0;
            const int fullNameIndex = 1;
            const int birthDateIndex = 2;
            const int phoneIndex = 3;
            const string fullName = "ФИО";
            const string birthDate = "Дата рождения";
            const string phone = "Телефон";

            List<Client> clients = bl.GetClients();

            dgvClients.DataSource = null;
            dgvClients.DataSource = clients;
            dgvClients.Columns[idIndex].Visible = false;
            dgvClients.Columns[fullNameIndex].HeaderText = fullName;
            dgvClients.Columns[birthDateIndex].HeaderText = birthDate;
            dgvClients.Columns[phoneIndex].HeaderText = phone;
        }

        private void MembershipsRenew()
        {
            const int idIndex = 0;
            const int clientIndex = 1;
            const int typeIndex = 2;
            const int individualCountIndex = 3;
            const int priceIndex = 4;
            const string client = "Клиент";
            const string type = "Вид абонемента";
            const string individualCount = "Количество индивидуальных занятий";
            const string price = "Стоимость";

            List<Membership> memberships = bl.GetMemberships();

            dgvMemberships.DataSource = null;
            dgvMemberships.DataSource = memberships;
            dgvMemberships.Columns[idIndex].Visible = false;
            dgvMemberships.Columns[clientIndex].HeaderText = client;
            dgvMemberships.Columns[typeIndex].HeaderText = type;
            dgvMemberships.Columns[individualCountIndex].HeaderText = individualCount;
            dgvMemberships.Columns[priceIndex].HeaderText = price;
        }

        private void GroupsRenew()
        {
            const int idIndex = 0;
            const int numberIndex = 1;
            const int styleIndex = 2;
            const int clientsCountIndex = 3;
            const string number = "Номер группы";
            const string style = "Стиль";
            const string clientsCount = "Количество учеников";

            List<Group> groups = bl.GetGroups();

            dgvGroups.DataSource = null;
            dgvGroups.DataSource = groups;
            dgvGroups.Columns[idIndex].Visible = false;
            dgvGroups.Columns[numberIndex].HeaderText = number;
            dgvGroups.Columns[styleIndex].HeaderText = style;
            dgvGroups.Columns[clientsCountIndex].HeaderText = clientsCount;
        }

        private void AddClient()
        {
            AddClientForm addClientForm = new AddClientForm(bl);
            addClientForm.ShowDialog();

            ClientsRenew();
        }

        private void EditClient()
        {
            const int idIndex = 0;
            const int fullNameIndex = 1;
            const int birthDateIndex = 2;
            const int phoneIndex = 3;

            if (dgvClients.SelectedRows.Count > 1)
            {
                MessageBox.Show(moreThanOneRowSelectedMessage);
                return;
            }

            int id = int.Parse(dgvClients.SelectedRows[0].Cells[idIndex].Value.ToString());
            string fullName = dgvClients.SelectedRows[0].Cells[fullNameIndex].Value.ToString();
            DateTime birthDate = DateTime.Parse(dgvClients.SelectedRows[0].Cells[birthDateIndex].Value.ToString());
            string phone = dgvClients.SelectedRows[0].Cells[phoneIndex].Value.ToString();

            EditClientForm editClientForm = new EditClientForm(bl, id, fullName, birthDate, phone);
            editClientForm.ShowDialog();
            
            ClientsRenew();
        }

        private void RemoveClient()
        {
            const int fullNameIndex = 1;
            const int phoneIndex = 3;

            if (dgvClients.SelectedRows.Count > 1)
            {
                MessageBox.Show(moreThanOneRowSelectedMessage);
                return;
            }

            string fullName = dgvClients.SelectedRows[0].Cells[fullNameIndex].Value.ToString();
            string phone = dgvClients.SelectedRows[0].Cells[phoneIndex].Value.ToString();
            string errorMessage;
            bl.RemoveClient(fullName, phone, out errorMessage);
            
            if (!string.IsNullOrEmpty(errorMessage))
                MessageBox.Show(errorMessage);
            else
                ClientsRenew();
        }

        private void AddMembership()
        {
            AddMembershipForm addMembershipForm = new AddMembershipForm(bl);
            addMembershipForm.ShowDialog();

            MembershipsRenew();
            GroupsRenew();
        }

        private void EditMembership()
        {
            const int idIndex = 0;
            const int clientIndex = 1;
            const int typeIndex = 2;
            const int individualCountIndex = 3;

            if (dgvMemberships.SelectedRows.Count > 1)
            {
                MessageBox.Show(moreThanOneRowSelectedMessage);
                return;
            }

            int id = int.Parse(dgvMemberships.SelectedRows[0].Cells[idIndex].Value.ToString());
            string client = dgvMemberships.SelectedRows[0].Cells[clientIndex].Value.ToString();
            string type = dgvMemberships.SelectedRows[0].Cells[typeIndex].Value.ToString();
            int individualCount = int.Parse(dgvMemberships.SelectedRows[0]
                .Cells[individualCountIndex].Value.ToString());

            EditMembershipForm editMembershipForm = new EditMembershipForm(bl, id, client, type, individualCount);
            editMembershipForm.ShowDialog();

            MembershipsRenew();
            GroupsRenew();
        }

        private void RemoveMembership()
        {
            const int clientIndex = 1;
            const int typeIndex = 2;
            const int individualCountIndex = 3;

            if (dgvMemberships.SelectedRows.Count > 1)
            {
                MessageBox.Show(moreThanOneRowSelectedMessage);
                return;
            }

            string client = dgvMemberships.SelectedRows[0].Cells[clientIndex].Value.ToString();
            string type = dgvMemberships.SelectedRows[0].Cells[typeIndex].Value.ToString();
            int individualCount = int.Parse(dgvMemberships.SelectedRows[0]
                .Cells[individualCountIndex].Value.ToString());
            bl.RemoveMembership(client, type, individualCount);

            MembershipsRenew();
            GroupsRenew();
        }
    }
}
