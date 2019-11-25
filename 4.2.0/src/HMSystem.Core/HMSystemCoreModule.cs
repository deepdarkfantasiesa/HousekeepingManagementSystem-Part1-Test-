using Abp.Modules;
using Abp.Reflection.Extensions;
using HMSystem.Localization;

namespace HMSystem
{
    public class HMSystemCoreModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Auditing.IsEnabledForAnonymousUsers = true;

            HMSystemLocalizationConfigurer.Configure(Configuration.Localization);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(HMSystemCoreModule).GetAssembly());
        }
    }
}