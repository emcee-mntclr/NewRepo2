using Microsoft.AspNetCore.Mvc;
using WebApplication69.Models;
using WebApplication69.Services;

namespace WebApplication69.Controllers
{
    public class InstructorController : Controller
    {
        private readonly IFakeData _dummyData;
        public InstructorController(IFakeData dummyData)
        {
            _dummyData = dummyData;
        }

        public IActionResult Index()
        {
            return View(_dummyData.InstructorList);
        }
        public IActionResult ShowDetail(int id)
        {
            Instructor? instructor = _dummyData.InstructorList.FirstOrDefault(x => x.ID == id);
            if (instructor != null)
                return View(instructor);
            return NotFound();
           
        }
        [HttpGet]
        public IActionResult AddIns()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult AddIns(Instructor instructor)
        {
            _dummyData.InstructorList.Add(instructor);
            return View("Index");
        }
        public IActionResult updateinstructor(int id)
        {

            Instructor? instructor = _dummyData.InstructorList.FirstOrDefault(t => t.ID == id);

            if (instructor != null)
            {
                return View(instructor);
            }
            return NotFound();
        }
        [HttpPost]
        public IActionResult updateinstructor(Instructor updateinstructor)
        {
            Instructor? instructor = _dummyData.InstructorList.FirstOrDefault(t => t.ID == updateinstructor.ID);

            if (instructor != null)
            {
                instructor.FirstName = updateinstructor.FirstName;
                instructor.LastName = updateinstructor.LastName;

            };

            return RedirectToAction("Index");
        }
        public IActionResult deleteinstructor(int id)
        {

            Instructor? instructor = _dummyData.InstructorList.FirstOrDefault(t => t.ID == id);

            if (instructor != null)
            {
                return View(instructor);
            }
            return NotFound();

        }
        [HttpPost]
        public IActionResult Delete(Instructor newInstructor)
        {
            Instructor? instructor = _dummyData.InstructorList.FirstOrDefault(st => st.ID == newInstructor.ID);
            if (instructor != null)
                _dummyData.InstructorList.Remove(instructor);
             return RedirectToAction("Index");
        }
    }
}

    

