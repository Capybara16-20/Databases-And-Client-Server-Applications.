using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Entities;

namespace StorageDAO
{
    public class HopelessnessLevelDAOdb
    {
        List<HopelessnessLevel> levels = new List<HopelessnessLevel>();
        SqlCommand sqlCommand;
        readonly string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=" + "Адвокатское бюро" + ";Integrated Security=True";
        readonly string outputQuerryHopelessnessLevels = @"SELECT ID, Название FROM [Уровень безнадёжности]";

        public List<HopelessnessLevel> GetHopelessnessLevelsList()
        {
            levels.Clear();
            using (SqlConnection sqlConnection = new SqlConnection(connection))
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(outputQuerryHopelessnessLevels, sqlConnection);
                var readerHopelessnessLevel = sqlCommand.ExecuteReader();
                while (readerHopelessnessLevel.Read())
                {
                    HopelessnessLevel hopelessnessLevel = new HopelessnessLevel()
                    {
                        ID = int.Parse(readerHopelessnessLevel["ID"].ToString()),
                        Name = readerHopelessnessLevel["Название"].ToString(),
                    };
                    levels.Add(hopelessnessLevel);
                }
                sqlConnection.Close();
            }
            return levels;
        }
    }
}
