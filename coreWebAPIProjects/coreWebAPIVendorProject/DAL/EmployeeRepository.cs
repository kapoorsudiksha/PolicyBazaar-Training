using coreWebAPIVendorProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace coreWebAPIVendorProject.DAL
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private Dictionary<int, Employee> _employees;

        public EmployeeRepository() 
        {
            _employees = new Dictionary<int, Employee>();
            new List<Employee>()
            {
                new Employee { Id = 1, Name = "Gautam", Designation = "Developer" },
                new Employee { Id = 2, Name = "Bhalla", Designation = "Tester" },
                new Employee { Id = 3, Name = "Shreya", Designation = "Tester" },
            }.ForEach(e => AddEmployee(e));
        }

        public Employee this[int id] => _employees.ContainsKey(id) ? _employees[id] : null;

        public IEnumerable<Employee> Employees => _employees.Values;

        public Employee AddEmployee(Employee employee)
        {
            if(employee.Id == 0)
            {
                int key = _employees.Count;
                while(_employees.ContainsKey(key)) { key++;  }
                employee.Id = key;
            }
            _employees[employee.Id] = employee;
            return employee;
        }

        public void DeleteEmployee(int id)
        {
            _employees.Remove(id);
        }

        public Employee UpdateEmployee(Employee employee)
        {
            return AddEmployee(employee);
        }
    }
}
