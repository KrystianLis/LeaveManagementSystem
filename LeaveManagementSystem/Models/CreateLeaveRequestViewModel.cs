using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LeaveManagementSystem.Models
{
    public class CreateLeaveRequestViewModel
    {
        [Display(Name = "Start date")]
        [Required]
        public DateTime StartDate { get; set; }

        [Display(Name = "End date")]
        [Required]
        public DateTime EndDate { get; set; }

        public IEnumerable<SelectListItem> LeaveTypes { get; set; }

        [Display(Name = "Leave type")]
        public int LeaveTypeId { get; set; }
    }
}
