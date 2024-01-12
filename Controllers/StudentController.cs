using Microsoft.AspNetCore.Mvc;
using SylviaCMiniChallenge.Models;
using SylviaCMiniChallenge.Services;

namespace SylviaCMiniChallenge.Controllers;

[ApiController]
[Route("StudentsController")]

    public class StudentController : ControllerBase
    {
    private readonly IStudentService _studentService;

    public StudentController(IStudentService studentService)
    {
        _studentService = studentService;
    }


        [HttpPost]
        [Route("AddStudent/{firstName}/{lastName}/{hobby}")]
        public List<Student> AddStudent(string firstName, string lastName, string hobby)
        {   
            return _studentService.AddStudent(firstName, lastName, hobby);
        }

        [HttpGet]
        [Route("GetStudent")]
        public List<Student> GetStudents()
        {
            return _studentService.GetStudents();
        }

        [HttpDelete]
        [Route("DeleteStudent/{firstName}")]
        public List<Student> DeleteStudent(string firstName)
        {
            return _studentService.DeleteStudent(firstName);
        }
    }
