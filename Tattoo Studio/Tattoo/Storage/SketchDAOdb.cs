using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using Entities;

namespace Storage
{
    public class SketchDAOdb
    {
        private readonly List<Sketch> sketches = new List<Sketch>();
        SqlCommand sqlCommand;
        private readonly string connection;
        readonly string outputQuerry = @"SELECT ID, Стиль, Размер, [Время нанесения] FROM Эскизы";

        public SketchDAOdb(string connection)
        {
            this.connection = connection;
        }

        public List<Sketch> GetSketches()
        {
            sketches.Clear();
            using (SqlConnection sqlConnection = new SqlConnection(connection))
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(outputQuerry, sqlConnection);
                var reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    int id = int.Parse(reader["ID"].ToString().Trim());
                    string style = reader["Стиль"].ToString().Trim();
                    string size = reader["Размер"].ToString().Trim();
                    double time = double.Parse(reader["Время нанесения"].ToString().Trim());

                    Sketch sketch = new Sketch(id, style, size, time);
                    sketches.Add(sketch);
                }
                sqlConnection.Close();
            }
            return sketches;
        }

        public void AddSketch(int style, int size)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connection))
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand("Добавление эскиза", sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter styleParam = new SqlParameter
                {
                    ParameterName = "@style_id",
                    Value = style
                };
                sqlCommand.Parameters.Add(styleParam);
                SqlParameter sizeParam = new SqlParameter
                {
                    ParameterName = "@size_id",
                    Value = size
                };
                sqlCommand.Parameters.Add(sizeParam);

                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }

            sketches.Add(GetSketches().Last());
        }

        public void EditSketch(int id, int style, int size)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connection))
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand("Обновление эскиза", sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter idParam = new SqlParameter
                {
                    ParameterName = "@sketch_id",
                    Value = id
                };
                sqlCommand.Parameters.Add(idParam);
                SqlParameter styleParam = new SqlParameter
                {
                    ParameterName = "@style_id",
                    Value = style
                };
                sqlCommand.Parameters.Add(styleParam);
                SqlParameter sizeParam = new SqlParameter
                {
                    ParameterName = "@size_id",
                    Value = size
                };
                sqlCommand.Parameters.Add(sizeParam);

                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
        }

        public void DeleteSketch(int id, out string errorMessage)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connection))
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand("Удаление эскиза", sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter idParam = new SqlParameter
                {
                    ParameterName = "@sketch_id",
                    Value = id
                };
                sqlCommand.Parameters.Add(idParam);
                SqlParameter outMessageParam = new SqlParameter()
                {
                    ParameterName = "@message",
                    SqlDbType = System.Data.SqlDbType.NVarChar,
                    Size = 100,
                    Direction = System.Data.ParameterDirection.Output
                };
                sqlCommand.Parameters.Add(outMessageParam);

                sqlCommand.ExecuteNonQuery();

                errorMessage = outMessageParam.Value.ToString();

                sqlConnection.Close();
            }
        }
    }
}
