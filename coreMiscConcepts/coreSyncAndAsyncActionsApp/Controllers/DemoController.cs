using coreSyncAndAsyncActionsApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace coreSyncAndAsyncActionsApp.Controllers
{
    public class DemoController : Controller
    {
        // Blocking Approach (Sync Approach)
        public IActionResult Index()
        {
            var employees = getEmployeeList();
            return View(employees);
        }

        // Non-Blocking Approach (Async Approach)
        public async Task<IActionResult> Index1()
        {
            var employees = await getEmployeeList1();
            return View(employees);
        }

        public List<Employee> getEmployeeList()
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee { Id = 101, Name = "Gautam" },
                new Employee { Id = 102, Name = "Bhalla" },
                new Employee { Id = 103, Name = "Shreya" }
            };
            return employees;
        }

        public Task<List<Employee>> getEmployeeList1()
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee { Id = 101, Name = "Gautam" },
                new Employee { Id = 102, Name = "Bhalla" },
                new Employee { Id = 103, Name = "Shreya" }
            };
            return Task.FromResult(employees);
        }

        // Blocking Approach
        public IActionResult Index2()
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            ContentManagement contentManagement = new ContentManagement();
            var content = contentManagement.GetContent();
            var count = contentManagement.GetCount();
            var name = contentManagement.GetName();
            watch.Stop();
            ViewBag.WatchMilliSeconds = watch.ElapsedMilliseconds;
            return View();
        }

        // Non Blocking Approach
        public async Task<IActionResult> Index3()
        {
            Stopwatch watch = new Stopwatch();
            watch .Start();
            ContentManagement contentManagement = new ContentManagement();
            var contentTask = contentManagement.GetContentAsync();
            var countTask = contentManagement.GetCountAsync();
            var nameTask = contentManagement.GetNameAsync();

            var content = await contentTask;
            var count = await countTask;
            var name = await nameTask;
            watch.Stop();
            ViewBag.WatchMilliSeconds = watch.ElapsedMilliseconds;
            return View();
        }

    }
}
