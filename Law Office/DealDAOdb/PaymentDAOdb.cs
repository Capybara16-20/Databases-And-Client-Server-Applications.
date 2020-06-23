using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Entities;

namespace StorageDAO
{
    public class PaymentDAOdb
    {
        List<Payment> payments = new List<Payment>();
        SqlCommand sqlCommand;
        readonly string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=" + "Адвокатское бюро" + ";Integrated Security=True";
        readonly string outputQuerryPayments = @"SELECT Дело, [Вид оплаты], Сумма, [Статус оплаты] FROM [Оплата дела]";

        public void Edit(int deal, int paymentType)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connection))
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand("Обновить оплату", sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter idParam = new SqlParameter
                {
                    ParameterName = "@deal",
                    Value = deal
                };
                sqlCommand.Parameters.Add(idParam);
                SqlParameter typeParam = new SqlParameter
                {
                    ParameterName = "@paymentType",
                    Value = paymentType
                };
                sqlCommand.Parameters.Add(typeParam);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
        }

        public List<Payment> GetPaymentsList()
        {
            payments.Clear();
            using (SqlConnection sqlConnection = new SqlConnection(connection))
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(outputQuerryPayments, sqlConnection);
                var readerPayment = sqlCommand.ExecuteReader();
                while (readerPayment.Read())
                {
                    Payment payment = new Payment()
                    {
                        Deal = int.Parse(readerPayment["Дело"].ToString()),
                        PaymentType = int.Parse(readerPayment["Вид оплаты"].ToString()),
                        Sum = double.Parse(readerPayment["Сумма"].ToString()),
                        Status = readerPayment["Статус оплаты"].ToString(),
                    };
                    payments.Add(payment);
                }
                sqlConnection.Close();
            }
            return payments;
        }
    }
}
