using Abp.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HMSystem.EntityFrameworkCore
{
    public class HMSystemDbContext : AbpDbContext
    {
        //Add DbSet properties for your entities...
        public DbSet<ServicePersonalBase> Tasks { get; set; }
        /*
        public DbSet<ServicePersonalCertificates> Certificates { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<WorkRecord> WorkRecords { get; set; }
        */
        public HMSystemDbContext(DbContextOptions<HMSystemDbContext> options) 
            : base(options)
        {

        }
    }
}
