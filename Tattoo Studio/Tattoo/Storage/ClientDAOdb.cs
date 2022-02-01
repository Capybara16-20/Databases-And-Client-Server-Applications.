using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Entities;

namespace Storage
{
    public class ClientDAOdb
    {
        private readonly List<Client> clients = new List<Client>();
        SqlCommand sqlCommand;
        private readonly string connection;
        readonly string outputQuerry = @"SELECT ID, ФИО, [Дата рождения], Адрес, Телефон FROM Клиент";

        public ClientDAOdb(string connection)
        {
            this.connection = connection;
        }

        public List<Client> GetClients()
        {
            clients.Clear();
            using (SqlConnection sqlConnection = new SqlConnection(connection))
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(outputQuerry, sqlConnection);
                var reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    int id = int.Parse(reader["ID"].ToString().Trim());
                    string fullName = reader["ФИО"].ToString().Trim();
                    DateTime birthDate = DateTime.Parse(reader["Дата рождения"].ToString().Trim());
                    string address = reader["Адрес"].ToString().Trim();
                    string phone = reader["Телефон"].ToString().Trim();

                    Client client = new Client(id, fullName, birthDate, address, phone);
                    clients.Add(client);
                }
                sqlConnection.Close();
            }
            return clients;
        }
    }
}
