using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using DanceStudioEntities;

namespace DanceStudioStorage
{
    public class MembershipDAOdb
    {
        private readonly List<Membership> memberships = new List<Membership>();
        SqlCommand sqlCommand;
        private readonly string connection;
        readonly string outputQuerryClients = @"SELECT ID, Клиент, [Вид абонемента], 
            [Количество индивидуальных занятий], Стоимость FROM Абонементы";

        public MembershipDAOdb(string connection)
        {
            this.connection = connection;
        }

        public List<Membership> GetMemberships()
        {
            memberships.Clear();
            using (SqlConnection sqlConnection = new SqlConnection(connection))
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(outputQuerryClients, sqlConnection);
                var readerMembership = sqlCommand.ExecuteReader();
                while (readerMembership.Read())
                {
                    int id = int.Parse(readerMembership["ID"].ToString().Trim());
                    string client = readerMembership["Клиент"].ToString().Trim();
                    string type = readerMembership["Вид абонемента"].ToString().Trim();
                    int individualCount = int.Parse(readerMembership["Количество индивидуальных занятий"].ToString().Trim());
                    double price = double.Parse(readerMembership["Стоимость"].ToString().Trim());

                    Membership membership = new Membership(id, client, type, individualCount, price);
                    memberships.Add(membership);
                }
                sqlConnection.Close();
            }
            return memberships;
        }

        public void Add(int client, int type, int individualCount)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connection))
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand("Вставка абонемента", sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter clientParam = new SqlParameter
                {
                    ParameterName = "@client_id",
                    Value = client
                };
                sqlCommand.Parameters.Add(clientParam);
                SqlParameter typeParam = new SqlParameter
                {
                    ParameterName = "@membership_type_id",
                    Value = type
                };
                sqlCommand.Parameters.Add(typeParam);
                SqlParameter individualCountParam = new SqlParameter
                {
                    ParameterName = "@individual_lesson_count",
                    Value = individualCount
                };
                sqlCommand.Parameters.Add(individualCountParam);

                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }

            memberships.Add(GetMemberships().Last());
        }

        public void Edit(int id, int client, int type, int individualCount)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connection))
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand("Обновление абонемента", sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter idParam = new SqlParameter
                {
                    ParameterName = "@id",
                    Value = id
                };
                sqlCommand.Parameters.Add(idParam);
                SqlParameter clientParam = new SqlParameter
                {
                    ParameterName = "@client_id",
                    Value = client
                };
                sqlCommand.Parameters.Add(clientParam);
                SqlParameter typeParam = new SqlParameter
                {
                    ParameterName = "@membership_type_id",
                    Value = type
                };
                sqlCommand.Parameters.Add(typeParam);
                SqlParameter individualCountParam = new SqlParameter
                {
                    ParameterName = "@individual_lesson_count",
                    Value = individualCount
                };
                sqlCommand.Parameters.Add(individualCountParam);

                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
        }

        public void Remove(string client, string type, int individualCount)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connection))
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand("Удаление абонемента", sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter clientParam = new SqlParameter
                {
                    ParameterName = "@client_FIO",
                    Value = client
                };
                sqlCommand.Parameters.Add(clientParam);
                SqlParameter typeParam = new SqlParameter
                {
                    ParameterName = "@membership_type",
                    Value = type
                };
                sqlCommand.Parameters.Add(typeParam);
                SqlParameter individualCountParam = new SqlParameter
                {
                    ParameterName = "@individual_lesson_count",
                    Value = individualCount
                };
                sqlCommand.Parameters.Add(individualCountParam);

                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
        }
    }
}
