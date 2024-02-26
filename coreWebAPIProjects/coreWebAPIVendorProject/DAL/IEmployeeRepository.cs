using coreWebAPIVendorProject.Models;

namespace coreWebAPIVendorProject.DAL
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> Employees { get; }
        Employee this[int id] { get; }
        Employee AddEmployee(Employee employee);
        Employee UpdateEmployee(Employee employee);
        void DeleteEmployee(int id);

    }
}
