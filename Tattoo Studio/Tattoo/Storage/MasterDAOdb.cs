using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Entities;

namespace Storage
{
    public class MasterDAOdb
    {
        private readonly List<Master> masters = new List<Master>();
        SqlCommand sqlCommand;
        private readonly string connection;
        readonly string outputQuerry = @"SELECT ID, Специальность, ФИО, 
            [Дата рождения], Адрес, Телефон FROM Мастера";

        public MasterDAOdb(string connection)
        {
            this.connection = connection;
        }

        public List<Master> GetMasters()
        {
            masters.Clear();
            using (SqlConnection sqlConnection = new SqlConnection(connection))
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(outputQuerry, sqlConnection);
                var reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    int id = int.Parse(reader["ID"].ToString().Trim());
                    string specialty = reader["Специальность"].ToString().Trim();
                    string fullName = reader["ФИО"].ToString().Trim();
                    DateTime birthDate = DateTime.Parse(reader["Дата рождения"].ToString().Trim());
                    string address = reader["Адрес"].ToString().Trim();
                    string phone = reader["Телефон"].ToString().Trim();

                    Master master = new Master(id, specialty, fullName, birthDate, address, phone);
                    masters.Add(master);
                }
                sqlConnection.Close();
            }
            return masters;
        }
    }
}
