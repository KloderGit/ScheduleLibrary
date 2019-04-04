using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SheduleLibrary;

namespace DAO.Configs
{
    public class CompositionConfig : IEntityTypeConfiguration<Composition>
    {
        public void Configure(EntityTypeBuilder<Composition> builder)
        {
            builder.HasKey(k => k.Guid);

            builder.Property(x => x.Guid).ValueGeneratedOnAdd();

            builder.Property(u => u.Order).HasDefaultValue(0);

            builder.HasKey(t => new { t.UnitGuid, t.TopicGuid });

            builder.HasOne(sc => sc.Unit)
                .WithMany(s => s.Composition)
                .HasForeignKey(sc => sc.UnitGuid);

            builder.HasOne(sc => sc.Topic)
                .WithMany(s => s.Composition)
                .HasForeignKey(sc => sc.TopicGuid);
        }
    }
}
