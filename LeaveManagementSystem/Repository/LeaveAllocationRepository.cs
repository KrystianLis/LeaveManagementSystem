using LeaveManagementSystem.Contracts;
using LeaveManagementSystem.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveManagementSystem.Repository
{
    public class LeaveAllocationRepository : ILeaveAllocationRepository
    {
        private readonly ApplicationDbContext _db;

        public LeaveAllocationRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<bool> CheckAllocation(int leaveTypeId, string employeeId)
        {
            var period = DateTime.Now.Year;
            var allocations = await FindAll();
            return allocations.Where(x => x.Employee.Id == employeeId && x.LeaveType.Id == leaveTypeId && x.Period == period).Any();
        }

        public async Task<bool> Create(LeaveAllocation entity)
        {
            await _db.LeaveAllocations.AddAsync(entity);
            return await Save();
        }

        public async Task<bool> Delete(LeaveAllocation entity)
        {
            _db.LeaveAllocations.Remove(entity);
            return await Save();
        }

        public async Task<ICollection<LeaveAllocation>> FindAll()
        {
            var LeaveAllocations = await _db.LeaveAllocations.Include(x => x.LeaveType).Include(x => x.Employee).ToListAsync();
            return LeaveAllocations;
        }

        public async Task<LeaveAllocation> FindById(int id)
        {
            var LeaveAllocation = await _db.LeaveAllocations.Include(x => x.LeaveType).Include(x => x.Employee).FirstOrDefaultAsync(x => x.Id == id);
            return LeaveAllocation;
        }

        public async Task<ICollection<LeaveAllocation>> GetLeaveAllocationsByEmployee(string employeeId)
        {
            var period = DateTime.Now.Year;
            var allocations = await FindAll();
            return allocations.Where(x => x.EmployeeId == employeeId && x.Period == period).ToList();
        }

        public async Task<LeaveAllocation> GetLeaveAllocationsByEmployeeAndType(string employeeId, int leaveTypeId)
        {
            var period = DateTime.Now.Year;
            var allocations = await FindAll();
            return allocations.FirstOrDefault(x => x.EmployeeId == employeeId && x.Period == period && x.LeaveTypeId == leaveTypeId);
        }

        public async Task<bool> IsExists(int id)
        {
            return await _db.LeaveTypes.AnyAsync(x => x.Id == id);
        }

        public async Task<bool> Save()
        {
            var changesCount = await _db.SaveChangesAsync();
            return changesCount > 0;
        }

        public async Task<bool> Update(LeaveAllocation entity)
        {
            _db.LeaveAllocations.Update(entity);
            return await Save();
        }
    }
}
