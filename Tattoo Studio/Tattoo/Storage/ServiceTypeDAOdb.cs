using System.Collections.Generic;
using System.Data.SqlClient;
using Entities;

namespace Storage
{
    public class ServiceTypeDAOdb
    {
        private readonly List<ServiceType> types = new List<ServiceType>();
        SqlCommand sqlCommand;
        private readonly string connection;
        readonly string outputQuerry = @"SELECT ID, Название, Стоимость FROM [Вид услуги]";

        public ServiceTypeDAOdb(string connection)
        {
            this.connection = connection;
        }

        public List<ServiceType> GetTypes()
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
                    double price = double.Parse(reader["Стоимость"].ToString().Trim());

                    ServiceType type = new ServiceType(id, name, price);
                    types.Add(type);
                }
                sqlConnection.Close();
            }
            return types;
        }
    }
}
