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
    internal class DepartmentConfigurations : IEntityTypeConfiguration<Department> //Mapping ده الكلاس اللي هيعمل ال 
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.HasKey(D => D.Id);
            builder.Property(D => D.Id)
                   .UseIdentityColumn(100, 100);
            builder.Property(D => D.Id)
                   .HasColumnName("DepatmentName")
                   .HasColumnType("varchar")
                   .HasMaxLength(100)
                   .IsRequired();
        }
    }
}
