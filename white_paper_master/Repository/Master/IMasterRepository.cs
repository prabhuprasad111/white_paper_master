namespace white_paper_master.Interface.Master
{
    public interface IMasterRepository
    {
        Task<IEnumerable<object>> GetDistrictsAsync();
        Task<IEnumerable<object>> GetPoliceStationsAsync(int districtCd);
    }
}
