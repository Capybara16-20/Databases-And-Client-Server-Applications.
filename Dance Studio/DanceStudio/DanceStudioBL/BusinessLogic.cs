using System;
using System.Collections.Generic;
using DanceStudioEntities;
using DanceStudioStorage;

namespace DanceStudioBL
{
    public class BusinessLogic
    {
        private const string connection = @"Data Source=DESKTOP-UM6EJNQ\SQLEXPRESS;Initial Catalog=" 
            + "Танцевальная студия" + ";Integrated Security=True";

        private readonly ClientDAOdb clients = new ClientDAOdb(connection);
        private readonly StyleDAOdb styles = new StyleDAOdb(connection);
        private readonly MembershipTypeDAOdb types = new MembershipTypeDAOdb(connection);
        private readonly MembershipDAOdb memberships = new MembershipDAOdb(connection);
        private readonly GroupDAOdb groups = new GroupDAOdb(connection);

        public List<Client> GetClients()
        {
            return clients.GetClients();
        }

        public void AddClient(string surname, string name, string patronymic, DateTime birthDate, string phone)
        {
            clients.Add(new Client(surname, name, patronymic, birthDate, phone));
        }

        public void EditClient(int id, string fullName, DateTime birthDate, string phone)
        {
            clients.Edit(id, fullName, birthDate, phone);
        }

        public void RemoveClient(string fullName, string phone, out string errorMessage)
        {
            clients.Remove(fullName, phone, out errorMessage);
        }

        public List<Style> GetStyles()
        {
            return styles.GetStyles();
        }

        public List<MembershipType> GetTypes()
        {
            return types.GetTypes();
        }

        public List<Membership> GetMemberships()
        {
            return memberships.GetMemberships();
        }

        public void AddMembership(Client client, MembershipType type, int individualCount)
        {
            memberships.Add((int)client.ID, type.ID, individualCount);
        }

        public void EditMembership(int id, Client client, MembershipType type, int individualCount)
        {
            memberships.Edit(id, (int)client.ID, type.ID, individualCount);
        }

        public void RemoveMembership(string client, string type, int individualCount)
        {
            memberships.Remove(client, type, individualCount);
        }

        public List<Group> GetGroups()
        {
            return groups.GetGroups();
        }
    }
}
