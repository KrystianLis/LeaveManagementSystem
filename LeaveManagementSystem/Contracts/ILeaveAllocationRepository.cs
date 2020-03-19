using LeaveManagementSystem.Data;
using System.Collections.Generic;

namespace LeaveManagementSystem.Contracts
{
    public interface ILeaveAllocationRepository : IRepositoryBase<LeaveAllocation>
    {
        bool CheckAllocation(int leaveTypeId, string employeeId);

        ICollection<LeaveAllocation> GetLeaveAllocationsByEmployee(string employeeId);

        LeaveAllocation GetLeaveAllocationsByEmployeeAndType(string employeeId, int leaveTypeId);
    }
}
