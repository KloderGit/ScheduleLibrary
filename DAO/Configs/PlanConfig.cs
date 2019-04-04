using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SheduleLibrary;

namespace DAO.Configs
{
    public class PlanConfig : IEntityTypeConfiguration<Plan>
    {
        public void Configure(EntityTypeBuilder<Plan> builder)
        {
            builder.HasKey(k => k.Guid);
            builder.Property(x => x.Guid).ValueGeneratedOnAdd();

            builder.HasKey(t => new { t.BlockGuid, t.PartGuid });

            builder.HasOne(sc => sc.Block)
                .WithMany(s => s.Events)
                .HasForeignKey(sc => sc.BlockGuid);

            builder.HasOne(sc => sc.Part)
                .WithMany(s => s.Blocks)
                .HasForeignKey(sc => sc.PartGuid);
        }
    }
}
