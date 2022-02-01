using System.Collections.Generic;
using System.Data.SqlClient;
using DanceStudioEntities;

namespace DanceStudioStorage
{
    public class GroupDAOdb
    {
        private readonly List<Group> groups = new List<Group>();
        SqlCommand sqlCommand;
        private readonly string connection;
        readonly string outputQuerryClients = @"SELECT ID, [Номер группы], Стиль, [Количество учеников] FROM Группы";

        public GroupDAOdb(string connection)
        {
            this.connection = connection;
        }

        public List<Group> GetGroups()
        {
            groups.Clear();
            using (SqlConnection sqlConnection = new SqlConnection(connection))
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(outputQuerryClients, sqlConnection);
                var readerClient = sqlCommand.ExecuteReader();
                while (readerClient.Read())
                {
                    int id = int.Parse(readerClient["ID"].ToString().Trim());
                    int number = int.Parse(readerClient["Номер группы"].ToString().Trim());
                    string style = readerClient["Стиль"].ToString().Trim();
                    int clientsCount = int.Parse(readerClient["Количество учеников"].ToString().Trim());

                    Group group = new Group(id, number, style, clientsCount);
                    groups.Add(group);
                }
                sqlConnection.Close();
            }
            return groups;
        }
    }
}
