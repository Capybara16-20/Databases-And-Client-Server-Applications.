using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using Entities;

namespace Storage
{
    public class ServiceRecordDAOdb
    {
        private readonly List<ServiceRecord> records = new List<ServiceRecord>();
        SqlCommand sqlCommand;
        private readonly string connection;
        readonly string outputQuerry = @"SELECT ID, Мастер, Клиент, [Вид услуги],
            Дата, Время, Цена FROM [Записи на услугу]";

        public ServiceRecordDAOdb(string connection)
        {
            this.connection = connection;
        }

        public List<ServiceRecord> GetRecords()
        {
            records.Clear();
            using (SqlConnection sqlConnection = new SqlConnection(connection))
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(outputQuerry, sqlConnection);
                var reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    int id = int.Parse(reader["ID"].ToString().Trim());
                    string master = reader["Мастер"].ToString().Trim();
                    string client = reader["Клиент"].ToString().Trim();
                    string type = reader["Вид услуги"].ToString().Trim();
                    DateTime date = DateTime.Parse(reader["Дата"].ToString().Trim());
                    DateTime time = DateTime.Parse(reader["Время"].ToString().Trim());
                    double price = double.Parse(reader["Цена"].ToString().Trim());

                    ServiceRecord record = new ServiceRecord(id, master, client, type, date, time, price);
                    records.Add(record);
                }
                sqlConnection.Close();
            }
            return records;
        }

        public void AddRecord(int master, int client, int serviceType, DateTime dateTime)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connection))
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand("Добавление записи на услугу", sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter masterParam = new SqlParameter
                {
                    ParameterName = "@master_id",
                    Value = master
                };
                sqlCommand.Parameters.Add(masterParam);
                SqlParameter clientParam = new SqlParameter
                {
                    ParameterName = "@client_id",
                    Value = client
                };
                sqlCommand.Parameters.Add(clientParam);
                SqlParameter typeParam = new SqlParameter
                {
                    ParameterName = "@service_type_id",
                    Value = serviceType
                };
                sqlCommand.Parameters.Add(typeParam);

                string date = dateTime.ToString("yyyy-MM-dd");
                SqlParameter dateParam = new SqlParameter
                {
                    ParameterName = "@date",
                    Value = date
                };
                sqlCommand.Parameters.Add(dateParam);
                string time = dateTime.ToString("hh:mm tt");
                SqlParameter timeParam = new SqlParameter
                {
                    ParameterName = "@time",
                    Value = time
                };
                sqlCommand.Parameters.Add(timeParam);

                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }

            records.Add(GetRecords().Last());
        }

        public void EditRecord(int id, int master, int client, int serviceType, DateTime dateTime)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connection))
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand("Обновление записи на услугу", sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter idParam = new SqlParameter
                {
                    ParameterName = "@record_id",
                    Value = id
                };
                sqlCommand.Parameters.Add(idParam);
                SqlParameter masterParam = new SqlParameter
                {
                    ParameterName = "@master_id",
                    Value = master
                };
                sqlCommand.Parameters.Add(masterParam);
                SqlParameter clientParam = new SqlParameter
                {
                    ParameterName = "@client_id",
                    Value = client
                };
                sqlCommand.Parameters.Add(clientParam);
                SqlParameter sketchParam = new SqlParameter
                {
                    ParameterName = "@service_type_id",
                    Value = serviceType
                };
                sqlCommand.Parameters.Add(sketchParam);

                string date = dateTime.ToString("yyyy-MM-dd");
                SqlParameter dateParam = new SqlParameter
                {
                    ParameterName = "@date",
                    Value = date
                };
                sqlCommand.Parameters.Add(dateParam);
                string time = dateTime.ToString("hh:mm tt");
                SqlParameter timeParam = new SqlParameter
                {
                    ParameterName = "@time",
                    Value = time
                };
                sqlCommand.Parameters.Add(timeParam);

                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
        }

        public void DeleteRecord(int id)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connection))
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand("Удаление записи на услугу", sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter idParam = new SqlParameter
                {
                    ParameterName = "@record_id",
                    Value = id
                };
                sqlCommand.Parameters.Add(idParam);

                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
        }
    }
}
