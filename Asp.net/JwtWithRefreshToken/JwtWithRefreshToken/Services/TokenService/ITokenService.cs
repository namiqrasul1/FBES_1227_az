using JwtWithRefreshToken.Models;

namespace JwtWithRefreshToken.Services.TokenService
{
    public interface ITokenService
    {
        string CreateAccessToken(User user);
        RefreshToken GenerateRefreshToken();
    }
}
