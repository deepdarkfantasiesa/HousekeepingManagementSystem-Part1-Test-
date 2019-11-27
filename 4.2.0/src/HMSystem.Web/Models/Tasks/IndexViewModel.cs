using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HMSystem.Web.Models.Tasks
{
    public class IndexViewModel
    {
        public IReadOnlyList<SPersonsListDto> Tasks { get; }

        public IndexViewModel(IReadOnlyList<SPersonsListDto> tasks)
        {
            Tasks = tasks;
        }

        public string GetTaskLabel(SPersonsListDto task)
        {
            switch (task.ServicePersonalGender)
            {
                case ServicePersonalBase.Gender.Man:
                    return "label-success";
                default:
                    return "label-default";
            }
        }
    }
}
