using Abp.Application.Services;
using Abp.Application.Services.Dto;
using System.Threading.Tasks;

namespace HMSystem
{
    public interface ILookupAppService : IApplicationService
    {
        Task<ListResultDto<ComboboxItemDto>> GetPeopleComboboxItems();
    }
}
