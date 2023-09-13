namespace WebApplication69.Models;
using WebApplication69.Models;
using Microsoft.AspNetCore.Mvc;

public enum Rank
{
    Instructor, AssistantProfessor, AssociateProfessor, Professor
}
public class Instructor
{
    public int ID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public Rank Rank { get; set; }
    public DateTime HiringDate { get; set; }
    public bool isTenured { get; set; }

}
