using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using Abp.Linq.Extensions;
using Microsoft.EntityFrameworkCore;

namespace HMSystem
{
    public class BPersonService : HMSystemAppServiceBase, IBPersons
    {
        private readonly IRepository<ServicePersonalBase> _personRepository;

        public BPersonService(IRepository<ServicePersonalBase> personRepository)
        {
            _personRepository = personRepository;
        }

        public async Task<ListResultDto<SPersonsListDto>> GetAll(GetAllSPBI input)
        {
            var persons = await _personRepository
                 .GetAll()
                 .WhereIf(input.gender.HasValue, t => t.ServicePersonalGender == input.gender.Value)
                 .OrderByDescending(t => t.BirthDay)
                 .ToListAsync();

            return new ListResultDto<SPersonsListDto>
                (
                ObjectMapper.Map<List<SPersonsListDto>>(persons)
                );
        }
    }
}
