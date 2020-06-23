using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using Entities;

namespace StorageDAO
{
    public class CustomerDAOdb
    {
        List<Customer> customers = new List<Customer>();
        SqlCommand sqlCommand;
        readonly string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=" + "Адвокатское бюро" + ";Integrated Security=True";
        readonly string outputQuerryCustomers = @"SELECT ID, ФИО FROM Клиент";

        public List<Customer> GetCustomersList()
        {
            customers.Clear();
            using (SqlConnection sqlConnection = new SqlConnection(connection))
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(outputQuerryCustomers, sqlConnection);
                var readerCustomer = sqlCommand.ExecuteReader();
                while (readerCustomer.Read())
                {
                    Customer customer = new Customer()
                    {
                        ID = int.Parse(readerCustomer["ID"].ToString()),
                        FullName = readerCustomer["ФИО"].ToString(),
                    };
                    customers.Add(customer);
                }
                sqlConnection.Close();
            }
            return customers;
        }
    }
}
