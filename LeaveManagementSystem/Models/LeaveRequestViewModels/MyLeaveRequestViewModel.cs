using LeaveManagementSystem.Models.LeaveAllocationViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveManagementSystem.Models.LeaveRequestViewModels
{
    public class MyLeaveRequestViewModel
    {
        public List<LeaveAllocationViewModel> LeaveAllocations { get; set; }

        public List<LeaveRequestViewModel> LeaveRequests { get; set; }
    }
}
