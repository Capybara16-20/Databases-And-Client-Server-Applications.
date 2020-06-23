using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Entities;

namespace StorageDAO
{
    public class EmployeeDAOdb
    {
        List<Employee> employees = new List<Employee>();
        SqlCommand sqlCommand;
        readonly string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=" + "Адвокатское бюро" + ";Integrated Security=True";
        readonly string outputQuerryEmployees = @"SELECT ID, ФИО, Специальность, Стаж, Зарплата, Статистика, [Место в рейтинге] FROM Сотрудник";

        public void Add(Employee employee)
        {
            employees.Add(employee);
            using (SqlConnection sqlConnection = new SqlConnection(connection))
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand("Добавить сотрудника", sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter idParam = new SqlParameter
                {
                    ParameterName = "@id",
                    Value = employee.ID
                };
                sqlCommand.Parameters.Add(idParam);
                SqlParameter fullNameParam = new SqlParameter
                {
                    ParameterName = "@full_name",
                    Value = employee.FullName
                };
                sqlCommand.Parameters.Add(fullNameParam);
                SqlParameter specialtyParam = new SqlParameter
                {
                    ParameterName = "@specialty",
                    Value = employee.Specialty
                };
                sqlCommand.Parameters.Add(specialtyParam);
                SqlParameter stageParam = new SqlParameter
                {
                    ParameterName = "@stage",
                    Value = employee.Experience
                };
                sqlCommand.Parameters.Add(stageParam);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
        }

        public void Edit(int id, string fullName, int specialty, int experience)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connection))
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand("Обновить сотрудника", sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter idParam = new SqlParameter
                {
                    ParameterName = "@id",
                    Value = id
                };
                sqlCommand.Parameters.Add(idParam);
                SqlParameter fullNameParam = new SqlParameter
                {
                    ParameterName = "@full_name",
                    Value = fullName
                };
                sqlCommand.Parameters.Add(fullNameParam);
                SqlParameter specialtyParam = new SqlParameter
                {
                    ParameterName = "@specialty",
                    Value = specialty
                };
                sqlCommand.Parameters.Add(specialtyParam);
                SqlParameter stageParam = new SqlParameter
                {
                    ParameterName = "@stage",
                    Value = experience
                };
                sqlCommand.Parameters.Add(stageParam);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
        }

        public void Delete(int id)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connection))
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand("Удалить сотрудника", sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter idParam = new SqlParameter
                {
                    ParameterName = "@id",
                    Value = id
                };
                sqlCommand.Parameters.Add(idParam);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
        }

        public List<Employee> GetEmployeesList()
        {
            employees.Clear();
            using (SqlConnection sqlConnection = new SqlConnection(connection))
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(outputQuerryEmployees, sqlConnection);
                var readerEmployee = sqlCommand.ExecuteReader();
                while (readerEmployee.Read())
                {
                    Employee employee = new Employee()
                    {
                        ID = int.Parse(readerEmployee["ID"].ToString()),
                        FullName = readerEmployee["ФИО"].ToString(),
                        Specialty = int.Parse(readerEmployee["Специальность"].ToString()),
                        Experience = int.Parse(readerEmployee["Стаж"].ToString()),
                        Salary = double.Parse(readerEmployee["Зарплата"].ToString()),
                        Statistics = null,
                        RankingPlace = null,
                    };
                    double statistics;
                    if (double.TryParse(readerEmployee["Статистика"].ToString(), out statistics))
                    {
                        employee.Statistics = statistics;
                    }
                    int rankingPlace;
                    if (int.TryParse(readerEmployee["Место в рейтинге"].ToString(), out rankingPlace))
                    {
                        employee.RankingPlace = rankingPlace;
                    }
                    employees.Add(employee);
                }
                sqlConnection.Close();
            }
            return employees;
        }
    }
}
