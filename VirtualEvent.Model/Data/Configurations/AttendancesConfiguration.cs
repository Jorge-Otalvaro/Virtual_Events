// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using System;
using VirtualEvent.Model.Data;
using VirtualEvent.Model.Models;


namespace VirtualEvent.Model.Data.Configurations
{
    public partial class AttendancesConfiguration : IEntityTypeConfiguration<Attendances>
    {
        public void Configure(EntityTypeBuilder<Attendances> entity)
        {
            entity.HasKey(e => e.AttendanceId)
                .HasName("PK_Attendance");

            entity.Property(e => e.AttendanceDate).HasColumnType("date");

            entity.Property(e => e.Email)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.FullName)
                .IsRequired()
                .HasMaxLength(250)
                .IsUnicode(false);

            entity.Property(e => e.Notes).IsUnicode(false);

            entity.HasOne(d => d.Event)
                .WithMany(p => p.Attendances)
                .HasForeignKey(d => d.EventId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Attendances_Events");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Attendances> entity);
    }
}
