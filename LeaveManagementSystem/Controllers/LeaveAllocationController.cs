﻿using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using LeaveManagementSystem.Contracts;
using LeaveManagementSystem.Data;
using LeaveManagementSystem.Models;
using LeaveManagementSystem.Models.LeaveAllocationViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace LeaveManagementSystem.Controllers
{
    [Authorize(Roles = "Administrator")]
    public class LeaveAllocationController : Controller
    {
        private readonly ILeaveAllocationRepository _allocationRepo;
        private readonly ILeaveTypeRepository _typeRepo;
        private readonly IMapper _mapper;
        private readonly UserManager<Employee> _userManager;

        public LeaveAllocationController(ILeaveTypeRepository typeRepo, ILeaveAllocationRepository allocationRepo, IMapper mapper, UserManager<Employee> userManager)
        {
            _typeRepo = typeRepo;
            _allocationRepo = allocationRepo;
            _mapper = mapper;
            _userManager = userManager;
        }

        // GET: LeaveAllocation
        public ActionResult Index()
        {
            var leaveTypes = _typeRepo.FindAll().ToList();
            var mappedLeaveTypes = _mapper.Map<List<LeaveType>, List<LeaveTypeViewModel>>(leaveTypes);
            var model = new CreateLeaveAllocationViewModel
            {
                LeaveTypes = mappedLeaveTypes,
                NumberUpdated = 0,
            };

            return View(model);
        }

        public ActionResult SetLeave(int id)
        {
            var leaveType = _typeRepo.FindById(id);
            var employees = _userManager.GetUsersInRoleAsync("Employee").Result;

            foreach (var employee in employees)
            {
                if (_allocationRepo.CheckAllocation(id, employee.Id))
                {
                    continue;
                }

                var allocation = new LeaveAllocationViewModel
                {
                        DateCreated = DateTime.Now,
                        EmployeeId = employee.Id,
                        LeaveTypeId = id,
                        NumberOfDays = leaveType.DefaultDays,
                        Period = DateTime.Now.Year
                };

                var leaveAllocation = _mapper.Map<LeaveAllocation>(allocation);
                _allocationRepo.Create(leaveAllocation);
            }

            return RedirectToAction(nameof(Index));
        }

        public ActionResult ListEmployees()
        {
            var employees = _userManager.GetUsersInRoleAsync("Employee").Result;
            var model = _mapper.Map<List<EmployeeViewModel>>(employees);
            return View(model);
        }

        // GET: LeaveAllocation/Details/5
        public ActionResult Details(string id)
        {
            var employee = _mapper.Map<EmployeeViewModel>(_userManager.FindByIdAsync(id).Result);
            var allocation = _mapper.Map<List<LeaveAllocationViewModel>>(_allocationRepo.GetLeaveAllocationsByEmployee(id));
            var model = new ViewAllocationViewModel
            {
                Employee = employee,
                LeaveAllocation = allocation
            };

            return View(model);
        }

        // GET: LeaveAllocation/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LeaveAllocation/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: LeaveAllocation/Edit/5
        public ActionResult Edit(int id)
        {
            var leaveAllocation = _allocationRepo.FindById(id);
            var model = _mapper.Map<EditLeaveAllocationViewModel>(leaveAllocation);

            return View(model);
        }

        // POST: LeaveAllocation/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(EditLeaveAllocationViewModel model)
        {
            try
            {
                if(!ModelState.IsValid)
                {
                    return View(model);
                }

                var record = _allocationRepo.FindById(model.Id);
                record.NumberOfDays = model.NumberOfDays;
                var isSuccess = _allocationRepo.Update(record);

                if(!isSuccess)
                {
                    ModelState.AddModelError("", "Error while saving");
                    return View(model);
                }

                return RedirectToAction(nameof(Details), new { id = model.EmployeeId});
            }
            catch
            {
                return View(model);
            }
        }

        // GET: LeaveAllocation/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: LeaveAllocation/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}