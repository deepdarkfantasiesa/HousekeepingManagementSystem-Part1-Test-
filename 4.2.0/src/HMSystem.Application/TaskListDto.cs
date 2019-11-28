using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Entities.Auditing;
using System;
using static HMSystem.ServicePersonalBase;

namespace HMSystem
{
    [AutoMapFrom(typeof(ServicePersonalBase))]
    public class TaskListDto : EntityDto, IHasCreationTime
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime CreationTime { get; set; }

        public TaskState State { get; set; }
        /*------------------------------------------------------------------*/
        public int ServicePersonalID { get; set; }

        public string ServicePersonalName { get; set; }

        public Gender ServicePersonalGender { get; set; }

        public DateTime BirthDay { get; set; }

        public ServiceType Type { get; set; }

        public string ServiceRegion { get; set; }

        public string TelephoneNumber { get; set; }

        public string SelfIntroduction { get; set; }

        public int NumberOfRoles { get; set; }

        public string IDCard { get; set; }
        /*-----------------------------------------------------*/
        public Guid? AssignedPersonId { get; set; }

        public string AssignedPersonName { get; set; }
    }
}
