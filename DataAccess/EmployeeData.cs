using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class EmployeeData
    {
        static string connectionString = "Server=.;Database=C21_DB1;User Id=sa;Password=sa123456;";
        public static DataTable GetAllEmployees()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string Query = "SELECT * FROM Employees2";
                    using (SqlCommand command = new SqlCommand(Query, connection))
                    {
                        using (SqlDataReader Reader = command.ExecuteReader())
                        {
                            if (Reader.HasRows)
                            {
                                dt.Load(Reader);
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return dt;
        }
        public static bool IncreaseSalaryUsingCS(int ID, float Percentage)
        {
            int RowsAffected = 0;
            try
            {
                string Query = "UPDATE Employees2 " +
                "SET Salary=Salary*@Percentage WHERE ID=@ID";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(Query, connection))
                    {
                        command.Parameters.AddWithValue("@Percentage", Percentage);
                        command.Parameters.AddWithValue("@ID", ID);

                        RowsAffected= (int)command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception)
            {
                RowsAffected = 0;
            }
            return RowsAffected != 0;
        }
        public static bool IncreaseSalaryUsingCaseStatement()
        {
            int RowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string Query = "UPDATE Employees2 " +
                        "SET Salary = " +
                        "CASE " +
                        "WHEN PerformanceRating > 90 THEN Salary * 1.15 " +
                        "WHEN PerformanceRating BETWEEN 75 AND 90 THEN Salary * 1.10 " +
                        "WHEN PerformanceRating BETWEEN 50 AND 74 THEN Salary * 1.05 " +
                        "ELSE Salary " +
                        "END;";
                    using (SqlCommand command = new SqlCommand(Query, connection))
                    {
                        RowsAffected = (int)command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception)
            {
                RowsAffected = 0;
            }

            return RowsAffected != 0;
        }

    }
}
