using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HMSystem
{
    [Table("WorkRecordInfo")]
    public class WorkRecord
    {
        [Key]
        public int WorkRecordID { get; set; }//工作记录ID

        public DateTime StartTime { get; set; }//订单开始时间

        public DateTime StopTime { get; set; }//订单停止时间

        [ForeignKey(nameof(ServicePersonalID))]//服务人员ID
        public ServicePersonalBase ServicePersonalBase { get; set; }
        public int ServicePersonalID { get; set; }
        /*
        [ForeignKey(nameof(OrderID))]//这个外键有毛病
        public Order order { get; set; }
        public int OrderID { get; set; }
        */
        /*
        [ForeignKey(nameof(Assess))]//这个外键有毛病
        public Customer customer { get; set; }
        public AssessType Assess { get; set; }
        */

        [ForeignKey(nameof(CustomerID))]//客户ID
        public Customer customer { get; set; }
        public int CustomerID { get; set; }

        public WorkRecord()
        {

        }
    }
}
