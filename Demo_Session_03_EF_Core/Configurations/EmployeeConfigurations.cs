using Demo_Session_03_EF_Core.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Session_03_EF_Core.Configurations
{

    internal class EmployeeConfigurations : IEntityTypeConfiguration<Department>  //Mapping ده الكلاس اللي هيعمل ال 
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            //حطه هنا fluent API  روح هات ال

            builder.HasKey(E => E.Id);
            builder.Property(E => E.Id)
                   .UseIdentityColumn(10, 10)
                   .HasColumnName("EmployeeName")
                   .HasColumnType("nvarchar")
                   .HasMaxLength(50)
                   .IsRequired();

            builder.Property(E => E.Salary).HasColumnType("decimal (18,2) ").IsRequired(false);
        }

        public void Configure(EntityTypeBuilder<Department> builder)
        {
            throw new NotImplementedException();
        }
    }
}
