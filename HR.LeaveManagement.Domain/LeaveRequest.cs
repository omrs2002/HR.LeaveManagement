using HR.LeaveManagement.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Domain
{

    public class LeaveRequest : BaseDomainEntity
    {
        [Key]
        public int Id { get; set; }
        //[ForeignKey("RequestingEmployeeId")]
        //public Employee RequestingEmployee { get; set; }
        //public string RequestingEmployeeId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        [ForeignKey("LeaveTypeId")]
        public LeaveType LeaveType { get; set; }
        public int LeaveTypeId { get; set; }
        public DateTime DateRequested { get; set; }
        public string RequestComments { get; set; }
        public DateTime DateActioned { get; set; }
        public bool? Approved { get; set; }
        public bool Cancelled { get; set; }
        //[ForeignKey("ApprovedById")]
        //public Employee ApprovedBy { get; set; }
        //public string ApprovedById { get; set; }
    }

}
