using ListingTodos.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListingTodos.Database
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql("Host=ec2-54-247-89-181.eu-west-1.compute.amazonaws.com;Database=da99lvpjk0ipdr;Username=kdxedzxohvmymc;Password=84a675e0c8a29b50270666ecc5d75b25dedbe36329404d790cdd9a45a24bfee8");
        public DbSet<Todo> Todos { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
