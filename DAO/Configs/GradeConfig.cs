using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SheduleLibrary;
using System;

namespace DAO.Configs
{
    public class GradeConfig : IEntityTypeConfiguration<Grade>
    {
        public void Configure(EntityTypeBuilder<Grade> builder)
        {
            builder.HasKey(k => k.Guid);

            builder.Property(u => u.Created).HasComputedColumnSql("GETDATE()");

            builder.Property(u => u.Modify).HasComputedColumnSql("GETDATE()");

            builder.Property(u => u.Draft).HasDefaultValue(true);

            builder.Ignore(x => x.Max).Ignore(x => x.Min);

            builder.HasData(
                new Grade[]
                {
                                            new Grade()
                                                {Guid = Guid.NewGuid(),
                                                    Title = "Пятибальная",
                                                    Link = Guid.NewGuid(),
                                                    Comment = "мин - 3"
                                                },
                                            new Grade()
                                                {Guid = Guid.NewGuid(),
                                                    Title = "Зачет",
                                                    Link = Guid.NewGuid()
                                                }
                });
        }
    }
}
