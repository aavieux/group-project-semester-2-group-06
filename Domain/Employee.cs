using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Employee:Person
    {
        public int workingHours { get; set; }
        public EmployeeRole role { get; set; }
        private List<Shift> shifts;
        public Employee() : base() { }
       
        public Employee(string email,int workingHours, EmployeeRole role,  string firstName, string lastName, DateTime birthDate, string address, string phoneNumber, double salary, string nickname, string password) :base(email, firstName,  lastName, birthDate,  address,  phoneNumber,  salary,  nickname, password)
        {
            this.workingHours = workingHours;
            this.role = role;
            this.shifts = shifts;
        }
        public Employee(string email, int workingHours,  string firstName, string lastName, DateTime birthDate, string address, string phoneNumber, double salary, string nickname, string password) : base(email, firstName, lastName, birthDate, address, phoneNumber, salary, nickname, password)
        {
            this.workingHours = workingHours;
            this.role = role;
            this.shifts = shifts;
        }

        public int Id()
        {
            return id;
        }
        public string GetEmployee()
        {
            return $"Id:{id},Name:{firstName}, Password:{password}";
        }
        public List<Shift> GetShifts()
        {
            return shifts;  
        }
    }
}
