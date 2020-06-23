using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using Entities;

namespace StorageDAO
{
    public class EndingStatusDAOdb
    {
        List<EndingStatus> endingStatuses = new List<EndingStatus>();
        SqlCommand sqlCommand;
        readonly string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=" + "Адвокатское бюро" + ";Integrated Security=True";
        readonly string outputQuerryStatuses = @"SELECT ID, Статус, Описание FROM [Статус завершения]";

        public List<EndingStatus> GetEndingStatusesList()
        {
            endingStatuses.Clear();
            using (SqlConnection sqlConnection = new SqlConnection(connection))
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(outputQuerryStatuses, sqlConnection);
                var readerStatus = sqlCommand.ExecuteReader();
                while (readerStatus.Read())
                {
                    EndingStatus endingStatus = new EndingStatus()
                    {
                        ID = int.Parse(readerStatus["ID"].ToString()),
                        Status = readerStatus["Статус"].ToString(),
                        Description = readerStatus["Описание"].ToString(),
                    };
                    endingStatuses.Add(endingStatus);
                }
                sqlConnection.Close();
            }
            return endingStatuses;
        }
    }
}
