using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SagTest.Data;

namespace SagTest.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new SagTestContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<SagTestContext>>()))
            {
                // Look for any movies.
                if (context.Sag.Any())
                {
                    return;   // DB has been seeded
                }

                context.Sag.AddRange(
                    new Sag
                    {
                        Subject = "NGK",
                        Text = "Jeg mangler...",
                        URLImage = "URL link"
                    },
                    new Sag
                    {
                        Subject = "SWD",
                        Text = "Jeg mangler...",
                        URLImage = "URL link"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
