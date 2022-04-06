#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Hotel.Models;

namespace Hotel.Data
{
    public class HotelContext : DbContext
    {
        public HotelContext (DbContextOptions<HotelContext> options)
            : base(options)
        {
        }

        public DbSet<Hotel.Models.Task> Task { get; set; }

        public DbSet<Hotel.Models.Booking> Booking { get; set; }

        public DbSet<Hotel.Models.Room> Room { get; set; }

        public DbSet<Hotel.Models.Service> Service { get; set; }
    }
}
