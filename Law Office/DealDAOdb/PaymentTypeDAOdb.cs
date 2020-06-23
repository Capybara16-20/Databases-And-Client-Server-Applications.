using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Entities;

namespace StorageDAO
{
    public class PaymentTypeDAOdb
    {
        List<PaymentType> paymentTypes = new List<PaymentType>();
        SqlCommand sqlCommand;
        readonly string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=" + "Адвокатское бюро" + ";Integrated Security=True";
        readonly string outputQuerryPaymentTypes = @"SELECT ID, Название FROM [Вид оплаты]";

        public List<PaymentType> GetPaymentTypesList()
        {
            paymentTypes.Clear();
            using (SqlConnection sqlConnection = new SqlConnection(connection))
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(outputQuerryPaymentTypes, sqlConnection);
                var readerPaymentType = sqlCommand.ExecuteReader();
                while (readerPaymentType.Read())
                {
                    PaymentType paymentType = new PaymentType()
                    {
                        ID = int.Parse(readerPaymentType["ID"].ToString()),
                        Name = readerPaymentType["Название"].ToString(),
                    };
                    paymentTypes.Add(paymentType);
                }
                sqlConnection.Close();
            }
            return paymentTypes;
        }
    }
}
