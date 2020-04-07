using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SagTest.Models;

namespace SagTest.Data
{
    public class MyDBContext : DbContext
    {

        public MyDBContext(DbContextOptions<MyDBContext> options)
            : base(options)
        {

        }

        public DbSet<Sag> Sag { get; set; }
        public DbSet<ImageModel> Images { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Sag>().HasKey(s => new { s.SubjectId });

            mb.Entity<ImageModel>().HasKey(s => new { s.ImageId });
            mb.Entity<ImageModel>()
                .HasOne<Sag>(i => i.Sag)
                .WithMany(s => s.imageModelsList)
                .HasForeignKey(i => i.SagFKId);

        }
    }

}
