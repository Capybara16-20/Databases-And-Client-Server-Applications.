using System.Collections.Generic;
using System.Data.SqlClient;
using Entities;

namespace Storage
{
    public class SizeDAOdb
    {
        private readonly List<Size> sizes = new List<Size>();
        SqlCommand sqlCommand;
        private readonly string connection;
        readonly string outputQuerry = @"SELECT ID, Размеры, [Коэффициент времени] FROM Размер";

        public SizeDAOdb(string connection)
        {
            this.connection = connection;
        }

        public List<Size> GetSizes()
        {
            sizes.Clear();
            using (SqlConnection sqlConnection = new SqlConnection(connection))
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(outputQuerry, sqlConnection);
                var reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    int id = int.Parse(reader["ID"].ToString().Trim());
                    string sizes = reader["Размеры"].ToString().Trim();
                    double coefficient = double.Parse(reader["Коэффициент времени"].ToString().Trim());

                    Size size = new Size(id, sizes, coefficient);
                    this.sizes.Add(size);
                }
                sqlConnection.Close();
            }
            return sizes;
        }
    }
}
