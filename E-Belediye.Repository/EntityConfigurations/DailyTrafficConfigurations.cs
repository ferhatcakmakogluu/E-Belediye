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
    public class DailyTrafficConfigurations : IEntityTypeConfiguration<DailyTraffic>
    {
        public void Configure(EntityTypeBuilder<DailyTraffic> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x=> x.Id).UseIdentityColumn();

            //Günlük verilerin tekrarını önlemek için Unique Constraint
            builder.HasIndex(x => x.Date).IsUnique();
            builder.Property(x => x.TotalTraffic).IsRequired().HasDefaultValue(0);
        }
    }
}
