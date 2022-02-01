using System.Collections.Generic;
using System.Data.SqlClient;
using Entities;

namespace Storage
{
    public class WorkTypeDAOdb
    {
        private readonly List<WorkType> types = new List<WorkType>();
        SqlCommand sqlCommand;
        private readonly string connection;
        readonly string outputQuerry = @"SELECT ID, Название, [Начальное время] FROM [Вид работы]";

        public WorkTypeDAOdb(string connection)
        {
            this.connection = connection;
        }

        public List<WorkType> GetTypes()
        {
            types.Clear();
            using (SqlConnection sqlConnection = new SqlConnection(connection))
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(outputQuerry, sqlConnection);
                var reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    int id = int.Parse(reader["ID"].ToString().Trim());
                    string name = reader["Название"].ToString().Trim();
                    double originTime = double.Parse(reader["Начальное время"].ToString().Trim());

                    WorkType type = new WorkType(id, name, originTime);
                    types.Add(type);
                }
                sqlConnection.Close();
            }
            return types;
        }
    }
}
