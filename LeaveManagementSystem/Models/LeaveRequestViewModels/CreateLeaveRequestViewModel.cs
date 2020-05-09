using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LeaveManagementSystem.Models.LeaveRequestViewModels
{
    public class CreateLeaveRequestViewModel
    {
        [Display(Name = "Start date")]
        [Required]
        public string StartDate { get; set; }

        [Display(Name = "End date")]
        [Required]
        public string EndDate { get; set; }

        public IEnumerable<SelectListItem> LeaveTypes { get; set; }

        [Display(Name = "Leave type")]
        public int LeaveTypeId { get; set; }
    }
}
