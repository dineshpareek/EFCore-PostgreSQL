using EFCore_PostgreSQL.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EFCore_PostgreSQL.Controllers
{
    public class UserController : Controller
    {
        [Produces("application/json")]
        [Route("api/Users")]
        public class UsersController : Controller
        {
            private MyWebApiContext _context;

            public UsersController(MyWebApiContext context)
            {
                _context = context;
            }
            protected override void Dispose(bool disposing)
            {
                _context.Dispose();
            }

            public ActionResult GetUsers()
            {
                var usersToReturn = _context.Users.Include(u => u.Group).ToList();
                return Ok(usersToReturn);
            }
        }
    }
}
