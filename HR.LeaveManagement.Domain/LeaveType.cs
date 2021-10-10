using HR.LeaveManagement.Domain.Common;
using System;
using System.ComponentModel.DataAnnotations;

namespace HR.LeaveManagement.Domain
{
    public class LeaveType : BaseDomainEntity
    {
        [Key]
        public string Name { get; set; }
        public int DefaultDays { get; set; }
    }

}
