﻿using Microsoft.EntityFrameworkCore;
using Models.Data;
using System;

namespace DBLayer
{
    public class EmployeeDBContext:DbContext
    {
        public EmployeeDBContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeResume> EmployeeResumes { get; set; }
    }
}
