using ConduitCloneAPI.Data;
using ConduitCloneAPI.Entities;
using Microsoft.AspNetCore.Mvc;


namespace ConduitCloneAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController:ControllerBase
    {
        private readonly ConduitCloneContext _context;
        private readonly ILogger<UserController> _logger;

        public UserController(ConduitCloneContext context, ILogger<UserController> logger)
        {
            _context = context;
            _logger = logger;
        }




        [HttpPost]
        public async Task<ActionResult> PostUser([FromBody]User user)
        {
            return Ok();
        }


    }
}
