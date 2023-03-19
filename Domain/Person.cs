using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Person
    {
        private int id;
        private string firstName;
        private string lastName;
        private DateTime birthDate;
        private string address;
        private string phoneNumber;
        private double salary;
        private string nickname;
        private string password;
        public Person(int id, string firstName, string lastName, DateTime birthDate, string address, string phoneNumber, double salary, string nickname, string password)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.birthDate = birthDate;
            this.address = address;
            this.phoneNumber = phoneNumber;
            this.salary = salary;
            this.nickname = nickname;
            this.password = password;
        }
    
        public  string GetName()
        {
            return this.firstName;
        }
        public  string GetAddress() 
        {
            return this.address;
                }
        public void ChangeName(string name) { this.firstName = name; }
        public double GetSalary() { return this.salary; }
        public void SetSalary(double salary) { this.salary= salary; }   
    }
}
