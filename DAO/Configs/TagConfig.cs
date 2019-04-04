using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SheduleLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAO.Configs
{
    public class TagConfig : IEntityTypeConfiguration<Tag>
    {
        public void Configure(EntityTypeBuilder<Tag> builder)
        {
            builder.Property(p => p.Title).IsRequired();
            builder.HasIndex(i => i.Title).IsUnique();

            builder.HasKey(k => k.Guid);

            builder.Property(u => u.Created).HasComputedColumnSql("GETDATE()");

            builder.Property(u => u.Modify).HasComputedColumnSql("GETDATE()");

            builder.Property(u => u.Draft).HasDefaultValue(false);

            builder.HasData(
                new Tag[]
                {
                                            new Tag()
                                                {Guid = Guid.NewGuid(),
                                                    Title = "Тренерам"
                                                },
                                            new Tag()
                                                {Guid = Guid.NewGuid(),
                                                    Title = "Banana"
                                                }
                });
        }
    }
}
