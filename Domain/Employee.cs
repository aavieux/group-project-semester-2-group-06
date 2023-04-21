using System;
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
        private List<Shift>? shifts;

        public Employee() : base() { }

        public Employee(int id, string email, int workingHours, UserRole role, string firstName, string lastName,
            DateTime birthDate, string address, string phoneNumber, decimal salary, string nickname, string password, EmployeeRole employeeRole, Department department)
            : base(role, firstName, lastName, birthDate, address, phoneNumber, salary, email, nickname, password, employeeRole, department)
        {
            this.workingHours = workingHours;
            this.employeeRole = employeeRole;
            this.shifts = shifts;
        }
        public Employee(int id,string firstName, string lastName, string phoneNumber, DateTime birthDate, string adress, decimal salary, string email, int workingHours) 
            : base(id,firstName, lastName, phoneNumber, birthDate, adress, salary, email)
        {
            this.workingHours += workingHours;
        }
        public Employee(string email, int workingHours, UserRole role, string firstName, string lastName,
            DateTime birthDate, string address, string phoneNumber, decimal salary, string nickname, string password, EmployeeRole employeeRole, Department department)
            : base(role, firstName, lastName, birthDate, address, phoneNumber, salary, email, nickname, password, employeeRole, department)
        {
            this.workingHours = workingHours;
            this.employeeRole = employeeRole;
            this.shifts = shifts;
        }

        public string GetFirstAndLastName()
        {
            return $"{firstName} {lastName}";
        }
        public string GetIdAndFirstAndLastName()
        {
            return $"Id: {id} || {GetFirstAndLastName()}";
        }

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
