using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Office.Web.Domain.IServices;
using Office.Web.Domain.Services;

namespace Office.Web.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [EnableCors("_myAllowSpecificOrigins")]
    public class DepartamentController : ControllerBase
    {
        private readonly IDepartamentService _departamentService;
        public DepartamentController( IDepartamentService departamentServicecs) 
        {
            _departamentService = departamentServicecs;
        }

        [HttpGet("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetDepartament(int id)
        {
            var dep = await _departamentService.GetDepartament(id);
            if (dep == null)
            {
                return NotFound();
            }
            return Ok(dep);
        }

        [HttpGet("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetEmployees(int id)
        {
            var dep = await _departamentService.GetEmployees(id);
            if (dep == null)
            {
                return NotFound();
            }
            return Ok(dep);
        }
    }
}
