using coreWebAPIVendorProject.DAL;
using coreWebAPIVendorProject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace coreWebAPIVendorProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private IEmployeeRepository repository;
        public EmployeeController(IEmployeeRepository repo)
        {
            repository = repo;
        }

        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            return repository.Employees;
        }

        [HttpGet("{id}")]
        public ActionResult<Employee> Get(int id)
        {
            if (id == 0)
                return BadRequest("Bad Request Heree");
            return Ok(repository[id]);
        }

        [HttpPost]
        public Employee Post([FromBody]Employee employee)
        {
            repository.AddEmployee(new Employee 
            {
                Name = employee.Name,
                Designation = employee.Designation
            });
            return employee;
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            repository.DeleteEmployee(id);
        }

        [HttpPut]
        public Employee Put(Employee employee)
        {
            return repository.UpdateEmployee(employee);
        }
    }
}
