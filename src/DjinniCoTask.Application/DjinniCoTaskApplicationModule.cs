using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace DjinniCoTask
{
    [DependsOn(
        typeof(DjinniCoTaskCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class DjinniCoTaskApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(DjinniCoTaskApplicationModule).GetAssembly());
        }
    }
}