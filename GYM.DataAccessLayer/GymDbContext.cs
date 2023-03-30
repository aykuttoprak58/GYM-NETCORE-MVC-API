using GYM.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYM.DataAccessLayer
{
     public class GymDbContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=HPISNET;Initial Catalog=GYMDB2;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");

            optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);

         
        }

        public DbSet<CourseEntity> courseEntitity { get; set; }

        public DbSet<SalonEntity> salonEntitity { get; set; }

        public DbSet<TranierEntity> tranierEntitity { get; set; }

        public DbSet<UserEntity> userEntitity { get; set; }

    }
}
