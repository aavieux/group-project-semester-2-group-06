﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Enums;

namespace Domain
{
    public class Employee : Person
    {
        public int workingHours { get; set; }
        public EmployeeRole employeeRole { get; set; }
        public List<Shift> shifts = new List<Shift>();
        public Employee() : base() { }

        public Employee(int id, string email, int workingHours, UserRole role, string firstName, string lastName,
            DateTime birthDate, string address, string phoneNumber, decimal salary, string nickname, string password, EmployeeRole employeeRole, Department department)
            : base(role, firstName, lastName, birthDate, address, phoneNumber, salary, email, nickname, password, employeeRole, department)
        {
            this.workingHours = workingHours;
            this.employeeRole = employeeRole;
        }
        public Employee(string email, int workingHours, UserRole role, string firstName, string lastName, 
            DateTime birthDate, string address, string phoneNumber, decimal salary, string nickname, string password, EmployeeRole employeeRole, Department department) 
            : base(role,firstName, lastName, birthDate, address, phoneNumber, salary, email, nickname, password, employeeRole, department)
        {
            this.workingHours = workingHours;
            this.employeeRole = employeeRole;
        }

        //public int Id()
        //{
        //    return id;
        //}
        public string GetInfo()
        {
            return $"{firstName} {lastName}";
        }
        public string GetIdAndName()
        {
            return $"Id: {id} || {GetInfo()}";
        }
        //public List<Shift> GetShifts()
        //{
        //    return shifts;
        //}
        public void SetId(int id)
        {
            base.id = id;
        }
        public void SetName(string name)
        {
            base.firstName=firstName;
        }
        public void SetPhone(string phone)
        {
            base.phoneNumber = phoneNumber;
        }
        public string GetFullName()
        {
            return $"{this.firstName} {this.lastName}";
        }
    }
}
