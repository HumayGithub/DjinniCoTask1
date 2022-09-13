using DjinniCoTask.Configuration;
using DjinniCoTask.Web;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace DjinniCoTask.EntityFrameworkCore
{
    /* This class is needed to run EF Core PMC commands. Not used anywhere else */
    public class DjinniCoTaskDbContextFactory : IDesignTimeDbContextFactory<DjinniCoTaskDbContext>
    {
        public DjinniCoTaskDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<DjinniCoTaskDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            DbContextOptionsConfigurer.Configure(
                builder,
                configuration.GetConnectionString(DjinniCoTaskConsts.ConnectionStringName)
            );

            return new DjinniCoTaskDbContext(builder.Options);
        }
    }
}