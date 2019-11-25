using Abp.EntityFrameworkCore;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace HMSystem.EntityFrameworkCore
{
    [DependsOn(
        typeof(HMSystemCoreModule), 
        typeof(AbpEntityFrameworkCoreModule))]
    public class HMSystemEntityFrameworkCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(HMSystemEntityFrameworkCoreModule).GetAssembly());
        }
    }
}