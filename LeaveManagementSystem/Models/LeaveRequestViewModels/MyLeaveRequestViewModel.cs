using LeaveManagementSystem.Models.LeaveAllocationViewModels;
using System.Collections.Generic;

namespace LeaveManagementSystem.Models.LeaveRequestViewModels
{
    public class MyLeaveRequestViewModel
    {
        public List<LeaveAllocationViewModel> LeaveAllocations { get; set; }

        public List<LeaveRequestViewModel> LeaveRequests { get; set; }
    }
}
