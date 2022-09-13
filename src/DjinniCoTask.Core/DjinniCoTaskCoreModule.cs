using Abp.Modules;
using Abp.Reflection.Extensions;
using DjinniCoTask.Localization;

namespace DjinniCoTask
{
    public class DjinniCoTaskCoreModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Auditing.IsEnabledForAnonymousUsers = true;

            DjinniCoTaskLocalizationConfigurer.Configure(Configuration.Localization);
            
            Configuration.Settings.SettingEncryptionConfiguration.DefaultPassPhrase = DjinniCoTaskConsts.DefaultPassPhrase;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(DjinniCoTaskCoreModule).GetAssembly());
        }
    }
}