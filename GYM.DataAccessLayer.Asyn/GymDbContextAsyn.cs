using GYM.Entities.Asyn;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYM.DataAccessLayer.Asyn
{
     public class GymDbContextAsyn :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=HPISNET;Initial Catalog=GYMDBASYN;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");

            optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);


        }

        public DbSet<CourseEntity> courseEntitity { get; set; }

        public DbSet<SalonEntity> salonEntitity { get; set; }

        public DbSet<TranierEntity> tranierEntitity { get; set; }

        public DbSet<UserEntity> userEntitity { get; set; }

    }
}
