using System.ComponentModel.DataAnnotations;

namespace LeaveManagementSystem.Models.LeaveAllocationViewModels
{
    public class EditLeaveAllocationViewModel
    {
        public int Id { get; set; }
        public EmployeeViewModel Employee { get; set; }
        public string EmployeeId { get; set; }
        [Display(Name = "Number of days")]
        public int NumberOfDays { get; set; }
        public LeaveTypeViewModel LeaveType { get; set; }
    }
}
