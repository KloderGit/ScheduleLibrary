using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SheduleLibrary;
using System;

namespace DAO.Configs
{
    public class PartConfig : IEntityTypeConfiguration<Part>
    {
        public void Configure(EntityTypeBuilder<Part> builder)
        {
            builder.HasKey(k => k.Guid);

            builder.Property(u => u.Created).HasComputedColumnSql("GETDATE()");

            builder.Property(u => u.Modify).HasComputedColumnSql("GETDATE()");

            builder.Property(u => u.Draft).HasDefaultValue(false);

            builder.Property(u => u.Active).HasDefaultValue(true);

            builder.Property(u => u.Price).HasDefaultValue(0);

        }
    }
}
