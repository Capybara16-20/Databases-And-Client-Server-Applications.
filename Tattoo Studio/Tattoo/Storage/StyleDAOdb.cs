using System.Collections.Generic;
using System.Data.SqlClient;
using Entities;

namespace Storage
{
    public class StyleDAOdb
    {
        private readonly List<Style> styles = new List<Style>();
        SqlCommand sqlCommand;
        private readonly string connection;
        readonly string outputQuerry = @"SELECT ID, Название, [Коэффициент времени] FROM Стиль";

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
                sqlCommand = new SqlCommand(outputQuerry, sqlConnection);
                var reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    int id = int.Parse(reader["ID"].ToString().Trim());
                    string name = reader["Название"].ToString().Trim();
                    double coefficient = double.Parse(reader["Коэффициент времени"].ToString().Trim());

                    Style style = new Style(id, name, coefficient);
                    styles.Add(style);
                }
                sqlConnection.Close();
            }
            return styles;
        }
    }
}
