using Microsoft.AspNetCore.Mvc;
using WebApplication69.Models;

namespace WebApplication69.Controllers
{
    public class InstructorController : Controller
    {
        List<Instructor> InstructorList = new List<Instructor>
        {
            new Instructor()
            {
                FirstName = "Ronina", LastName = "Tayuan", Rank = Rank.AssistantProfessor, HiringDate = DateTime.Now, isTenured = true, ID = 1
            },
            new Instructor()
            {
                 FirstName = "Gabriel", LastName = "Montano", Rank = Rank.Instructor, HiringDate = DateTime.Now, isTenured= true, ID = 2
            },
            new Instructor()
            {
                 FirstName = "Jerralyn", LastName = "Padua", Rank = Rank.AssociateProfessor,    HiringDate = DateTime.Now, isTenured = false , ID = 3    
            }
        };

        public IActionResult Index()
        {
            return View(InstructorList);
        }
        public IActionResult ShowDetail(int id)
        {
            Instructor? instructor = InstructorList.FirstOrDefault(x => x.ID == id);
            if (instructor != null)
                return View(instructor);
            return NotFound();
           
        }
    }
}
