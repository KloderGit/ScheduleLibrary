using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SheduleLibrary;
using System;

namespace DAO.Configs
{
    public class BlockConfig : IEntityTypeConfiguration<Block>
    {
        public void Configure(EntityTypeBuilder<Block> builder)
        {
            builder.HasKey(k => k.Guid);
            //builder.Property(u => u.Guid).UseSqlServerIdentityColumn();

            builder.Property(u => u.Created).HasDefaultValue(DateTime.Now);

            builder.Property(u => u.Modify).HasDefaultValue(DateTime.Now);

            builder.Property(u => u.Draft).HasDefaultValue(false);

            builder.Property(u => u.Active).HasDefaultValue(true);

            builder.Property(u => u.Price).HasDefaultValue(0);

            builder.HasOne(p => p.Master)
                .WithMany(b => b.Blocks);
        }
    }
}
