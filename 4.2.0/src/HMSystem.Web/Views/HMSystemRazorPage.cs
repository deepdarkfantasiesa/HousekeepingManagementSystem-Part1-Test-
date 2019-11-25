using Abp.AspNetCore.Mvc.Views;

namespace HMSystem.Web.Views
{
    public abstract class HMSystemRazorPage<TModel> : AbpRazorPage<TModel>
    {
        protected HMSystemRazorPage()
        {
            LocalizationSourceName = HMSystemConsts.LocalizationSourceName;
        }
    }
}
