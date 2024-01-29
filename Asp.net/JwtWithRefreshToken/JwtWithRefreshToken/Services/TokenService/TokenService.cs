using JwtWithRefreshToken.Models;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace JwtWithRefreshToken.Services.TokenService
{
    public class TokenService : ITokenService
    {
        private readonly IConfiguration _configuration;

        public TokenService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string CreateAccessToken(User user)
        {
            List<Claim> claims = new()
            {
                new Claim(ClaimTypes.Name, user.Username),
                //new Claim("userId", user.Id),
                //new Claim(ClaimTypes.Role, "Admin")
            };
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration.GetSection("AppSettings:Key").Value!));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);
            var token = new JwtSecurityToken(
                claims: claims,
                signingCredentials: creds,
                expires: DateTime.Now.AddDays(1));
            var jwtToken = new JwtSecurityTokenHandler().WriteToken(token);
            return jwtToken;
        }

        public RefreshToken GenerateRefreshToken()
        {
            return new RefreshToken()
            {
                Token = Convert.ToBase64String(RandomNumberGenerator.GetBytes(64)),
                Expires = DateTime.Now.AddDays(7),
                Created = DateTime.Now
            };
        }
    }
}
