using Demo_Session_03_EF_Core.Configurations;
using Demo_Session_03_EF_Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Session_03_EF_Core.Context
{
    internal class AppDbContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //TPC
            //modelBuilder.Entity<Employee>().ToTable("Employee");
            //modelBuilder.Entity<FullTimeEmployee>().ToTable("FullTimeEmployee");
            //modelBuilder.Entity<PartTimeEmployee>().ToTable("PartTimeEmployee");

            //TPH
            //modelBuilder.Entity<FullTimeEmployee>().HasBaseType<Employee>();
            //modelBuilder.Entity<PartTimeEmployee>().HasBaseType<Employee>();

            modelBuilder.ApplyConfiguration(new EmployeeConfigurations());
            modelBuilder.ApplyConfiguration(new DepartmentConfigurations());

            base.OnModelCreating(modelBuilder);
        }

        #region ده عشان افتح تواصل مع داتا بيز
        // ده عشان افتح تواصل مع داتا بيز
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) // مسؤاله انها تفتح connection
        {
            // Code To Connect To DataBase
            //optionsBuilder.UseLazyLoadingProxies();
            optionsBuilder.UseSqlServer("Server = DESKTOP-DA9SS6B\\MSSQLSERVER04; Database = Company03; Trusted_Connection = True ; ");
        }

        #endregion

        #region Data Base في ال Table ده عشان اعمل 

        //Data Base في ال Table ده عشان اعمل 
        public DbSet<Employee> employees { get; set; }
        public DbSet<Department> departments { get; set; }
        public DbSet<Student> students { get; set; }
        public DbSet<Course> courses { get; set; }
        public DbSet<FullTimeEmployee> fullTimeEmployees { get; set; }
        public DbSet<PartTimeEmployee> partTimeEmployees { get; set; }
        #endregion
    }
}
