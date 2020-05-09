using LeaveManagementSystem.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LeaveManagementSystem.Contracts
{
    public interface ILeaveRequestRepository : IRepositoryBase<LeaveRequest>
    {
        Task<ICollection<LeaveRequest>> GetLeaveRequestsByEmployee(string employeeId);
    }
}
