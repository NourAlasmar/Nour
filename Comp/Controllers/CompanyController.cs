using Comp.Model;
using Comp.Service;
using Microsoft.AspNetCore.Mvc;

namespace Comp.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class CompanyController : Controller
    {
        public ICompany _CompanyService;

        public CompanyController(ICompany companyService)
        {
            _CompanyService = companyService;
        }

        [HttpGet("GetAllCompany")]
        public async Task<ActionResult<List<Company>>> Get()
        {
            return Ok(_CompanyService.GetCompany());
        }

        [HttpGet("Getbyid/{id}")]
        public async Task<ActionResult<List<Company>>> Getbyid(int id)
        {
            return Ok(_CompanyService.GetById(id));
        }

        [HttpPost("NewCompany")]
        public async Task<ActionResult<List<Company>>> NewCompany(Company newCompany)
        {
            return Ok(_CompanyService.AddCompany(newCompany));
        }
        [HttpPut("UpdateCompany")]
        public async Task<ActionResult<List<Company>>> UpdateCompany(Company Upd)
        {
            return Ok(_CompanyService.UpdateCompany(Upd));
        }
        [HttpDelete("DeleteCompany/{id}")]
        public async Task<ActionResult<List<Company>>> DeleteCompany(int id)
        {
            return Ok(_CompanyService.DeleteCompany(id));
        }


    }
}

