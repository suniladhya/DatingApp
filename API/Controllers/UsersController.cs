using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly DataContext _context;
        public UsersController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        // public ActionResult<IEnumerable<AppUser>> Get(){
        //     var users = _context.Users.ToList();
        //     return users;
        // }
        public async Task<ActionResult<IEnumerable<AppUser>>> Get(){
            var users = await _context.Users.ToListAsync();
            return users;
        }


        // api/users/3
        [HttpGet("{id}")]
        public ActionResult<AppUser> GetUser(int id){
            // var user = 
            return _context.Users.Find(id);
            // return user; // if not doing any operation direct return.
        }
    }
}