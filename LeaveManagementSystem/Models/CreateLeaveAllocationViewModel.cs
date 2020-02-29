using System.Collections.Generic;

namespace LeaveManagementSystem.Models
{
    public class CreateLeaveAllocationViewModel
    {
        public int NumberUpdated { get; set; }

        public List<LeaveTypeViewModel> LeaveTypes { get; set; }
    }
}
