using LeaveManagementSystem.Data;
using System;
using System.ComponentModel.DataAnnotations;

namespace LeaveManagementSystem.Models
{
    public class LeaveRequestViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Employee name")]
        public EmployeeViewModel RequestingEmployee { get; set; }

        public string RequestingEmployeeId { get; set; }

        [Display(Name = "Start date")]
        [DataType(DataType.Date)]
        [Required]
        public DateTime StartDate { get; set; }

        [Display(Name = "End date")]
        [DataType(DataType.Date)]
        [Required]
        public DateTime EndDate { get; set; }

        public LeaveTypeViewModel LeaveType { get; set; }

        public int LeaveTypeId { get; set; }

        [Display(Name = "Date requested")]
        public DateTime DateRequested { get; set; }

        [Display(Name = "Date Actioned")]
        public DateTime DateActioned { get; set; }

        [Display(Name = "Approval state")]
        public bool? Approved { get; set; }

        public Employee ApprovedBy { get; set; }

        public string ApprovedById { get; set; }
    }
}
