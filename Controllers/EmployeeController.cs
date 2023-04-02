using AutoMapper;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Office.Web.DAL;
using Office.Web.Domain.IServices;
using Office.Web.Domain.Services;

namespace Office.Web.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [EnableCors("_myAllowSpecificOrigins")]
    public class EmployeeController: ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController (IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetEmployeeInfo(int id)
        {
            var dep = await _employeeService.GetEmployeeInfo(id);
            if (dep == null)
            {
                return NotFound();
            }
            return Ok(dep);
        }
    }
}
