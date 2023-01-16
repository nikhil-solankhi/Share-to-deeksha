using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using app1.Models;

namespace AppReact.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {

        private readonly DBTESTContext _dbContext;

        public EmployeeController(DBTESTContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        [Route("GetEmployees")]
        public IActionResult GetEmployees() { 
            List<Employee> list = _dbContext.Employees.ToList();
            return StatusCode(StatusCodes.Status200OK, list);
        }

    }
}
