﻿using Microsoft.EntityFrameworkCore;





namespace Demoproject.Models
{
    public class EmpDBContext:DbContext
    {
        public EmpDBContext(DbContextOptions<EmpDBContext> options): base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Employee>().ToTable("Employee");
        }
        public DbSet<Employee> Employee { get; set; }


    }
}
