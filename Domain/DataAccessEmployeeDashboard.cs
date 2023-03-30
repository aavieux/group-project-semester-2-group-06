﻿using System.Data.SqlClient;
using Domain.Enums;

namespace Domain;

public class DataAccessEmployeeDashboard
{
    private readonly string _connectionString;

    public DataAccessEmployeeDashboard(string connectionString)
    {
        _connectionString = connectionString;
    }
    public bool AddItem(Employee employee)
    {
        bool yesOrNo = false;
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
                command.Parameters.AddWithValue("@Salary", Convert.ToDecimal(employee.salary));
                command.Parameters.AddWithValue("@Email", employee.email);
                command.Parameters.AddWithValue("@Nickname", employee.nickname);
                command.Parameters.AddWithValue("@Password", employee.password);
                command.Parameters.AddWithValue("@Role", employee.employeeRole);
                command.Parameters.AddWithValue("@WorkingHours", employee.workingHours);
                command.Parameters.AddWithValue("@Role1", employee.employeeRole);

                try
                {
                    connection.Open();
                    var id = (int)command.ExecuteScalar();
                    employee.SetId(id);
                    yesOrNo = true;
                    return yesOrNo;
                }
                catch (Exception)
                {
                    yesOrNo = true;
                    return yesOrNo;
                }
                
            }
        }
    }
    public List<Employee> GetAllUsers()
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
                        var item = new Employee(reader.GetString(reader.GetOrdinal("email")),
                            reader.GetInt32(reader.GetOrdinal("workingHours")), Enum.Parse<UserRole>(reader.GetString(reader.GetOrdinal("Role"))), reader.GetString(reader.GetOrdinal("firstName")), reader.GetString(reader.GetOrdinal("lastName")),
                            reader.GetDateTime(reader.GetOrdinal("birthDate")), reader.GetString(reader.GetOrdinal("address")), reader.GetString(reader.GetOrdinal("phoneNumber")), (Decimal)reader.GetDecimal(reader.GetOrdinal("salary")),
                            reader.GetString(reader.GetOrdinal("nickname")), reader.GetString(reader.GetOrdinal("Password")), Enum.Parse<EmployeeRole>(reader.GetString(reader.GetOrdinal("roleType"))));
                        item.id = (int)reader["ID"];

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

