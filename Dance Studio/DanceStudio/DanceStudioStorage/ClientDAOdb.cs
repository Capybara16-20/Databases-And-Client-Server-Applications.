using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using DanceStudioEntities;

namespace DanceStudioStorage
{
    public class ClientDAOdb
    {
        private readonly List<Client> clients = new List<Client>();
        SqlCommand sqlCommand;
        private readonly string connection;
        readonly string outputQuerryClients = @"SELECT ID, ФИО, [Дата рождения], Телефон FROM Клиент";

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
                sqlCommand = new SqlCommand(outputQuerryClients, sqlConnection);
                var readerClient = sqlCommand.ExecuteReader();
                while (readerClient.Read())
                {
                    int id = int.Parse(readerClient["ID"].ToString().Trim());
                    string fullName = readerClient["ФИО"].ToString().Trim();
                    DateTime birthDate = DateTime.Parse(readerClient["Дата рождения"].ToString());
                    string phone = readerClient["Телефон"].ToString().Trim();

                    Client client = new Client(id, fullName, birthDate, phone);
                    clients.Add(client);
                }
                sqlConnection.Close();
            }
            return clients;
        }

        public void Add(Client client)
        {
            clients.Add(client);

            using (SqlConnection sqlConnection = new SqlConnection(connection))
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand("Вставка клиента", sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter fullNameParam = new SqlParameter
                {
                    ParameterName = "@fullname",
                    Value = client.FullName
                };
                sqlCommand.Parameters.Add(fullNameParam);
                SqlParameter birthDateParam = new SqlParameter
                {
                    ParameterName = "@birth_date",
                    Value = client.BirthDate
                };
                sqlCommand.Parameters.Add(birthDateParam);
                SqlParameter phoneParam = new SqlParameter
                {
                    ParameterName = "@phone_number",
                    Value = client.Phone
                };
                sqlCommand.Parameters.Add(phoneParam);
                
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
        }

        public void Edit(int id, string fullName, DateTime birthDate, string phone)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connection))
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand("Обновление клиента", sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter idParam = new SqlParameter
                {
                    ParameterName = "@id",
                    Value = id
                };
                sqlCommand.Parameters.Add(idParam);
                SqlParameter fullNameParam = new SqlParameter
                {
                    ParameterName = "@fullname",
                    Value = fullName
                };
                sqlCommand.Parameters.Add(fullNameParam);
                SqlParameter birthDateParam = new SqlParameter
                {
                    ParameterName = "@birth_date",
                    Value = birthDate
                };
                sqlCommand.Parameters.Add(birthDateParam);
                SqlParameter phoneParam = new SqlParameter
                {
                    ParameterName = "@phone_number",
                    Value = phone
                };
                sqlCommand.Parameters.Add(phoneParam);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
        }

        public void Remove(string fullName, string phone, out string errorMessage)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connection))
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand("Удаление клиента", sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter fullNameParam = new SqlParameter
                {
                    ParameterName = "@client_FIO",
                    Value = fullName
                };
                sqlCommand.Parameters.Add(fullNameParam);
                SqlParameter phoneParam = new SqlParameter
                {
                    ParameterName = "@phone",
                    Value = phone
                };
                sqlCommand.Parameters.Add(phoneParam);
                SqlParameter outMessageParam = new SqlParameter()
                {
                    ParameterName = "@Message",
                    SqlDbType = System.Data.SqlDbType.NVarChar,
                    Size = 100,
                    Direction = System.Data.ParameterDirection.Output
                };
                sqlCommand.Parameters.Add(outMessageParam);
                sqlCommand.ExecuteNonQuery();

                errorMessage = outMessageParam.Value.ToString();

                sqlConnection.Close();
            }
        }
    }
}
