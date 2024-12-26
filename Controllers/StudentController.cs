using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;
using WebApplication2.Data;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class StudentController : Controller
    {
        private readonly ApplicationDBContext _db;
        public StudentController(ApplicationDBContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable <Student> allStudent = _db.Students;


            return View(allStudent);
        }
        // GET METHOD
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        //POST
        public IActionResult Create(Student obj)
        {
            _db.Students.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}
