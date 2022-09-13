using Abp.AspNetCore;
using Abp.AspNetCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using DjinniCoTask.Configuration;
using DjinniCoTask.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.ApplicationParts;
using Microsoft.Extensions.Configuration;

namespace DjinniCoTask.Web.Startup
{
    [DependsOn(
        typeof(DjinniCoTaskApplicationModule), 
        typeof(DjinniCoTaskEntityFrameworkCoreModule), 
        typeof(AbpAspNetCoreModule))]
    public class DjinniCoTaskWebModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public DjinniCoTaskWebModule(IWebHostEnvironment env)
        {
            _appConfiguration = AppConfigurations.Get(env.ContentRootPath, env.EnvironmentName);
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(DjinniCoTaskConsts.ConnectionStringName);

            Configuration.Navigation.Providers.Add<DjinniCoTaskNavigationProvider>();

            Configuration.Modules.AbpAspNetCore()
                .CreateControllersForAppServices(
                    typeof(DjinniCoTaskApplicationModule).GetAssembly()
                );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(DjinniCoTaskWebModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(DjinniCoTaskWebModule).Assembly);
        }
    }
}
