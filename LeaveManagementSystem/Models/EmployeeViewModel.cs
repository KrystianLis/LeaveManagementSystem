using System;
using System.ComponentModel.DataAnnotations;

namespace LeaveManagementSystem.Models
{
    public class EmployeeViewModel
    {
        public string Id { get; set; }
        [Display(Name = "User name")]
        public string UserName { get; set; }
        public string Email { get; set; }
        [Display(Name = "Phone number")]
        public string PhoneNumber { get; set; }
        [Display(Name = "First name")]
        public string FirstName { get; set; }
        [Display(Name = "Last name")]
        public string LastName { get; set; }
        [Display(Name = "Tax id")]
        public string TaxId { get; set; }
        [Display(Name = "Date of birth")]
        public DateTime DateOfBirth { get; set; }
        [Display(Name = "Date joined")]
        public DateTime DateJoined { get; set; }
    }
}
