using System.Collections.Generic;
using DanceStudioEntities;
using System.Data.SqlClient;

namespace DanceStudioStorage
{
    public class StyleDAOdb
    {
        private readonly List<Style> styles = new List<Style>();
        SqlCommand sqlCommand;
        private readonly string connection;
        readonly string outputQuerryClients = @"SELECT ID, Название, [Стоимость одного занятия] FROM Стиль";

        public StyleDAOdb(string connection)
        {
            this.connection = connection;
        }

        public List<Style> GetStyles()
        {
            styles.Clear();
            using (SqlConnection sqlConnection = new SqlConnection(connection))
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(outputQuerryClients, sqlConnection);
                var readerStyle = sqlCommand.ExecuteReader();
                while (readerStyle.Read())
                {
                    int id = int.Parse(readerStyle["ID"].ToString().Trim());
                    string name = readerStyle["Название"].ToString().Trim();
                    double price = double.Parse(readerStyle["Стоимость одного занятия"].ToString().Trim());

                    Style style = new Style(id, name, price);
                    styles.Add(style);
                }
                sqlConnection.Close();
            }
            return styles;
        }
    }
}
