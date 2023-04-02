using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Office.Web.Domain.IServices;
using Office.Web.Domain.Models;


namespace Office.Web.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [EnableCors("_myAllowSpecificOrigins")]
    public class DepartamentController : ControllerBase
    {
        private readonly IDepartamentService _departamentService;
        public DepartamentController( IDepartamentService departamentService) 
        {
            _departamentService = departamentService;
        }


        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> CreateDepartament([FromBody] DepartamentModel depModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var dep = await _departamentService.CreateDepartament(
                depModel.NameDepartament, 
                depModel.InfoDepartament, 
                depModel.ColorDepartamemnt
                );

            return CreatedAtAction(
                nameof(GetDepartament), 
                new { id = dep?.Id }, 
                new { dep?.Id, dep?.NameDepartament, dep?.InfoDepartament, dep?.ColorDepartamemnt }
                );
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
        [HttpPut("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdateDepartament(int id, [FromBody] DepartamentModel depModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if (await _departamentService.UpdateDepartament(
                id, 
                depModel.NameDepartament, 
                depModel.InfoDepartament, 
                depModel.ColorDepartamemnt
                ))
            {
                return NoContent();
            }
            else return NotFound();
        }

        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeleteDepartament(int id)
        {
            var deleted = await _departamentService.DeleteDepartament(id);
            if (!deleted)
            {
                return NotFound();
            }
            return Ok();
        }

        [HttpGet("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetDepartamentHead(int id)
        {
            var dep = await _departamentService.GetDepartamentHead(id);
            if (dep == null)
            {
                return NotFound();
            }
            return Ok(dep);
        }

        [HttpGet("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetDepartamentInfo(int id)
        {
            var dep = await _departamentService.GetInfo(id);
            if (dep == null)
            {
                return NotFound();
            }
            return Ok(dep);
        }


    }
}
