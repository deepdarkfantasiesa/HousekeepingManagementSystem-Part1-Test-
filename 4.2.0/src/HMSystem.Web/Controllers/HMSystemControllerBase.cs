using Abp.AspNetCore.Mvc.Controllers;

namespace HMSystem.Web.Controllers
{
    public abstract class HMSystemControllerBase: AbpController
    {
        protected HMSystemControllerBase()
        {
            LocalizationSourceName = HMSystemConsts.LocalizationSourceName;
        }
    }
}