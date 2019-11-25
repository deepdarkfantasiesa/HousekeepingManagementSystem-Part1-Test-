using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HMSystem
{
    [Table("ServicePersonalBaseInfo")]
    public class ServicePersonalBase
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

        public ServicePersonalBase()
        {

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
}
