using HMSystem.Configuration;
using HMSystem.Web;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace HMSystem.EntityFrameworkCore
{
    /* This class is needed to run EF Core PMC commands. Not used anywhere else */
    public class HMSystemDbContextFactory : IDesignTimeDbContextFactory<HMSystemDbContext>
    {
        public HMSystemDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<HMSystemDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            DbContextOptionsConfigurer.Configure(
                builder,
                configuration.GetConnectionString(HMSystemConsts.ConnectionStringName)
            );

            return new HMSystemDbContext(builder.Options);
        }
    }
}