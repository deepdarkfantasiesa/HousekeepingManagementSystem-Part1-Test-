using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace HMSystem
{
    [DependsOn(
        typeof(HMSystemCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class HMSystemApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(HMSystemApplicationModule).GetAssembly());
        }
    }
}