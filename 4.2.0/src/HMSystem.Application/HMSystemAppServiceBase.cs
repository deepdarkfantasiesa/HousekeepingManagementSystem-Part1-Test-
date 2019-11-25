using Abp.Application.Services;

namespace HMSystem
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class HMSystemAppServiceBase : ApplicationService
    {
        protected HMSystemAppServiceBase()
        {
            LocalizationSourceName = HMSystemConsts.LocalizationSourceName;
        }
    }
}