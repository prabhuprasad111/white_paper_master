using Microsoft.EntityFrameworkCore;
using white_paper_master.Interface.Master;
using white_paper_master.Models;

public class MasterRepository : IMasterRepository
{
    private readonly StateDbContext _context;

    public MasterRepository(StateDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<object>> GetDistrictsAsync()
    {
        return await _context.m_district
            .Where(x => x.LANG_CD == 99 && x.STATE_CD == 24)
            .Select(x => new { x.DISTRICT_CD, x.DISTRICT })
            .ToListAsync();
    }

    public async Task<IEnumerable<object>> GetPoliceStationsAsync(int districtCd)
    {
        return await _context.m_police_station
            .Where(x => x.LANG_CD == 99 && x.STATE_CD == 24 && x.DISTRICT_CD == districtCd)
            .Select(x => new { x.PS_CD, x.PS })
            .ToListAsync();
    }
}