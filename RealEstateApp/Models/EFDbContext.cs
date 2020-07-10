using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace RealEstateApp.Models
{
    public class EFDbContext : DbContext
    {
        public DbSet<House> Houses { get; set; }
        public DbSet<Realtor> Realtors { get; set; }
    }
}
