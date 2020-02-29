using LeaveManagementSystem.Contracts;
using LeaveManagementSystem.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace LeaveManagementSystem.Repository
{
    public class LeaveRequestRepository : ILeaveRequestRepository
    {
        private readonly ApplicationDbContext _db;

        public LeaveRequestRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public bool Create(LeaveRequest entity)
        {
            _db.LeaveRequests.Add(entity);
            return Save();
        }

        public bool Delete(LeaveRequest entity)
        {
            _db.LeaveRequests.Remove(entity);
            return Save();
        }

        public ICollection<LeaveRequest> FindAll()
        {
            var LeaveRequests = _db.LeaveRequests
                .Include(x => x.RequestingEmployee)
                .Include(x => x.ApprovedBy)
                .Include(x => x.LeaveType).ToList();
            return LeaveRequests;
        }

        public LeaveRequest FindById(int id)
        {
            var LeaveRequests = _db.LeaveRequests
                .Include(x => x.RequestingEmployee)
                .Include(x => x.ApprovedBy)
                .Include(x => x.LeaveType)
                .FirstOrDefault(x => x.Id == id);

            return LeaveRequests;
        }

        public bool IsExists(int id)
        {
            return _db.LeaveTypes.Any(x => x.Id == id);
        }

        public bool Save()
        {
            var changesCount = _db.SaveChanges();
            return changesCount > 0;
        }

        public bool Update(LeaveRequest entity)
        {
            _db.LeaveRequests.Update(entity);
            return Save();
        }
    }
}
