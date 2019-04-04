using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SheduleLibrary;
using System;

namespace DAO.Configs
{
    public class UnitConfig : IEntityTypeConfiguration<Unit>
    {
        public void Configure(EntityTypeBuilder<Unit> builder)
        {
            builder.HasKey(k => k.Guid);

            builder.Property(u => u.Active).HasDefaultValue(true);

            builder.Property(u => u.Created).HasComputedColumnSql("GETDATE()");

            builder.Property(u => u.Modify).HasComputedColumnSql("GETDATE()");

            builder.Property(u => u.Draft).HasDefaultValue(false);

            builder.Property(u => u.Price).HasDefaultValue(0);

            builder.HasData(
            new Unit[]
            {
                new Unit()
                    {Guid = Guid.NewGuid(),
                        Title = "Персональный тренер",
                        Segment = "Учебный центр",
                        Comment = "Изменение программы с декабря 2018",
                        Link = Guid.NewGuid(),
                        Price = 59000,
                        Type = "Программа",
                        VisitOption = "Очное"
                    },
                new Unit()
                    {Guid = Guid.NewGuid(),
                        Title = "Инструктор тренажерного зала",
                        Segment = "Учебный центр",
                        Comment = "Начальная группа",
                        Link = Guid.NewGuid(),
                        Price = 70000,
                        Type = "Семинар",
                        VisitOption = "Дистанционное"
                    },
                new Unit()
                    {Guid = Guid.NewGuid(),
                        Title = "Фитнес - директор",
                        Segment = "Школа управления",
                        Comment = "С возможностью дистанта",
                        Link = Guid.NewGuid(),
                        Price = 40000,
                        Type = "Вебинар",
                        VisitOption = "Открытое"
                    }
            });

        }
    }
}
