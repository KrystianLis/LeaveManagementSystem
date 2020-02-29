using System;
using System.ComponentModel.DataAnnotations;

namespace LeaveManagementSystem.Models
{
    public class EmployeeViewModel
    {
        public string Id { get; set; }

        public string UserName { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        public string TaxId { get; set; }

        public DateTime DateOfBirth { get; set; }

        public DateTime DateJoined { get; set; }
    }
}
