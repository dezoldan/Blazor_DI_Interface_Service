using Blazor_DI_Interface_Service.Server.Data;
using Microsoft.EntityFrameworkCore;

namespace Blazor_DI_Interface_Service.Server.BaseServices
{
    public class BaseService : IBaseService
    {
        private readonly DataContext _context;
        public BaseService(DataContext context)
        {
            _context = context;
        }
        public async Task<int> DevolveNumTotalRegsBase()
        {
            return await _context.TblTotalBase!.Select(x => x.TotalBase).FirstOrDefaultAsync();
        }
    }
}