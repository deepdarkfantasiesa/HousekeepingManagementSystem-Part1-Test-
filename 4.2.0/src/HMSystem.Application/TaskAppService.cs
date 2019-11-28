using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using Abp.Linq.Extensions;
using Microsoft.EntityFrameworkCore;

namespace HMSystem
{
    public class TaskAppService : HMSystemAppServiceBase, ITaskAppService
    {
        private readonly IRepository<ServicePersonalBase> _taskRepository;

        public TaskAppService(IRepository<ServicePersonalBase> taskRepository)
        {
            _taskRepository = taskRepository;
        }

        public async System.Threading.Tasks.Task Create(CreateTaskInput input)
        {
            var task = ObjectMapper.Map<ServicePersonalBase>(input);
            await _taskRepository.InsertAsync(task);
        }

        public async Task<ListResultDto<TaskListDto>> GetAll(GetAllTasksInput input)
        {
            var tasks = await _taskRepository
                .GetAll()
                .Include(t => t.AssignedPerson)
                .WhereIf(input.State.HasValue, t => t.State == input.State.Value)
                .OrderByDescending(t => t.CreationTime)
                .ToListAsync();

            return new ListResultDto<TaskListDto>(
                ObjectMapper.Map<List<TaskListDto>>(tasks)
            );
        }
    }
}
