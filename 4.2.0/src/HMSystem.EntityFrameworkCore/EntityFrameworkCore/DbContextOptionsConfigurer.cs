using Microsoft.EntityFrameworkCore;

namespace HMSystem.EntityFrameworkCore
{
    public static class DbContextOptionsConfigurer
    {
        public static void Configure(
            DbContextOptionsBuilder<HMSystemDbContext> dbContextOptions, 
            string connectionString
            )
        {
            /* This is the single point to configure DbContextOptions for HMSystemDbContext */
            dbContextOptions.UseSqlServer(connectionString);
        }
    }
}
