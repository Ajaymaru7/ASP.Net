using G_Prg_Student.Models;
using System.Web.Mvc;

public class StudentController : Controller
{
    // GET: Student
    public ActionResult Index()
    {
        // Simulate data retrieval from a database
        var student = new Student
        {
            StudentID = 1,
            StudentName = "John Doe",
            Age = 20
        };

        return View(student);
    }

    // GET: Student/Edit/1
    public ActionResult Edit(int id)
    {
        // Simulate data retrieval from a database using the student ID
        var student = new Student
        {
            StudentID = id,
            StudentName = "Jane Smith",
            Age = 22
        };

        return View(student);
    }
}
