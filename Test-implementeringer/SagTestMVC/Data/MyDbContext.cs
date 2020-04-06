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
        //protected override void OnConfiguring(DbContextOptionsBuilder ob)
        //{
        //    // For SQLServer file, this is
        //    ob.UseSqlServer("Data Source=127.0.0.1,1433;Database=Sag;User ID=SA;Password=SecurePassword1!");
        //}

        public MyDBContext(DbContextOptions<MyDBContext> options)
            : base(options)
        {

        }

        public DbSet<Sag> Sag { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Sag>().HasKey(s => new { s.SubjectId });

        }
    }

}
