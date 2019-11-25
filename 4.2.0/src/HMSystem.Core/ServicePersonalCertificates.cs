using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HMSystem
{
    [Table("ServicePersonalCertificatesInfo")]
    public class ServicePersonalCertificates
    {
        [Key]
        public int CertificatesID { get; set; }//证书ID

        [StringLength(256)]
        public string CertificateOfEmployment { get; set; }//从业证书

        [StringLength(256)]
        public string ProfessionalCertificate { get; set; }//职业证书

        [ForeignKey(nameof(ServicePersonalID))]
        public ServicePersonalBase ServicePersonalBase { get; set; }
        public int ServicePersonalID { get; set; }//证书拥有者的ID

        ServicePersonalCertificates()
        {

        }
    }
}
