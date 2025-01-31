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
    public class TaskProcessConfiguration : IEntityTypeConfiguration<TaskProcess>
    {
        public void Configure(EntityTypeBuilder<TaskProcess> builder)
        {
            builder.HasKey(tp => tp.Id);
            builder.Property(tp => tp.Id).UseIdentityColumn();

            builder.Property(tp => tp.TaskNumberId)
                .IsRequired()
                .HasMaxLength(50)
                .HasDefaultValue("#");

            builder.Property(tp => tp.TaskTitle)
                .IsRequired()
                .HasMaxLength(255);

            builder.Property(tp => tp.TaskDescription)
                .HasMaxLength(1000);

            builder.Property(tp => tp.TaskType)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(tp => tp.TaskStartDate)
                .IsRequired();

            builder.Property(tp => tp.TaskEndDate)
                .IsRequired(false);

            builder.HasCheckConstraint("CHK_TaskProcess_EndDate", "TaskEndDate IS NULL OR TaskEndDate > TaskStartDate");


            builder.HasOne(tp => tp.UnitLead)
                .WithMany() 
                .HasForeignKey(tp => tp.UnitLeadId)
                .OnDelete(DeleteBehavior.Restrict) 
                .HasConstraintName("FK_TaskProcess_UnitLead");

            builder.HasOne(tp => tp.Employee)
                .WithMany() 
                .HasForeignKey(tp => tp.EmployeeId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_TaskProcess_Employee");
        }
    }
}
