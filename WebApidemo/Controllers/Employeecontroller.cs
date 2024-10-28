using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApidemo.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class Employeecontroller : ControllerBase
    {
        [HttpGet]
        public string getString()
        {
            return "Hello";
        }
        [HttpGet]
        public string getEmployees()
        {
            return "Employees";
        }
    }
}
