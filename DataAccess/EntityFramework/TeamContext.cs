using System;
using Microsoft.EntityFrameworkCore;
using EntityLevelup.Models;

namespace EntityLevelup.DataAccess.EntityFramework {

    public class TeamContext : DbContext {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlite("Filename=./LevelupTeam.db");
        }
        
        public DbSet<Person> Person { get; set; }

        public DbSet<Team> Team { get; set; }

        public DbSet<TeamAllocation> TeamAllocation {get; set;}

    }
    
}