using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using Ecommerce.Models;
using Ecommerce.Models.Dtos;
using Ecommerce.Services.Iservices;

namespace Ecommerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUser _userService;
        private readonly IJwt _jwtService;
        private readonly IMapper _mapper;


        public UserController(IMapper mapper, IUser user, IJwt jwt)
        {
            _userService = user;
            _mapper = mapper;
            _jwtService = jwt;
        }

        [HttpPost("register")]
        public async Task<ActionResult<string>> RegisterUser(AddUserDto addUserDto)
        {
            // Validate the addUserDto as needed
            // ...

            var user = new User
            {
                Name = addUserDto.Name,
                Email = addUserDto.Email,
                Password = BCrypt.Net.BCrypt.HashPassword(addUserDto.Password)
            };

            var checkUser = await _userService.GetUserByEmail(addUserDto.Email);
            if (checkUser != null)
            {
                return BadRequest("Email Already exists");
            }

            var response = await _userService.RegisterUser(user);
            return Ok(response);
        }

        [HttpPost("login")]
        public async Task<ActionResult<string>> LoginUser(LogUserDto userDto)
        {
            var checkUser = await _userService.GetUserByEmail(userDto.Email);
            if (checkUser == null)
            {
                return BadRequest("Invalid Credentials");
            }

            // Verify password
            var isCorrect = BCrypt.Net.BCrypt.Verify(userDto.Password, checkUser.Password);
            if (!isCorrect)
            {
                return BadRequest("Invalid Credentials");
            }

            var token = _jwtService.GenerateToken(checkUser);
            return Ok(token);
        }
    }
}

