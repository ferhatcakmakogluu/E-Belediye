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
    public class MessageBoxConfiguration : IEntityTypeConfiguration<MessageBox>
    {
        public void Configure(EntityTypeBuilder<MessageBox> builder)
        {
            builder.HasKey(m => m.Id);

            builder.Property(m => m.Id).UseIdentityColumn();

            builder.Property(m => m.Message)
                .IsRequired()
                .HasMaxLength(500)
                .HasColumnType("nvarchar");

            builder.Property(m => m.RecieverId)
                .IsRequired();

            builder.Property(m => m.IsSeen)
                .IsRequired()
                .HasDefaultValue(false);

            builder.Property(m => m.SendDate)
                .IsRequired()
                .HasDefaultValueSql("GETDATE()");

            builder.Property(m => m.SeenDate)
                .IsRequired(false);

            builder.HasOne(m => m.Employee)
                .WithMany() 
                .HasForeignKey(m => m.EmployeeId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_MessageBox_Employee");

            builder.HasOne<Employee>()
                .WithMany()
                .HasForeignKey(m => m.RecieverId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_MessageBox_Reciever");
        }
    }
}
