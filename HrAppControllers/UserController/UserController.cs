
using HrAppBusiness.UserRepository;
using HrAppDataAcces;
using HrAppDataAcces.DTOs;
using HrAppDataAcces.Entities;
using Microsoft.AspNetCore.Mvc;

namespace HrAppControllers.UserController
{
    [ApiController]
        [Route("api/[controller]")]
        public class UserController : ControllerBase
        {
        private readonly DataBaseContext _context;
        private readonly IUserRepository _userRepository;

        public UserController( DataBaseContext context ,IUserRepository userRepository)
            {
            _context = context;
            _userRepository = userRepository;
            }

            [HttpPost]
            public async Task<ActionResult> CreateUser([FromBody] UserPostDto user)
            {
          var result =   _userRepository.CreateUser(user);
            return Ok(result);
            }
        [HttpGet]
        public async Task<ActionResult> GetUsers()
        {
            var users = _context.Users.ToList();
            return Ok(users);
        }
    }
    }


