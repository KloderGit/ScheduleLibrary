using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SheduleLibrary;
using System;

namespace DAO.Configs
{
    public class TopicConfig : IEntityTypeConfiguration<Topic>
    {
        public void Configure(EntityTypeBuilder<Topic> builder)
        {
            builder.HasKey(k => k.Guid);

            builder.Property(u => u.Created).HasComputedColumnSql("GETDATE()");

            builder.Property(u => u.Modify).HasComputedColumnSql("GETDATE()");

            builder.Property(u => u.Draft).HasDefaultValue(true);


            builder.HasData(
                new Topic[]
                {
                                new Topic()
                                    {Guid = Guid.NewGuid(),
                                        Title = "Анатомия",
                                        Link = Guid.NewGuid(),
                                        Comment = "С практикой"
                                    },
                                new Topic()
                                    {Guid = Guid.NewGuid(),
                                        Title = "Кровь и состав",
                                        Link = Guid.NewGuid()
                                    },
                                new Topic()
                                    {Guid = Guid.NewGuid(),
                                        Title = "Управление конфликтом",
                                        Comment = "для Управляющих",
                                        Link = Guid.NewGuid()
                                    }
                });
        }
    }
}
