using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using LeaveManagementSystem.Models;

namespace LeaveManagementSystem.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<LeaveHistory> LeaveHistories { get; set; }

        public DbSet<LeaveType> LeaveTypes { get; set; }

        public DbSet<LeaveAllocation> LeaveAllocations { get; set; }

        public DbSet<LeaveTypeViewModel> LeaveTypeViewModel { get; set; }

        public DbSet<EmployeeViewModel> EmployeeViewModel { get; set; }

        public DbSet<LeaveManagementSystem.Models.LeaveAllocationViewModel> LeaveAllocationViewModel { get; set; }

        public DbSet<LeaveManagementSystem.Models.EditLeaveAllocationViewModel> EditLeaveAllocationViewModel { get; set; }
    }
}
