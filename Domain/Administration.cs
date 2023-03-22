using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Administration
    {
        List<Employee> employees;   
        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }
        public void RemoveEmployee(Employee employee) { }
        public void EditEmployee(Employee employee) { }
    }
}
