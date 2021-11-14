using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibApp_Gr2.Data;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace LibApp_Gr2.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationDbContext(
                serviceProvider.GetRequiredService <DbContextOptions<ApplicationDbContext>>()))
            {
                if(context.MembershipTypes.Any())
                {
                    Console.Write("Database already seeded");
                    return;
                }
                context.MembershipTypes.AddRange(

                    new MembershipType
                    {
                        Id = 1,
                        SignUpFre = 0,
                        DurationInMonths = 0,
                        DiscountRate = 0
                    },
                    new MembershipType
                    {
                        Id = 2,
                        SignUpFre = 30,
                        DurationInMonths = 1,
                        DiscountRate = 10
                    },
                    new MembershipType
                    {
                        Id = 3,
                        SignUpFre = 90,
                        DurationInMonths = 3,
                        DiscountRate = 15
                    },
                    new MembershipType
                    {
                        Id = 4,
                        SignUpFre = 300,
                        DurationInMonths = 12,
                        DiscountRate = 20
                    }
                );
                context.SaveChanges();
            }
        }

        internal static void Initialize()
        {
            throw new NotImplementedException();
        }
    }
}
