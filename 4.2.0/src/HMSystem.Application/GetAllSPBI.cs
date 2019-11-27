using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Entities.Auditing;
using System;
using static HMSystem.ServicePersonalBase;

namespace HMSystem
{
    public class GetAllSPBI
    {
        public Gender? gender { get; set; }
    }

    [AutoMapFrom(typeof(ServicePersonalBase))]
    public class SPersonsListDto: EntityDto
    {
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
    }
}
