using SylviaCMiniChallenge.Models;

namespace SylviaCMiniChallenge.Services;

    public interface IStudentService
    {
        List<Student> GetStudents();
        List<Student> AddStudent(string firstName, string lastName, string hobby);
        List<Student> DeleteStudent(string firstName);
    }
