using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using OData_API_Dotnet8.Services;

namespace OData_API_Dotnet8.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
       private EmployeeService _employeeService;
        public EmployeesController(EmployeeService employeeService)
        {
                _employeeService = employeeService;
        }
        [EnableQuery(PageSize =5)]
        public IActionResult Get() => Ok(_employeeService.GetEmployees());
    }
}
