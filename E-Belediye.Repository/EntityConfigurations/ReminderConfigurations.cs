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
    public class ReminderConfigurations : IEntityTypeConfiguration<Reminder>
    {
        public void Configure(EntityTypeBuilder<Reminder> builder)
        {
            builder.HasKey(r => r.Id);
            builder.Property(r => r.Id).UseIdentityColumn();

            builder.Property(r => r.ReminderTitle)
                .IsRequired()
                .HasMaxLength(255);

            builder.Property(r => r.ReminderType)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(r => r.StartDate)
                .IsRequired();

            builder.HasCheckConstraint("CHK_Reminder_StartDate", "StartDate >= GETDATE()");

            builder.Property(r => r.EndDate)
                .IsRequired();

            builder.HasCheckConstraint("CHK_Reminder_EndDate", "EndDate > StartDate");

            builder.HasOne(r => r.Employee)  
               .WithMany()                 
               .HasForeignKey(r => r.EmployeeId) 
               .OnDelete(DeleteBehavior.Cascade)
               .HasConstraintName("FK_Reminder_Employee");
        }
    }
}
