using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApidemo.Models;

namespace WebApidemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private static List<Student> _student = new List<Student>
        {
            new Student { Id = 1, Name = "Ajay", Department = "IT", Marks = 95 },
            new Student { Id = 2, Name = "Akash", Department = "EEE", Marks = 98 },
            new Student { Id = 3, Name = "Guru", Department = "IT", Marks = 97 },
            new Student { Id = 4, Name = "Harsa", Department = "CSE", Marks = 94 }
        };

        [HttpGet]
        public ActionResult<IEnumerable<Student>> GetStudentList()
        {
            return _student;
        }
        [HttpGet("{id}")]
        public ActionResult<Student> GetStudent(int id)
        {
            var student = _student.FirstOrDefault(p => p.Id == id);
            if (student == null)
            {
                return NotFound();
            }
            return student;
        }
        [HttpPost]
        public ActionResult<Student> PostStudent(Student student)
        {
            _student.Add(student);
            return CreatedAtAction(nameof(GetStudent), new { id = student.Id }, student);
        }

    }
}
