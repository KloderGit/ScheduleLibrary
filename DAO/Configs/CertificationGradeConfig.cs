using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SheduleLibrary;
using System;

namespace DAO.Configs
{
    public class CertificationGradeConfig : IEntityTypeConfiguration<CertificationGrade>
    {
        public void Configure(EntityTypeBuilder<CertificationGrade> builder)
        {
            builder.HasKey(k => k.Guid);

            builder.Property(u => u.Guid).ValueGeneratedOnAdd();


            builder.HasKey(t => new { t.CertificationGuid, t.GradeGuid });

            builder.HasOne(sc => sc.Ceritifacion)
                .WithMany(s => s.Grades)
                .HasForeignKey(sc => sc.CertificationGuid);

            builder.HasOne(sc => sc.Grade)
                .WithMany(s => s.Cerifications)
                .HasForeignKey(sc => sc.GradeGuid);
        }
    }
}
