using Comp.Model;
using Comp.Service;
using Microsoft.AspNetCore.Mvc;

namespace Comp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : Controller
    {

        public IEmployee _employeeService;
        public ICompany _comService;

        public EmployeeController(IEmployee employeeService,ICompany companyService)
        {
            _employeeService = employeeService;
            _comService = companyService;
        }


        [HttpGet("GetAll mployee")]
        public async Task<ActionResult<List<Employee>>> Get()
        {
            return Ok(_employeeService.GetEmployee());
        }

        [HttpGet("Getbyid/{id}")]
        public async Task<ActionResult<List<Employee>>> Getbyid(int id)
        {
            var emp = await _employeeService.GetById(id);
            //emp.Company = await _comService.GetById(emp.CompanyId);
            
            return Ok(emp);
        }

        [HttpPost("NewEmployee")]
        public async Task<ActionResult<List<Employee>>> NewEmployee(Employee newEmployee)
        {
            return Ok(_employeeService.AddEmployee(newEmployee));
        }
        [HttpPut("UpdateEmployee")]
        public async Task<ActionResult<List<Employee>>> UpdateEmployee(Employee Upd)
        {
            return Ok(_employeeService.UpdateEmployee(Upd));
        }
        [HttpDelete("DelteEmployee/{id}")]
        public async Task<ActionResult<List<Employee>>> DeleteEmployee(int id)
        {
            return Ok(_employeeService.DeleteEmployee(id));
        }
    }
}
