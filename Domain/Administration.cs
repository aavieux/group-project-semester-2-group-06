﻿using DataManagement;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain;

public class Administration
{
    List<Person> people = new List<Person>();
    SqlHelperG sqlHelper = new SqlHelperG();
    DataAccessEmployeeDashboard data = new DataAccessEmployeeDashboard("Server=mssqlstud.fhict.local;Database=dbi501511_bazaar;User Id=dbi501511_Bazaar;Password=Samocska;");
    public void RemoveEmployee(Employee employee) { }

    public void EditEmployee(Employee employee) { }

    public Person? CheckLogIn(string nickname, string password)
    {
        GeneratePeopleFromDB();
        foreach (Person person in people)
        {
            if (person.nickname== nickname && person.password == password)
            {
                return person;
            }
        }
        return null;
    }
    private void GeneratePeopleFromDB()
    {
        people.Clear();
        DataTable dt = sqlHelper.ReadPeopleFromDB();
        foreach (DataRow row in dt.Rows)
        {
            Person person;
            person = new Person((int)row[0], (string)row[1], (string)row[2], (DateTime)row[3], (string)row[4], (string)row[5], (decimal)row[6], (string)row[7], (string)row[8], (string)row[9], Enum.Parse<UserRole>((string)row[10]));
            people.Add(person);
        }
    }
    public List<Person> GetAllPeople()
    {
        GeneratePeopleFromDB();
        return people;
    }
    public Employee LogInEmployee (string nicknameOrEmail, string password)
    {
        foreach (Employee user in data.GetAllUsersFromDB())
        {
            if ((nicknameOrEmail == user.email || nicknameOrEmail == user.nickname) && password == user.password)
            {
                return user;
            }
        }
        throw new ArgumentException("Wrong login credentials!");
    }
    public void UpdateEmployeePassword(int id, string newPassword)
    {
        sqlHelper.UpdateEmployeePassword(id, newPassword);
    }
    public Employee GetEmployeeById(int id)
    {
        return data.GetEmployeeByIdFromDB(id);
    }
}
