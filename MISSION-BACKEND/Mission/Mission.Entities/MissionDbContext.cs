using Microsoft.EntityFrameworkCore;
using Mission.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission.Entities
{
    public class MissionDbContext(DbContextOptions<MissionDbContext> options) : DbContext(options)
    {
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(new User()
            {
                Id = 1,
                FirstName = "Aftab",
                LastName = "Safiya",
                EmailAddress = "aftabsafiya87@gmail.com",
                Password = "aftab12",
                PhoneNumber = "7990175749",
                UserType = "admin",
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
