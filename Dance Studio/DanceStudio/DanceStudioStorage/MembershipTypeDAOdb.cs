using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using DanceStudioEntities;

namespace DanceStudioStorage
{
    public class MembershipTypeDAOdb
    {
        private readonly List<MembershipType> types = new List<MembershipType>();
        SqlCommand sqlCommand;
        private readonly string connection;
        readonly string outputQuerryClients = @"SELECT ID, Стиль, [Количество тренировок], Название FROM [Вид абонемента]";

        public MembershipTypeDAOdb(string connection)
        {
            this.connection = connection;
        }

        public List<MembershipType> GetTypes()
        {
            types.Clear();
            using (SqlConnection sqlConnection = new SqlConnection(connection))
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(outputQuerryClients, sqlConnection);
                var readerType = sqlCommand.ExecuteReader();
                while (readerType.Read())
                {
                    int id = int.Parse(readerType["ID"].ToString().Trim());
                    string style = readerType["Стиль"].ToString().Trim();
                    int workoutsCount = int.Parse(readerType["Количество тренировок"].ToString().Trim());
                    string name = readerType["Название"].ToString().Trim();

                    MembershipType type = new MembershipType(id, style, workoutsCount, name);
                    types.Add(type);
                }
                sqlConnection.Close();
            }
            return types;
        }
    }
}
