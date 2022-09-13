using Abp.AspNetCore.Mvc.Views;

namespace DjinniCoTask.Web.Views
{
    public abstract class DjinniCoTaskRazorPage<TModel> : AbpRazorPage<TModel>
    {
        protected DjinniCoTaskRazorPage()
        {
            LocalizationSourceName = DjinniCoTaskConsts.LocalizationSourceName;
        }
    }
}
