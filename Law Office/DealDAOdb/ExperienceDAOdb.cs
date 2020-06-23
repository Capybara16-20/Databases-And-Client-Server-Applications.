using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using Entities;

namespace StorageDAO
{
    public class ExperienceDAOdb
    {
        List<Experience> experiences = new List<Experience>();
        SqlCommand sqlCommand;
        readonly string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=" + "Адвокатское бюро" + ";Integrated Security=True";
        readonly string outputQuerryExperiences = @"SELECT ID, Срок FROM Стаж";

        public List<Experience> GetExperiencesList()
        {
            experiences.Clear();
            using (SqlConnection sqlConnection = new SqlConnection(connection))
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(outputQuerryExperiences, sqlConnection);
                var readerSpeciality = sqlCommand.ExecuteReader();
                while (readerSpeciality.Read())
                {
                    Experience experience = new Experience()
                    {
                        ID = int.Parse(readerSpeciality["ID"].ToString()),
                        Name = readerSpeciality["Срок"].ToString(),
                    };
                    experiences.Add(experience);
                }
                sqlConnection.Close();
            }
            return experiences;
        }
    }
}
