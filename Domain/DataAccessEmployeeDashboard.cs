using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using Domain;
namespace Domain
{
  public  class DataAccessEmployeeDashboard
    {
        private readonly string _connectionString;

        public DataAccessEmployeeDashboard(string connectionString)
        {
            _connectionString = connectionString;
        }
        public Employee AddItem(Employee employee)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var commandText = "INSERT INTO Employee (firstName,lastName,birthDate,address,phoneNumber, salary, email, nickname,password,roleType,workingHours, role) VALUES (@Name,@LastName,@DateOfBirth,@Address,@PhoneNumber,@Salary,@Email,@Nickname, @Password, @Role, @WorkingHours, @Role1); SELECT SCOPE_IDENTITY()";
                using (var command = new SqlCommand(commandText, connection))
                {
                    command.Parameters.AddWithValue("@Name", employee.firstName);
                    command.Parameters.AddWithValue("@LastName", employee.lastName);
                    command.Parameters.AddWithValue("@DateOfBirth", employee.birthDate);
                    command.Parameters.AddWithValue("@Address", employee.address);
                    command.Parameters.AddWithValue("@PhoneNumber", employee.phoneNumber);
                    command.Parameters.AddWithValue("@Salary", employee.salary);
                    command.Parameters.AddWithValue("@Email", employee.email);
                    command.Parameters.AddWithValue("@Nickname", employee.nickname);
                    command.Parameters.AddWithValue("@Password", employee.password);
                    command.Parameters.AddWithValue("@Role", employee.role);
                    command.Parameters.AddWithValue("@WorkingHours", employee.workingHours);
                    command.Parameters.AddWithValue("@Role1", employee.role);

                    connection.Open();
                    var id = (decimal)command.ExecuteScalar();
                    employee.id = (int)id;

                    return employee;
                }
            }
        }
        public List<Employee> GetItems()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var commandText = "SELECT * FROM Employee";
                using (var command = new SqlCommand(commandText, connection))
                {
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        var items = new List<Employee>();


                        while (reader.Read())
                        {
                            var item = new Employee()
                            {
                                id = (int)reader["ID"],
                                email = reader.GetString(reader.GetOrdinal("email")),
                                workingHours = reader.GetInt32(reader.GetOrdinal("workingHours")),
                                role = (EmployeeRole)reader.GetOrdinal("Role"),
                                firstName = reader.GetString(reader.GetOrdinal("firstName")),
                                lastName = reader.GetString(reader.GetOrdinal("lastName")),
                                birthDate = reader.GetDateTime(reader.GetOrdinal("birthDate")),
                                address = reader.GetString(reader.GetOrdinal("address")),
                                phoneNumber = reader.GetString(reader.GetOrdinal("phoneNumber")),
                                salary = (Double)reader.GetDecimal(reader.GetOrdinal("salary")),
                                nickname = reader.GetString(reader.GetOrdinal("nickname")),
                                password = reader.GetString(reader.GetOrdinal("Password"))

                            };

                            items.Add(item);
                        }

                        return items;
                    }
                }
            }
        }


                public Employee GetItem(int id)
                {
                    using (var connection = new SqlConnection(_connectionString))
                    {
                        connection.Open();

                        var commandText = "SELECT * FROM Employee WHERE Id = @Id";
                        using (var command = new SqlCommand(commandText, connection))
                        {
                            command.Parameters.AddWithValue("@Id", id);

                            using (var reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    var item = new Employee
                                    {
                                        id = reader.GetInt32(reader.GetOrdinal("Id")),
                                        firstName = reader.GetString(reader.GetOrdinal("firstName")),
                                        email = reader.GetString(reader.GetOrdinal("email")),
                                        phoneNumber = reader.GetString(reader.GetOrdinal("phoneNumber"))
                                    };

                                    return item;
                                }

                                return null;
                            }
                        }
                    }
                }




        public void UpdateItem(Employee employee)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                var commandText = "UPDATE Employee SET firstName = @firstName, phoneNumber = @phoneNumber WHERE Id = @Id";
                using (var command = new SqlCommand(commandText, connection))
                {
                    command.Parameters.AddWithValue("@Id", employee.id);
                    command.Parameters.AddWithValue("@firstName", employee.firstName);
                    command.Parameters.AddWithValue("@phoneNumber", employee.phoneNumber);

                    command.ExecuteNonQuery();
                }
            }
        }



        public void DeleteItem(int id)
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    connection.Open();

                    var commandText = "DELETE FROM Employee WHERE Id = @Id";
                    using (var command = new SqlCommand(commandText, connection))
                    {
                        command.Parameters.AddWithValue("@Id", id);

                        command.ExecuteNonQuery();
                    }
                }
            }
            //public int ExecuteNonQuery(string query)
            //{
            //    using (var connection = new SqlConnection(_connectionString))
            //    {
            //        connection.Open();
            //        using (var command = new SqlCommand(query, connection))
            //        {
            //            return command.ExecuteNonQuery();
            //        }
            //    }
            //}
        }
    
}

