using E_Belediye.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Belediye.Repository.EntityConfigurations
{
    public class EmployeeConfigurations : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).UseIdentityColumn();

            // Çalışan Numarası - Unique
            builder.Property(e => e.EmployeeWorkingId)
                .IsRequired()
                .HasMaxLength(50);

            builder.HasIndex(e => e.EmployeeWorkingId)
                .IsUnique()
                .HasDatabaseName("IX_Employee_EmployeeWorkingId");

            // Çalışan tipi (EmployeeType) - Enum gibi olabilir
            builder.Property(e => e.EmployeeType)
                .IsRequired()
                .HasMaxLength(30);

            // Maaş bilgisi
            builder.Property(e => e.Salary)
                .IsRequired()
                .HasColumnType("decimal(18,2)"); // Decimal daha güvenlidir

            builder.ToTable(t => t.HasCheckConstraint("CHK_Employee_Salary", "Salary >= 0"));

            // İşe başlangıç tarihi
            builder.Property(e => e.WorkStartDate)
                .IsRequired()
                .HasColumnType("DATE");

            //Foreign Key - Person
            builder.HasOne(e => e.Person)
                .WithOne() 
                .HasForeignKey<Employee>(e => e.PersonId) 
                .OnDelete(DeleteBehavior.Cascade) 
                .HasConstraintName("FK_Employee_Person");

            //Foreign Key - WorkingUnit
            builder.HasOne(e => e.WorkingUnit)
                .WithOne() 
                .HasForeignKey<Employee>(e => e.WorkingUnitId) 
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_Employee_WorkingUnit");
        }
    }
}
