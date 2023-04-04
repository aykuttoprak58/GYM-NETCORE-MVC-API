using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.EntityFrameworkCore;

namespace GYM_API.Models
{
    public class gymDbContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=HPISNET;Initial Catalog=GYMDB1;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }

        public DbSet<courseEntity> courseEntitity { get; set; }

        public DbSet<salonEntity> salonEntitity { get; set; }

        public DbSet<tranierEntity> tranierEntitity { get; set; }

        public DbSet<userEntity> userEntitity { get; set; }
    }
}
