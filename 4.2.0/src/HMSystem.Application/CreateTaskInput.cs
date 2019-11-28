using System;
using System.ComponentModel.DataAnnotations;
using Abp.AutoMapper;

namespace HMSystem
{
    [AutoMapTo(typeof(ServicePersonalBase))]
    public class CreateTaskInput
    {
        [Required]
        [StringLength(ServicePersonalBase.MaxTitleLength)]
        public string Title { get; set; }

        [StringLength(ServicePersonalBase.MaxDescriptionLength)]
        public string Description { get; set; }

        public Guid? AssignedPersonId { get; set; }
    }
}
