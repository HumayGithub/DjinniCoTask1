using Abp.AspNetCore.Mvc.Controllers;

namespace DjinniCoTask.Web.Controllers
{
    public abstract class DjinniCoTaskControllerBase: AbpController
    {
        protected DjinniCoTaskControllerBase()
        {
            LocalizationSourceName = DjinniCoTaskConsts.LocalizationSourceName;
        }
    }
}