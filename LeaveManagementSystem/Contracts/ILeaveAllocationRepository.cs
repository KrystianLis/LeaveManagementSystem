using LeaveManagementSystem.Data;
using System.Collections.Generic;

namespace LeaveManagementSystem.Contracts
{
    public interface ILeaveAllocationRepository : IRepositoryBase<LeaveAllocation>
    {
        bool CheckAllocation(int leaveTypeId, string employeeId);

        ICollection<LeaveAllocation> GetLeaveAllocationsByEmployee(string id);

        LeaveAllocation GetLeaveAllocationsByEmployeeAndType(string id, int leaveTypeId);
    }
}
