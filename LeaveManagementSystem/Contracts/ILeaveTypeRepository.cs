using LeaveManagementSystem.Data;
using System.Collections.Generic;

namespace LeaveManagementSystem.Contracts
{
    public interface ILeaveTypeRepository : IRepositoryBase<LeaveType>
    {
        ICollection<LeaveType> GetEmployeesByLeaveTypeById(int id);
    }
}
