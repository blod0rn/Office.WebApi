
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Office.Web.Domain.IServices;
using Office.Web.Domain.Models;


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

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> CreateEmployee([FromBody] EmployeeModel employeeModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var employee = await _employeeService.CreateEmployee(
                employeeModel.FirstName,
                employeeModel.MiddleName,
                employeeModel.LastName,
                employeeModel.Post,
                employeeModel.WorkloadId,
                employeeModel.DepartamentId,
                employeeModel.Skills,
                employeeModel.IsDepartamentHead
                );
            
            return CreatedAtAction(
                nameof(GetEmployee),
                new { id = employee?.Id },
                new { 
                    employee?.Id, 
                    employee?.FirstName, 
                    employee?.MiddleName, 
                    employee?.LastName,
                    employee?.Post,
                    employee?.WorkloadId,
                    employee?.DepartamentId,
                    employee?.Skills,
                    employee?.IsDepartamentHead
                }
                );
        }

        [HttpGet("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetEmployee(int id)
        {
            var employee = await _employeeService.GetEmployee(id);
            if (employee == null)
            {
                return NotFound();
            }
            return Ok(employee);
        }
        [HttpPut("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdateEmployee(int id, [FromBody] EmployeeModel employeeModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if (await _employeeService.UpdateEmployee(
                id,
                employeeModel.FirstName,
                employeeModel.MiddleName,
                employeeModel.LastName,
                employeeModel.Post,
                employeeModel.WorkloadId,
                employeeModel.DepartamentId,
                employeeModel.Skills,
                employeeModel.IsDepartamentHead
                ))
            {
                return NoContent();
            }
            else return NotFound();
        }
        
        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeleteEmployee(int id)
        {
            var deleted = await _employeeService.DeleteEmployee(id);
            if (!deleted)
            {
                return NotFound();
            }
            return Ok();
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
