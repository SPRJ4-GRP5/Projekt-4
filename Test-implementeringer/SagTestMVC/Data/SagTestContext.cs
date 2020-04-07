using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SagTest.Models;

namespace SagTest.Data
{
    public class SagTestContext : DbContext
    {
        public SagTestContext (DbContextOptions<SagTestContext> options)
            : base(options)
        {
        }

        public DbSet<SagTest.Models.Sag> Sag { get; set; }
    }
}
