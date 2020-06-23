using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using Entities;

namespace StorageDAO
{
    public class StageDAOdb
    {
        List<Stage> stages = new List<Stage>();
        SqlCommand sqlCommand;
        readonly string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=" + "Адвокатское бюро" + ";Integrated Security=True";
        readonly string outputQuerrySpecialities = @"SELECT ID, Стадия, Описание FROM [Стадия дела]";

        public List<Stage> GetStagesList()
        {
            stages.Clear();
            using (SqlConnection sqlConnection = new SqlConnection(connection))
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(outputQuerrySpecialities, sqlConnection);
                var readerStage = sqlCommand.ExecuteReader();
                while (readerStage.Read())
                {
                    Stage stage = new Stage()
                    {
                        ID = int.Parse(readerStage["ID"].ToString()),
                        Step = readerStage["Стадия"].ToString(),
                        Description = readerStage["Описание"].ToString(),
                    };
                    stages.Add(stage);
                }
                sqlConnection.Close();
            }
            return stages;
        }
    }
}
