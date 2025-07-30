using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using white_paper_master.Helpers;
using white_paper_master.Repository.Interfaces;
using white_paper_master.Services.Interfaces;
using static white_paper_master.Models.Common;

namespace white_paper_master.Services.Implementations
{
    public class AuthService : IAuthService
    {
        private readonly IAuthRepository _authRepository;
        private readonly IConfiguration _configuration;

        public AuthService(IAuthRepository authRepository, IConfiguration configuration)
        {
            _authRepository = authRepository;
            _configuration = configuration;
        }

        public async Task<(string Token, List<OfficeInfo> Offices)> AuthenticateAsync(string username, string password)
        {
            var offices = await _authRepository.GetOfficeInfoAsync(username, password);

            if (offices == null || !offices.Any())
                return (null, null);

            string token = JwtTokenGenerator.GenerateToken(username, _configuration);
            return (token, offices);
        }
    }
}
