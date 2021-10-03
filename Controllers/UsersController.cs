using WebService.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebService.Entities;
using Microsoft.EntityFrameworkCore;

namespace WebService.Controllers
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

        public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers() //IE nos eprmite tratar tipos localmente
        {
            return await _context.Users.ToListAsync();
        }

        [HttpGet("{id}")]
        [Route("{id}")]
        public ActionResult<AppUser> GetUser(int id)
        {
            return  _context.Users.Find(id);
        }

    }
}