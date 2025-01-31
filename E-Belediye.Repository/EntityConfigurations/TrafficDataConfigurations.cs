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
    public class TrafficDataConfigurations : IEntityTypeConfiguration<TrafficData>
    {
        public void Configure(EntityTypeBuilder<TrafficData> builder)
        {
            builder.HasKey(td => td.Id);
            builder.Property(td => td.Id).UseIdentityColumn();

            builder.Property(td => td.TrafficName)
                .IsRequired()
                .HasMaxLength(255);

            builder.Property(td => td.Date)
                .HasDefaultValueSql("GETDATE()");

            builder.HasOne(td => td.Employee)
               .WithMany() 
               .HasForeignKey(td => td.EmployeeId)
               .OnDelete(DeleteBehavior.Restrict) 
               .HasConstraintName("FK_TrafficData_Employee");

            builder.HasOne(td => td.WorkingUnit)
               .WithMany() 
               .HasForeignKey(td => td.WorkingUnitId)
               .OnDelete(DeleteBehavior.Restrict) 
               .HasConstraintName("FK_TrafficData_WorkingUnit");
        }
    }
}
