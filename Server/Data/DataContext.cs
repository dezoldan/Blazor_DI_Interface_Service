using Microsoft.EntityFrameworkCore;
using static Blazor_DI_Interface_Service.Shared.BaseTabela;

namespace Blazor_DI_Interface_Service.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<TotalBaseDaddos>? TblTotalBase { get; set; }
    }
}
