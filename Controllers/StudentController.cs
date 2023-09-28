using Microsoft.AspNetCore.Mvc;
using WebApplication69.Models;
using WebApplication69.Services;

namespace WebApplication69.Controllers
{
    public class StudentController : Controller
    {

        private readonly IFakeData _dummyData;

        public StudentController(IFakeData dummyData)
        {
            _dummyData = dummyData;
        }

        public IActionResult Index()
        {
            return View(_dummyData.StudentList);
        }
        public IActionResult ShowDetails(int id)
        {
            Student? student = _dummyData.StudentList.FirstOrDefault(x => x.id == id);
            if (student != null)
                return View(student);
            return NotFound();

        }
        [HttpGet]
        public IActionResult AddStudent()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddStudent(Student newstudent)
        {

            _dummyData.StudentList.Add(newstudent);
            return RedirectToAction("Index");
        }
        public IActionResult updatestudent(int id)
        {

            Student? student = _dummyData.StudentList.FirstOrDefault(t => t.id == id);

            if (student != null)
            {
                return View(student);
            }
            return NotFound();
        }
        [HttpPost]
        public IActionResult updatestudent(Student updatestudent)
        {
            Student? student = _dummyData.StudentList.FirstOrDefault(t => t.id == updatestudent.id);

            if (student != null)
            {
                student.Fname = updatestudent.Fname;
                student.Lname = updatestudent.Lname;
                student.email = updatestudent.email;
                student.course = updatestudent.course;
            };

            return  RedirectToAction("Index");
        }
        public IActionResult deletestudent(int id)
        {

            Student? student = _dummyData.StudentList.FirstOrDefault(t => t.id == id);

            if (student != null)
            {
                return View(student);
            }
            return NotFound();

        }
        [HttpPost]
        public IActionResult Delete(Student newStudent)
        {
            Student? student = _dummyData.StudentList.FirstOrDefault(st => st.id == newStudent.id);
            if (student != null)
                _dummyData.StudentList.Remove(student);
            return RedirectToAction("Index");
        }
    }
}

    
