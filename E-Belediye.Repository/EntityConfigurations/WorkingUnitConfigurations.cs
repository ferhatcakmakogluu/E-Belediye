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
    public class WorkingUnitConfigurations : IEntityTypeConfiguration<WorkingUnit>
    {
        public void Configure(EntityTypeBuilder<WorkingUnit> builder)
        {
            builder.HasKey(wu => wu.Id);
            builder.Property(wu => wu.Id).UseIdentityColumn(); 

            builder.Property(wu => wu.UnitName)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(wu => wu.UnitDescription)
                .HasMaxLength(500);

            builder.Property(wu => wu.UnitCode)
                .IsRequired()
                .HasMaxLength(50);

            builder.HasIndex(wu => wu.UnitCode)
                .IsUnique()
                .HasDatabaseName("IX_WorkingUnit_UnitCode");
        }
    }
}
