using fornax.Controllers.DTO;
using fornax.Core.Entities;
using fornax.Usecase.UserCase.Command;
using fornax.Usecase.UserCase.Query;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Org.BouncyCastle.Asn1.Ocsp;
using System;
using System.Net;
using System.Net.Http;

namespace fornax.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private readonly UserGetQuery userGetQuery;
        private readonly UserGetAllQuery userGetAllQuery;
        private readonly UserCreateCommand userCreateCommand;
        private readonly UserUpdateCommand userUpdateCommand;
        private readonly UserDeleteCommand userDeleteCommand;
        public UserController()
        {
            this.userGetQuery = new UserGetQuery();
            this.userGetAllQuery = new UserGetAllQuery();
            this.userCreateCommand = new UserCreateCommand();
            this.userUpdateCommand = new UserUpdateCommand();
            this.userDeleteCommand = new UserDeleteCommand();
        }

        [HttpGet("{id}")]
        public IActionResult GetUser(int id)
        {
            var user = userGetQuery.getUser(id);
            return user != null ? Ok(user) : NotFound();
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var user = userGetAllQuery.getAll();
            return user != null ? Ok(user) : NotFound();
        }

        [HttpPost]
        public IActionResult Post([FromBody] UserDTO user)
        {
            if (ModelState.IsValid)
            {
                userUpdateCommand.updateUser(user);
                return Created();
            }
            else
            {
                return BadRequest(ModelState);
            }
        }

        [HttpPut]
        public IActionResult Update([FromBody] UserDTO user)
        {
            if (ModelState.IsValid)
            {
                userCreateCommand.CreatedUser(user);
                return Created();
            }
            else
            {
                return BadRequest(ModelState);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult delete(int id)
        {
            try
            {
                userDeleteCommand.deletarUser(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
