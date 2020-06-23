using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Entities;

namespace StorageDAO
{
    public class AgreementTypeDAOdb
    {
        List<AgreementType> types = new List<AgreementType>();
        SqlCommand sqlCommand;
        readonly string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=" + "Адвокатское бюро" + ";Integrated Security=True";
        readonly string outputQuerryAgreementTypes = @"SELECT ID, Название FROM [Вид соглашения]";

        public List<AgreementType> GetAgreementTypesList()
        {
            types.Clear();
            using (SqlConnection sqlConnection = new SqlConnection(connection))
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(outputQuerryAgreementTypes, sqlConnection);
                var readerAgreementType = sqlCommand.ExecuteReader();
                while (readerAgreementType.Read())
                {
                    AgreementType type = new AgreementType()
                    {
                        ID = int.Parse(readerAgreementType["ID"].ToString()),
                        Name = readerAgreementType["Название"].ToString(),
                    };
                    types.Add(type);
                }
                sqlConnection.Close();
            }
            return types;
        }
    }
}
