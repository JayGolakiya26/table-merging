using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using task_02.Models;

namespace task_02.Controllers
{
    public class UserController : Controller
    {
        private readonly myContext _context;

        public UserController(myContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            // Retrieve data from the database (e.g., list of students) and pass it to the view
            var students = _context.students.ToList(); // Assuming Students is the DbSet in MyContext
            return View(students); // Specify the view and pass the data
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(student student)
        {
            if (ModelState.IsValid)
            {
                _context.students.Add(student);
                _context.SaveChanges();
                return RedirectToAction("Index"); // Redirect to the Index action after adding a student
            }
            // If the ModelState is not valid, return to the Add view with validation errors
            return View(student);
        }
    }
}
