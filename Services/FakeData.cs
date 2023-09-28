using WebApplication69.Services;
using System;
using WebApplication69.Models;


namespace WebApplication69.Services
{
    public class FakeData : IFakeData
    {

        public List<Student> StudentList { get; }
        public List<Instructor> InstructorList { get; }

        public FakeData()
        {
            StudentList = new List<Student>()
            {
                new Student()
                {
                    Fname = "Lennard",
                    Lname = "Ramos",
                    course = Course.BSIT,
                    dateenrolled = DateTime.Now,
                    email = "lennard.ramos.cics@ust.edu.ph",
                    id = 1
                },

            new Student()
            {
                Fname = "Joshua",
                Lname = "Rembulat",
                course = Course.BSIT,
                dateenrolled = DateTime.Now,
                email = "joshua.rembulat.cics@ust.edu.ph",
                id = 2
            },
            new Student()
            {
                Fname = "Elpidio",
                Lname = "Monteclaro",
                course = Course.BSIT,
                dateenrolled = DateTime.Now,
                email = "elpidio.monteclaro.cics@ust.edu.ph",
                id = 3
            },
            new Student()
            {
                Fname = "Jes",
                Lname = "Libit",
                course = Course.OTHER,
                dateenrolled = DateTime.Now,
                email = "jes.libit.cics@ust.edu.ph",
                id = 4
            }
            };
            InstructorList = new List<Instructor>()
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
        }
    }
}

            


           
    

        
        
                