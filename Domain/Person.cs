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
        public string lastName { get; private set; }
        public DateTime birthDate { get; private set; }
        public string address { get; private set; }
        public string phoneNumber { get; set; }
        public decimal salary { get; private set; }
        public string nickname { get; private set; }
        public string password { get; private set; }
        public string email { get; set; }
        public string roleType { get; private set; }
        public Person() { }
        public Person(int id, string firstName, string lastName, DateTime birthDate, string address, string phoneNumber, decimal salary, string email, string nickname, string password, string roleType)
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
            this.roleType = roleType;
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
