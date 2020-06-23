using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using Entities;

namespace StorageDAO
{
    public class SpecialityDAOdb
    {
        List<Speciality> specialities = new List<Speciality>();
        SqlCommand sqlCommand;
        readonly string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=" + "Адвокатское бюро" + ";Integrated Security=True";
        readonly string outputQuerrySpecialities = @"SELECT ID, Название FROM Специальность";
        
        public List<Speciality> GetSpecialitiesList()
        {
            specialities.Clear();
            using (SqlConnection sqlConnection = new SqlConnection(connection))
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(outputQuerrySpecialities, sqlConnection);
                var readerSpeciality = sqlCommand.ExecuteReader();
                while (readerSpeciality.Read())
                {
                    Speciality speciality = new Speciality()
                    {
                        ID = int.Parse(readerSpeciality["ID"].ToString()),
                        Name = readerSpeciality["Название"].ToString(),
                    };
                    specialities.Add(speciality);
                }
                sqlConnection.Close();
            }
            return specialities;
        }
    }
}
