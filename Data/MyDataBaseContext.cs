using Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    public class MyDataBaseContext : DbContext
    {        
        public DbSet<User> Users { get; set; }
        public DbSet<Vehicule> Vehicules { get; set; }
        public DbSet<Intervention> Interventions { get; set; }
        public MyDataBaseContext(DbContextOptions<MyDataBaseContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
        }
    }
}
