using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using DjinniCoTask.Web.Startup;
namespace DjinniCoTask.Web.Tests
{
    [DependsOn(
        typeof(DjinniCoTaskWebModule),
        typeof(AbpAspNetCoreTestBaseModule)
        )]
    public class DjinniCoTaskWebTestModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(DjinniCoTaskWebTestModule).GetAssembly());
        }
    }
}