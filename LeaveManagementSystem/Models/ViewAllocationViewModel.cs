using System.Collections.Generic;

namespace LeaveManagementSystem.Models
{
    public class ViewAllocationViewModel
    {
        public EmployeeViewModel Employee { get; set; }

        public string EmployeeId { get; set; }

        public List<LeaveAllocationViewModel> LeaveAllocation { get; set; }
    }
}
