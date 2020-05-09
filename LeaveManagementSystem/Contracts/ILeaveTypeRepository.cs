using LeaveManagementSystem.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LeaveManagementSystem.Contracts
{
    public interface ILeaveTypeRepository : IRepositoryBase<LeaveType>
    {
        Task<ICollection<LeaveType>> GetEmployeesByLeaveTypeById(int id);
    }
}
