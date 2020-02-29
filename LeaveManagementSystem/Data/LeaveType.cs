﻿using System;
using System.ComponentModel.DataAnnotations;

namespace LeaveManagementSystem.Data
{
    public class LeaveType
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public int DefaultDays { get; set; }

        public DateTime DateCreated { get; set; }

    }
}
