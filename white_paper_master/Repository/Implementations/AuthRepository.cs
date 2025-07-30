using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;
using System.Text;
using white_paper_master.Helpers;
using white_paper_master.Models;
using white_paper_master.Repository.Interfaces;
using static white_paper_master.Models.Common;
namespace white_paper_master.Repository.Implementations
{
    public class AuthRepository : IAuthRepository
    {
        private readonly StateDbContext _context; // Add a DbContext field

        private const string expectedUsername = "admin";
        private const string expectedPasswordHash = "f4c9e0b1944c8e0da1c5c4068b80f7deea53cc2200e2357c964508d8f96264cd";
    
        public AuthRepository(StateDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<List<OfficeInfo>> GetOfficeInfoAsync(string username, string password)
        {
            string hashedPassword = PasswordHasher.ConvertUserNamePasswordToSHA512(username.Trim(), password.Trim());

            return await _context.OfficeInfoResults
                .FromSqlRaw("EXEC UDP_GET_LOGIN_CMS_NEW @LOGIN_ID={0}, @LOGIN_PASSWORD={1}, @LANG_CD={2}",
                             username, hashedPassword, 99)
                .ToListAsync();
        }


    }
}

