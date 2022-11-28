using Ank9ServerApiModel.Data.Configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ank9ServerApiModel.Data
{
    public class ServerApiContext:DbContext
    {
        public ServerApiContext(DbContextOptions<ServerApiContext>options):base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new KisiConfiguration());
        }
        public DbSet<Kisi> Kisiler { get; set; }
    }
}
