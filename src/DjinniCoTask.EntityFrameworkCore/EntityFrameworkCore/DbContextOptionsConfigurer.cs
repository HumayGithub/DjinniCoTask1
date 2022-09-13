using Microsoft.EntityFrameworkCore;

namespace DjinniCoTask.EntityFrameworkCore
{
    public static class DbContextOptionsConfigurer
    {
        public static void Configure(
            DbContextOptionsBuilder<DjinniCoTaskDbContext> dbContextOptions, 
            string connectionString
            )
        {
            /* This is the single point to configure DbContextOptions for DjinniCoTaskDbContext */
            dbContextOptions.UseSqlServer(connectionString);
        }
    }
}
