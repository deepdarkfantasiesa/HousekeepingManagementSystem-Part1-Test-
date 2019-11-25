using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HMSystem
{
    [Table("OrderInfo")]
    public class Order
    {
        [Key]
        public int OrderID { get; set; }//订单号

        public decimal Price { get; set; }//订单金额

        public AssessType Assess { get; set; }//客户评价

        [ForeignKey(nameof(CustomerID))]//客户ID
        public Customer customer { get; set; }
        public int CustomerID { get; set; }

        [ForeignKey(nameof(ServicePersonalBaseID))]//服务人员ID
        public ServicePersonalBase ServicePersonalBase { get; set; }
        public int ServicePersonalBaseID { get; set; }

        public Order()
        {

        }
        public enum AssessType
        {

        }
    }

}
