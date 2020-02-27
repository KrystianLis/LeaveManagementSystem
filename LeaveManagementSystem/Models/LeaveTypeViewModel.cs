using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveManagementSystem.Models
{
    public class LeaveTypeViewModel
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Default number of days")]
        [Range(1, 25, ErrorMessage = "Please eneter a valid number")]
        public int DefaultDays { get; set; }

        [Display(Name="Date Created")]
        public DateTime? DateCreated { get; set; }
    }
}
