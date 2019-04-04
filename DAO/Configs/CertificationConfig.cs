using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SheduleLibrary;
using System;

namespace DAO.Configs
{
    public class CertificationConfig : IEntityTypeConfiguration<Certification>
    {
        public void Configure(EntityTypeBuilder<Certification> builder)
        {
            builder.HasKey(k => k.Guid);

            builder.Property(u => u.Created).HasComputedColumnSql("GETDATE()");

            builder.Property(u => u.Modify).HasComputedColumnSql("GETDATE()");

            //builder.Property(u => u.Modify).ValueGeneratedOnAddOrUpdate();
            //builder.Property(b => b.Modify).Metadata.AfterSaveBehavior = PropertySaveBehavior.Ignore;

            builder.Property(u => u.Draft).HasDefaultValue(false);


            builder.HasData(
                new Certification[]
                {
                                            new Certification()
                                                {
                                                Guid = Guid.NewGuid(),
                                                    Title = "Экзамен",
                                                    Link = Guid.NewGuid(),
                                                    Comment = "3 попытки"
                                                },
                                            new Certification()
                                                {
                                                Guid = Guid.NewGuid(),
                                                    Title = "Тестирование",
                                                    Link = Guid.NewGuid(),
                                                    Comment = "лист опроса"
                                                }
                });
        }
    }
}
