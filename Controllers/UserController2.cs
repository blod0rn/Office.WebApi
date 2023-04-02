using Microsoft.AspNetCore.Mvc;
using Office.Web.Domain.Models;
using Office.Web.Domain.IServices;
using Microsoft.AspNetCore.Cors;


namespace Office.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("_myAllowSpecificOrigins")]
    public class UserController2 : ControllerBase
    {
        
        private readonly IUserService2 _userService2;
        
        public UserController2(IUserService2 userService)
        {
           
            _userService2 = userService;
        }


        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Create([FromBody] UserModelDto userDto)
        {      
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var user = await _userService2.Create(userDto.NameUser, userDto.Email, userDto.Password);
            return CreatedAtAction(nameof(GetUser), new { id = user?.Id }, new { user?.Id, user?.NameUser, user?.Email, user?.Password });
        }

        [HttpGet("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetUser(int id)
        {
            var user = await _userService2.Get(id);
            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }

        [HttpPut("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Update(int id, [FromBody] UserModelDto userDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if (await _userService2.Update(id, userDto.NameUser, userDto.Email, userDto.Password))
            {
                return NoContent();
            }
            else return NotFound();  
            
            
        }

        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeleteUser(int id)
        {
            var deleted = await _userService2.Delete(id);
            if (!deleted)
            {
                return NotFound();
            } 
            return Ok();
        }


    }
}
