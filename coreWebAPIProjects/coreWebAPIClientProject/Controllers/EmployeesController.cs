using coreWebAPIClientProject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace coreWebAPIClientProject.Controllers
{
    public class EmployeesController : Controller
    {
        // GET: EmployeesController
        public async Task<IActionResult> Index()
        {
            List<Employee> employeeList = new List<Employee>();
            using(var httpClient = new HttpClient())
            {
                using(var response = await httpClient.GetAsync("http://localhost:5142/api/Employee"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    employeeList = JsonConvert.DeserializeObject<List<Employee>>(apiResponse);
                }
            }
            return View(employeeList);
        }



        // GET: EmployeesController/Details/5
        public async Task<IActionResult> Details(int id)
        {

            Employee employee = new Employee();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("http://localhost:5142/api/Employee/" + id))
                {
                   if(response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        employee = JsonConvert.DeserializeObject<Employee>(apiResponse);
                    }
                   else
                    {
                        ViewBag.StatusCode = response.StatusCode;
                    }
                }
            }
            return View(employee);
        }

        // GET: EmployeesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmployeesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Employee employee)
        {
            Employee emp = new Employee();
            using(var httpClient = new HttpClient())
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(employee), Encoding.UTF8, "application/json");
                using (var response = await httpClient.PostAsync("http://localhost:5142/api/Employee", content))
                {
                    string apiResonse = await response.Content.ReadAsStringAsync();
                    emp = JsonConvert.DeserializeObject<Employee>(apiResonse);
                }
            }
            return RedirectToAction("Index");
        }

        // GET: EmployeesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EmployeesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmployeesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EmployeesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
