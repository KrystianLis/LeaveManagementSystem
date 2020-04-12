using LeaveManagementSystem.Data;
using System.Collections.Generic;

namespace LeaveManagementSystem.Contracts
{
    public interface ILeaveRequestRepository : IRepositoryBase<LeaveRequest>
    {
        ICollection<LeaveRequest> GetLeaveRequestsByEmployee(string employeeId);
    }
}
