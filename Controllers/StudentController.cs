using Microsoft.AspNetCore.Mvc;
using WebApplication2.Data;
using WebApplication2.Models;

public class StudentController : Controller
{
    private readonly ApplicationDBContext _db;
    public StudentController(ApplicationDBContext db)
    {
        _db = db;
    }

    public IActionResult Index()
    {
        IEnumerable<Student> allStudent = _db.Students;
        return View(allStudent);
    }

    // GET Method for Create
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    // POST Method for Create
    public IActionResult Create(Student obj)
    {
        if (ModelState.IsValid)
        {
            _db.Students.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        return View(obj);
    }

    // GET Method for Edit
    public IActionResult Edit(int? id)
    {
        if (id == null || id == 0)
        {
            return NotFound();
        }

        var obj = _db.Students.Find(id);
        if (obj == null)
        {
            return NotFound();
        }
        return View(obj);
    }

    // POST Method for Edit
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Edit(Student obj)
    {
        if (ModelState.IsValid)
        {
            _db.Students.Update(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        return View(obj);
    }


    // GET Method Delete
    public IActionResult Delete(int? id)
    {
        if (id == null || id == 0)
        {
            return NotFound();
        }

        var obj = _db.Students.Find(id);
        if (obj == null)
        {
            return NotFound();
        }
        _db.Students.Remove(obj);
        _db.SaveChanges();
        return RedirectToAction("Index");
    }





}
