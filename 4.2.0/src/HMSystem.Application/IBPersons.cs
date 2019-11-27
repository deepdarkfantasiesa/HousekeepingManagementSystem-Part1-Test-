using Abp.Application.Services;
using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HMSystem
{
    public interface IBPersons: IApplicationService
    {
        Task<ListResultDto<SPersonsListDto>> GetAll(GetAllSPBI input);
    }
}
