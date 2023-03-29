using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Office.Web.Domain.Models;
using Office.Web.DAL;
using Office.Web.Domain.IServices;
using Microsoft.AspNetCore.Cors;

namespace Office.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("AllowOrigin")]
    public class UserController : ControllerBase
    {
        
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
           
            _userService = userService;
        }

       

        // GET: api/Users/5
        [HttpGet("{id}")]
        public ActionResult<UserModel> GetUser(int id)
        {
            var model = _userService.Get(id);

            if (model == null)
            {
                return BadRequest("Product not found");
            }

            return Ok(model);
        }

        // PUT: api/Users/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task <ActionResult<UserModel>> UpdateUser(int id, UserModel user)
        {
            var response = await _userService.Update(id,user);

            if (response == user)
            {
                return BadRequest("Product not updated");
            }

            return Ok(response);
        }

        // POST: api/Users
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult> Create(UserModel model)
        {
            var response = await _userService.Create(model);

            return Ok(response);
        }

       
        

       
    }
}
