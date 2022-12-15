using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlConnected.Services
{
    public class EmployeeServices
    {
        void GetAllGroups()
        {
            string connectionString = @"Server=DESKTOP-92H8HCG\User\;Database=Task;Trusted_Connection=True";
            using (SqlConnection connection = new(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Employee";

                SqlCommand command = new(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Console.WriteLine($"Id: {reader["Id"]} - Name: {reader["Name"]}---Surname{reader["Surname"]}-Salary:{reader["Salary"]}");

                }
            }
        }

    }
}
