using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DanceStudioBL;
using DanceStudioEntities;

namespace DanceStudioUI
{
    public partial class EditMembershipForm : Form
    {
        private const string notSelected = "Данные не выбраны";

        private readonly List<Client> clients;
        private readonly List<MembershipType> types;
        private readonly BusinessLogic bl;
        private readonly int id;
        private readonly string client;
        private readonly string type;
        private readonly int individualCount;

        public EditMembershipForm(BusinessLogic bl, int id, string client, string type, int individualCount)
        {
            InitializeComponent();

            this.bl = bl;
            this.id = id;
            this.client = client;
            this.type = type;
            this.individualCount = individualCount;

            clients = bl.GetClients();
            cbClient.Items.AddRange(clients.Select(n => n.FullName).ToArray());
            cbClient.SelectedItem = client;

            types = bl.GetTypes();
            cbType.Items.AddRange(types.Select(n => n.Name).ToArray());
            cbType.SelectedItem = type;

            nudIndividualCount.Value = individualCount;
        }

        private void btnEdit_Click(object sender, EventArgs e) => EditMembership();

        private void EditMembership()
        {
            if (!IsSelected())
            {
                MessageBox.Show(notSelected);
                return;
            }

            Client client = clients[cbClient.SelectedIndex];
            MembershipType type = types[cbType.SelectedIndex];
            int individualCount = int.Parse(nudIndividualCount.Value.ToString());
            bl.EditMembership(id, client, type, individualCount);

            Close();
        }

        private bool IsSelected()
        {
            return cbClient.SelectedIndex != -1 && cbType.SelectedIndex != -1;
        }
    }
}
