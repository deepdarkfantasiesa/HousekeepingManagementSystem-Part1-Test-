using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HMSystem
{
    [Table("CustomerInfo")]
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }//客户ID

        [StringLength(256)]
        public string CustomerName { get; set; }//客户姓名

        [StringLength(256)]
        public string IDCard { get; set; }//客户身份证号

        [StringLength(256)]
        public string Region { get; set; }//地区
        public Customer()
        {

        }
    }

}
