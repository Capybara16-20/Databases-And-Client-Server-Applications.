using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Entities;

namespace StorageDAO
{
    public class DealDAOdb
    {
        List<Deal> deals = new List<Deal>();
        SqlCommand sqlCommand;
        readonly string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=" + "Адвокатское бюро" + ";Integrated Security=True";
        readonly string outputQuerryDeals = @"SELECT ID, Клиент, Сотрудник, [Уровень безнадёжности], [Вид соглашения], [Стадия дела], [Статус завершения] FROM Дело";

        public void Add(Deal deal)
        {
            deals.Add(deal);
            using (SqlConnection sqlConnection = new SqlConnection(connection))
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand("Добавить дело", sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter idParam = new SqlParameter
                {
                    ParameterName = "@id",
                    Value = deal.ID
                };
                sqlCommand.Parameters.Add(idParam);
                SqlParameter customerParam = new SqlParameter
                {
                    ParameterName = "@customer",
                    Value = deal.Customer
                };
                sqlCommand.Parameters.Add(customerParam);
                SqlParameter employeeParam = new SqlParameter
                {
                    ParameterName = "@employee",
                    Value = deal.Employee
                };
                sqlCommand.Parameters.Add(employeeParam);
                SqlParameter levelParam = new SqlParameter
                {
                    ParameterName = "@level",
                    Value = deal.HopelessnessLevel
                };
                sqlCommand.Parameters.Add(levelParam);
                SqlParameter agreementParam = new SqlParameter
                {
                    ParameterName = "@type_of_agreement",
                    Value = deal.AgreementType
                };
                sqlCommand.Parameters.Add(agreementParam);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
        }

        public void Edit(int id, int? stage, int? status)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connection))
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand("Обновить дело", sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter idParam = new SqlParameter
                {
                    ParameterName = "@id",
                    Value = id
                };
                sqlCommand.Parameters.Add(idParam);
                SqlParameter stageParam = new SqlParameter();
                stageParam.ParameterName = "@stage";
                if (stage.HasValue)
                {
                    stageParam.Value = stage;
                }
                else
                {
                    stageParam.Value = DBNull.Value;
                }
                sqlCommand.Parameters.Add(stageParam);
                SqlParameter statusParam = new SqlParameter();
                statusParam.ParameterName = "@status";
                if (status.HasValue)
                {   
                    statusParam.Value = stage;
                }
                else
                {
                    statusParam.Value = DBNull.Value;
                }
                sqlCommand.Parameters.Add(statusParam);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
        }

        public void Delete(int id)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connection))
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand("Удалить дело", sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter idParam = new SqlParameter
                {
                    ParameterName = "@id",
                    Value = id
                };
                sqlCommand.Parameters.Add(idParam);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
        }

        public List<Deal> GetDealsList()
        {
            deals.Clear();
            using (SqlConnection sqlConnection = new SqlConnection(connection))
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(outputQuerryDeals, sqlConnection);
                var readerDeal = sqlCommand.ExecuteReader();
                while (readerDeal.Read())
                {
                    Deal deal = new Deal()
                    {
                        ID = int.Parse(readerDeal["ID"].ToString()),
                        Customer = int.Parse(readerDeal["Клиент"].ToString()),
                        Employee = int.Parse(readerDeal["Сотрудник"].ToString()),
                        HopelessnessLevel = int.Parse(readerDeal["Уровень безнадёжности"].ToString()),
                        AgreementType = int.Parse(readerDeal["Вид соглашения"].ToString()),
                        Stage = null,
                        Status = null,
                    };
                    int stage;
                    if (int.TryParse(readerDeal["Стадия дела"].ToString(), out stage))
                    {
                        deal.Stage = stage;
                    }
                    int status;
                    if (int.TryParse(readerDeal["Статус завершения"].ToString(), out status))
                    {
                        deal.Status = status;
                    }
                    deals.Add(deal);
                }
                sqlConnection.Close();
            }
            return deals;
        }
    }
}
