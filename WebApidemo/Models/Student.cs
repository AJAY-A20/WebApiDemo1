using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace WebApidemo.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public int Marks { get; set; }
    }
}
