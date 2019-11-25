using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using HMSystem.Web.Startup;
namespace HMSystem.Web.Tests
{
    [DependsOn(
        typeof(HMSystemWebModule),
        typeof(AbpAspNetCoreTestBaseModule)
        )]
    public class HMSystemWebTestModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(HMSystemWebTestModule).GetAssembly());
        }
    }
}