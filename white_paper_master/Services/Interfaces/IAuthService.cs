using static white_paper_master.Models.Common;

namespace white_paper_master.Services.Interfaces
{
    public interface IAuthService
    {
        //Task<List<OfficeInfo>> GetOfficeInfoAsync(string username, string password);
        Task<(string Token, List<OfficeInfo> Offices)> AuthenticateAsync(string username, string password);
    }
}
