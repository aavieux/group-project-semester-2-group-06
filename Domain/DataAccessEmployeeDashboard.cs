using System.Data.SqlClient;
using Domain.Enums;
using System.Diagnostics;
using System.Data;

namespace Domain;

public class DataAccessEmployeeDashboard
{
    private readonly string _connectionString;
    DataTable datatable;
    SqlDataAdapter reader;


    public DataAccessEmployeeDashboard(string connectionString)
    {
        _connectionString = connectionString;
    }
	//Manage Users(DB)
	public List<Employee> GetAllUsersFromDB()
    {
        bool yesOrNo = false;
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
	public bool UpdateEmployeeToDB(Employee employee)
	{
		using (var connection = new SqlConnection(_connectionString))
		{
			var commandText = "UPDATE Employee SET firstName = @firstName, lastName = @lastName, address = @address, salary = @salary, email = @email, "
							+ "workingHours = @workingHours, phoneNumber = @phoneNumber WHERE id = @id";
			using (var command = new SqlCommand(commandText, connection))
			{
				command.Parameters.AddWithValue("@id", employee.id);
				command.Parameters.AddWithValue("@firstName", employee.firstName);
				command.Parameters.AddWithValue("@lastName", employee.lastName);
				command.Parameters.AddWithValue("@address", employee.address);
				command.Parameters.AddWithValue("@salary", employee.salary);
				command.Parameters.AddWithValue("@email", employee.email);
				command.Parameters.AddWithValue("@workingHours", employee.workingHours);
				command.Parameters.AddWithValue("@phoneNumber", employee.phoneNumber);

                try
                {
                    connection.Open();
					int rowsAffected = command.ExecuteNonQuery();

					if (rowsAffected == 0)
					{
						return false;
                }
					else
                {
						return true;
                }
				}
				catch (Exception ex)
				{

					return false;

            }
				finally
				{
					connection.Close();
        }
    }
		}
	}

	public void AssignEmployeeToShiftToDB(Shift shift)
    {
        bool yesOrNo = false;
        using (var connection = new SqlConnection(_connectionString))
        {
            var commandText = "INSERT INTO Shift (date,shiftType,empid) VALUES (@Date,@ShiftType,@empid); SELECT SCOPE_IDENTITY()";
            using (var command = new SqlCommand(commandText, connection))
            {
                command.Parameters.AddWithValue("@empid", shift.emplId);
                command.Parameters.AddWithValue("@Date", shift.date);
                command.Parameters.AddWithValue("@ShiftType", shift.shiftType);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

            }
        }
    }

	//Manage Employees(DB)
	public List<Employee> GetEmployeesFromDB()
    {
        using (var connection = new SqlConnection(_connectionString))
        {
			connection.Open();

            var commandText = "SELECT * FROM Employee";
            using (var command = new SqlCommand(commandText, connection))
            {
				List<Employee> employees = new List<Employee>();
				try
				{
                using (var reader = command.ExecuteReader())
                {
						if (reader.Read())
						{
							Employee employee = new Employee
							{
								id = reader.GetInt32(reader.GetOrdinal("Id")),
								firstName = reader.GetString(reader.GetOrdinal("firstName")),
								lastName = reader.GetString(reader.GetOrdinal("lastName")),
								phoneNumber = reader.GetString(reader.GetOrdinal("phoneNumber")),
								birthDate = reader.GetDateTime(reader.GetOrdinal("birthDate")),
								address = reader.GetString(reader.GetOrdinal("address")),
								salary = reader.GetDecimal(reader.GetOrdinal("salary")),
								email = reader.GetString(reader.GetOrdinal("email")),
								workingHours = reader.GetInt32(reader.GetOrdinal("workingHours"))
							};

							employees.Add(employee);
						}

						return employees;
					}
				}
				catch (Exception)
                    {
					return null;
                    }

                    return items;
                }
            }
        }
    }
	public Employee GetEmployeeByIdFromDB(int id)
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
							lastName = reader.GetString(reader.GetOrdinal("lastName")),
							phoneNumber = reader.GetString(reader.GetOrdinal("phoneNumber")),
							birthDate = reader.GetDateTime(reader.GetOrdinal("birthDate")),
							address = reader.GetString(reader.GetOrdinal("address")),
							salary = reader.GetDecimal(reader.GetOrdinal("salary")),
                            email = reader.GetString(reader.GetOrdinal("email")),
							workingHours = reader.GetInt32(reader.GetOrdinal("workingHours"))
                        };

                        return item;
                    }

                    return null;
                }
            }
        }
    }
	public bool AddEmployeeToDB(Employee employee)
    {
		bool yesOrNo = false;
        using (var connection = new SqlConnection(_connectionString))
        {
			var commandText = "INSERT INTO Employee (firstName,lastName,birthDate,address,phoneNumber, salary, email, nickname,password,roleType,workingHours, role, department) VALUES (@Name,@LastName,@DateOfBirth,@Address,@PhoneNumber,@Salary,@Email,@Nickname, @Password, @Role, @WorkingHours, @Role1, @Department); SELECT SCOPE_IDENTITY()";
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
                command.Parameters.AddWithValue("@Department", employee.Department);
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
	public bool DeleteEmployeeByIdFromDB(int id)
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
    public Employee GetEmployeeById(int id)
    {
        string query = "SELECT * FROM Employee WHERE id = @id";
        datatable = new DataTable();
        List<Employee> employees = new List<Employee>();
        try
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                reader = new SqlDataAdapter();
                command.Parameters.AddWithValue("@id", id);
                connection.Open();
                reader.SelectCommand = command;
                reader.Fill(datatable);
                connection.Close();
                reader.Dispose();
                Employee employee;
                DataRow row = datatable.Rows[0];
                employee = new Employee((int)row[0], (string)row[7], (int)row[11], UserRole.Employee, (string)row[1], (string)row[2], (DateTime)row[3], (string)row[4],
                   (string)row[5], (decimal)row[6], (string)row[8], (string)row[9], EmployeeRole.JuniorSales, (Department)row[13]);
                return employee;

            }
        }
        catch (Exception)
        {

            throw;
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

