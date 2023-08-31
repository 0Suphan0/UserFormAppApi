using Microsoft.AspNetCore.Mvc;
using UserWebApiProject.Database;
using UserWebApiProject.Entities;

namespace UserWebApiProject.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TestController : ControllerBase
    {
        private readonly DataContext _context;

        public TestController(DataContext context)
        {
            _context = context;
        }

        [HttpPost("SaveUser")]
        public IActionResult SaveUser([FromBody] User user)
        {
            if (user == null)
            {
                //eger user nesnesi bos gelirse..
                return BadRequest("User object is null");
            }

            //bos degilse context üzerinden db'ye kaydet.
            _context.Users.Add(user);
            _context.SaveChanges();

            return Ok();
        }
    }

}
