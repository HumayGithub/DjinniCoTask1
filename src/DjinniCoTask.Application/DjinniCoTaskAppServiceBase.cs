using Abp.Application.Services;

namespace DjinniCoTask
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class DjinniCoTaskAppServiceBase : ApplicationService
    {
        protected DjinniCoTaskAppServiceBase()
        {
            LocalizationSourceName = DjinniCoTaskConsts.LocalizationSourceName;
        }
    }
}