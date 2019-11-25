using Abp.AspNetCore;
using Abp.AspNetCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using HMSystem.Configuration;
using HMSystem.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace HMSystem.Web.Startup
{
    [DependsOn(
        typeof(HMSystemApplicationModule), 
        typeof(HMSystemEntityFrameworkCoreModule), 
        typeof(AbpAspNetCoreModule))]
    public class HMSystemWebModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public HMSystemWebModule(IHostingEnvironment env)
        {
            _appConfiguration = AppConfigurations.Get(env.ContentRootPath, env.EnvironmentName);
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(HMSystemConsts.ConnectionStringName);

            Configuration.Navigation.Providers.Add<HMSystemNavigationProvider>();

            Configuration.Modules.AbpAspNetCore()
                .CreateControllersForAppServices(
                    typeof(HMSystemApplicationModule).GetAssembly()
                );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(HMSystemWebModule).GetAssembly());
        }
    }
}