using WebApplication69.Models;
using WebApplication69.Services;
namespace WebApplication69.Services

{
    public interface  IFakeData
    {
        public List<Student> StudentList { get; }
        public List<Instructor> InstructorList { get; }
    }
}

