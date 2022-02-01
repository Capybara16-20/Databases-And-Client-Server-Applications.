using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DanceStudioBL;
using DanceStudioEntities;

namespace DanceStudioUI
{
    public partial class AddMembershipForm : Form
    {
        private const string notSelected = "Данные не выбраны";

        private List<Client> clients;
        private List<MembershipType> types;
        private readonly BusinessLogic bl;

        public AddMembershipForm(BusinessLogic bl)
        {
            InitializeComponent();

            this.bl = bl;
            clients = bl.GetClients();
            cbClient.Items.AddRange(clients.Select(n => n.FullName).ToArray());

            types = bl.GetTypes();
            cbType.Items.AddRange(types.Select(n => n.Name).ToArray());
        }

        private void btnAdd_Click(object sender, EventArgs e) => AddMembership();

        private void AddMembership()
        {
            if (!IsSelected())
            {
                MessageBox.Show(notSelected);
                return;
            }

            Client client = clients[cbClient.SelectedIndex];
            MembershipType type = types[cbType.SelectedIndex];
            int individualCount = int.Parse(nudIndividualCount.Value.ToString());
            bl.AddMembership(client, type, individualCount);

            Close();
        }

        private bool IsSelected()
        {
            return cbClient.SelectedIndex != -1 && cbType.SelectedIndex != -1;
        }
    }
}
