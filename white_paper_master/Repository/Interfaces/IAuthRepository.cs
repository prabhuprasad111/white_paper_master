using static white_paper_master.Models.Common;

namespace white_paper_master.Repository.Interfaces
{
    public interface IAuthRepository
    {
        //Task<bool> AuthenticateAsync(string username, string password);
        Task<List<OfficeInfo>> GetOfficeInfoAsync(string username, string password);

    }
}
