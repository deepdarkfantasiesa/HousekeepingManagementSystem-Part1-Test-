using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Abp.Timing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HMSystem
{
    [Table("ServicePersonalBaseInfo")]
    public class ServicePersonalBase: Entity, IHasCreationTime
    {
        
        [Key]
        public int ServicePersonalID { get; set; }
        

        [StringLength(256)]
        public string ServicePersonalName { get; set; }

        public Gender ServicePersonalGender { get; set; }

        public DateTime BirthDay { get; set; }

        public ServiceType Type { get; set; }

        [StringLength(256)]
        public string ServiceRegion { get; set; }

        [StringLength(256)]
        public string TelephoneNumber { get; set; }

        [StringLength(256)]
        public string SelfIntroduction { get; set; }

        public int NumberOfRoles { get; set; }

        [StringLength(256)]
        public string IDCard { get; set; }

        /*------------------------------------------------------------------------------*/
        public const int MaxTitleLength = 256;
        public const int MaxDescriptionLength = 64 * 1024; //64KB
        [Required]
        [StringLength(MaxTitleLength)]
        public string Title { get; set; }
        [StringLength(MaxDescriptionLength)]
        public string Description { get; set; }
        public DateTime CreationTime { get; set; }
        public TaskState State { get; set; }
        [ForeignKey(nameof(AssignedPersonId))]
        public Person AssignedPerson { get; set; }
        public Guid? AssignedPersonId { get; set; }
        /*------------------------------------------------------------------------------*/

        public ServicePersonalBase()
        {
            CreationTime = Clock.Now;
            State = TaskState.Open;
        }
        public ServicePersonalBase(string title, string description = null, Guid? assignedPersonId = null)
            : this()
        {
            Title = title;
            Description = description;
            AssignedPersonId = assignedPersonId;
        }
        public enum Gender
        {
            Man = 0,
            Woman = 1
        }
        public enum ServiceType
        {

        }
    }

    public enum TaskState : byte
    {
        Open = 0,
        Completed = 1
    }
}
