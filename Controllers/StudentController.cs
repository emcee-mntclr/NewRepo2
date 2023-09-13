using Microsoft.AspNetCore.Mvc;
using WebApplication69.Models;

namespace WebApplication69.Controllers
{
    public class StudentController : Controller
    {
        List<Student> StudentList = new List<Student>
        {
            new Student()
            {
                Fname = "Lennard", Lname = "Ramos", course = Course.BSIT, dateenrolled = DateTime.Now, email = "lennard.ramos.cics@ust.edu.ph" , id = 1
            },
            new Student() 
            {
                Fname = "Joshua", Lname = "Rembulat", course = Course.BSIT, dateenrolled = DateTime.Now, email = "joshua.rembulat.cics@ust.edu.ph" , id = 2
            },
            new Student()
            {
                Fname = "Elpidio", Lname = "Monteclaro", course = Course.BSIT, dateenrolled = DateTime.Now, email = "elpidio.monteclaro.cics@ust.edu.ph" , id = 3
            },
            new Student()
            {
                Fname = "Jes", Lname = "Libit", course = Course.OTHER, dateenrolled = DateTime.Now, email = "jes.libit.cics@ust.edu.ph" , id = 4
            }

        };
        
        public IActionResult Index()
        {
            return View(StudentList);
        }
        public IActionResult ShowDetails(int id)
        {
            Student? student = StudentList.FirstOrDefault(x => x.id == id);
            if (student != null)
                return View(student);
            return NotFound();

        }
    }
}
