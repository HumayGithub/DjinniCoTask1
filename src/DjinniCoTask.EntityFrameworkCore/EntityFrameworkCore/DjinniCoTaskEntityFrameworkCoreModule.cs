using Abp.EntityFrameworkCore;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace DjinniCoTask.EntityFrameworkCore
{
    [DependsOn(
        typeof(DjinniCoTaskCoreModule), 
        typeof(AbpEntityFrameworkCoreModule))]
    public class DjinniCoTaskEntityFrameworkCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(DjinniCoTaskEntityFrameworkCoreModule).GetAssembly());
        }
    }
}