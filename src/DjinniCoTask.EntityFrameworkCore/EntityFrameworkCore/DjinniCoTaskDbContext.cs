using Abp.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DjinniCoTask.EntityFrameworkCore
{
    public class DjinniCoTaskDbContext : AbpDbContext
    {
        //Add DbSet properties for your entities...

        public DjinniCoTaskDbContext(DbContextOptions<DjinniCoTaskDbContext> options) 
            : base(options)
        {

        }
    }
}
