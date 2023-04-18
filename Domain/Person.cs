using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Person
    {
        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public DateTime birthDate { get;  set; }
        public string address { get; set; }
        public string phoneNumber { get; set; }
        public decimal salary { get;  set; }
        public string nickname { get;set; }
        public string password { get;  set; }
        public string email { get; set; }
        public UserRole userRole { get;  set; }
        public EmployeeRole employeeRole { get; private set; }  
        public Person() { }
        public Person(int id, string firstName, string lastName, DateTime birthDate, string address, string phoneNumber, decimal salary, string email, string nickname, string password, UserRole roleType)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.birthDate = birthDate;
            this.address = address;
            this.phoneNumber = phoneNumber;
            this.salary = salary;
            this.email = email;
            this.nickname = nickname;
            this.userRole = roleType;
            this.employeeRole = employeeRole;
            this.password = password;
        }
        public Person(UserRole roleType,string firstName, string lastName, DateTime birthDate, string address, string phoneNumber, decimal salary, string email, string nickname, string password, EmployeeRole employeeRole)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.birthDate = birthDate;
            this.address = address;
            this.phoneNumber = phoneNumber;
            this.salary = salary;
            this.email = email;
            this.nickname = nickname;
            this.userRole = roleType;
            this.password = password;
        }
        //public string GetName()
        //{
        //    return this.firstName;
        //}
        //public string GetAddress()
        //{
        //    return this.address;
        //}
        public void ChangeName(string name) { this.firstName = name; }
        //public double GetSalary() { return this.salary; }
        public void SetSalary(decimal salary) { this.salary = salary; }
        
    }
}
