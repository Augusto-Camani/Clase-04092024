using Application.Services;
using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService; 
        }

        [HttpGet]
        public ActionResult<List<User>> Get(){
            return _userService.Get().ToList();
        }

        [HttpPost]
        public IActionResult Add([FromQuery] User user){
            _userService.Add(user);
            return NoContent();
        }
    }
}
