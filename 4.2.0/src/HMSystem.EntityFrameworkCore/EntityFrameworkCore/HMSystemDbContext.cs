using Abp.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HMSystem.EntityFrameworkCore
{
    public class HMSystemDbContext : AbpDbContext
    {
        //Add DbSet properties for your entities...

        public HMSystemDbContext(DbContextOptions<HMSystemDbContext> options) 
            : base(options)
        {

        }
    }
}
