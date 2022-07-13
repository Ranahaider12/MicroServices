using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserMicroservices.Model;
using System.Web.Http.Cors;
using UserMicroservices.Repo;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UserMicroservices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        IUser _userRpo;
        public UserController(IUser repo) 
        {
            _userRpo = repo  ;
        }
      
        // GET: api/<UserController>
        [HttpGet]
        public List<UserList> GetUserList()
        {
            var data = _userRpo.GetUSers();
           
            return data;
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public string GetUserList(int id)
        {
            return "value";
        }

        // POST api/<UserController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
