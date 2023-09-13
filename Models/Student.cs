namespace WebApplication69.Models;
using WebApplication69.Models;
using Microsoft.AspNetCore.Mvc;


public enum Course
{
    BSIT, BSIS,BSCS,OTHER
}
    public class Student
    {

    public int id { get; set; }
    public string Fname { get; set; }
    public string Lname { get; set; }   
    public DateTime dateenrolled { get; set; }  
    public Course course { get  ; set; }    
    public string email { get; set; }   




    }


