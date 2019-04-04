using DAO.Configs;
using Microsoft.EntityFrameworkCore;
using SheduleLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAO
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Unit> Units { get; set; }

        public DbSet<Block> Blocks { get; set; }


        //public DbSet<Topic> Topics { get; set; }

        //public DbSet<Tag> Tags { get; set; }

        //public DbSet<Certification> Certifications { get; set; }


        public ApplicationContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=efbasicsappdb;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {          

            modelBuilder.ApplyConfiguration(new UnitConfig());
            modelBuilder.ApplyConfiguration(new TopicConfig());
            modelBuilder.ApplyConfiguration(new CompositionConfig());
            //modelBuilder.ApplyConfiguration(new TagConfig());

            modelBuilder.ApplyConfiguration(new CertificationConfig());
            modelBuilder.ApplyConfiguration(new GradeConfig());
            modelBuilder.ApplyConfiguration(new CertificationGradeConfig());

            modelBuilder.ApplyConfiguration(new BlockConfig());
            modelBuilder.ApplyConfiguration(new PartConfig());
            modelBuilder.ApplyConfiguration(new PlanConfig());


            //modelBuilder.Entity<TagReferences>().HasKey(x => x.Guid);
            //modelBuilder.Entity<TagReferences>().Property(x=>x.Guid).ValueGeneratedOnAdd();

            //modelBuilder.Entity<TagReferences>().HasKey(t => new { t.TagGuid, t.EntityTagGuid });

            //modelBuilder.Entity<TagReferences>().HasOne(sc => sc.Tag)
            //    .WithMany(s => s.References)
            //    .HasForeignKey(sc => sc.TagGuid);

            //modelBuilder.Entity<TagReferences>().HasOne(sc => sc.EntityTag)
            //   .WithMany(s => s.References)
            //    .HasForeignKey(sc => sc.EntityTagGuid);


        }
    }

}
