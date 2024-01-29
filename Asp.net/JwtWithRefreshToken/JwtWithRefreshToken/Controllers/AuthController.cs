using JwtWithRefreshToken.Models;
using JwtWithRefreshToken.Models.Dtos;
using JwtWithRefreshToken.Services;
using JwtWithRefreshToken.Services.TokenService;
using JwtWithRefreshToken.Services.UserService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JwtWithRefreshToken.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly ITokenService _tokenService;
        private readonly IUserService _userService;
        public static User user = new();

        public AuthController(ITokenService tokenService, IUserService userService)
        {
            _tokenService = tokenService;
            _userService = userService;
        }

        [HttpPost("register")]
        public IActionResult Register(UserRequest request)
        {
            Hasher.CreatePasswordHash(request.Password, out byte[] passwordHash, out byte[] salt);
            user.Username = request.Username;
            user.PasswordHash = passwordHash;
            user.PasswordSalt = salt;

            return Ok();
        }

        [HttpPost("login")]
        public IActionResult Login(UserRequest request)
        {
            if (user.Username != request.Username || !Hasher.VerifyPasswordHash(request.Password, user.PasswordHash, user.PasswordSalt))
                return BadRequest("Invalid username or paswword");

            var accessToken = _tokenService.CreateAccessToken(user);
            var refreshToken = _tokenService.GenerateRefreshToken();
            SetRefreshtoken(refreshToken);

            return Ok(accessToken);
        }

        [HttpPost("refreshtoken")]
        public IActionResult RefreshToken()
        {
            var refreshToken = Request.Cookies["refreshToken"];
            if(refreshToken != user.RefreshToken)
                return Unauthorized();
            if (user.TokenExpires < DateTime.Now)
                return Unauthorized();
            string accessToken = _tokenService.CreateAccessToken(user);
            return Ok(accessToken);
        }

        private void SetRefreshtoken(RefreshToken refreshToken)
        {
            var cookieOptions = new CookieOptions
            {
                HttpOnly = true,
                Expires = refreshToken.Expires,
            };

            Response.Cookies.Append("refreshToken", refreshToken.Token, cookieOptions);
            user.TokenExpires = refreshToken.Expires;
            user.RefreshToken = refreshToken.Token;
            user.TokenCreated = refreshToken.Created;
        }

        [HttpGet("test")]
        [Authorize]
        public IActionResult Test()
        {
            var username = _userService.GetUsername();
            return Ok(username);
        }
    }
}
