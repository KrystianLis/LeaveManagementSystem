﻿namespace LeaveManagementSystem.Models
{
    public class EditLeaveAllocationViewModel
    {
        public int Id { get; set; }

        public EmployeeViewModel Employee { get; set; }

        public string EmployeeId { get; set; }

        public int NumberOfDays { get; set; }

        public LeaveTypeViewModel LeaveType { get; set; }
    }
}
