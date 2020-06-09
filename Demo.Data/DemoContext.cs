using Demo.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Data
{
    public class DemoContext:DbContext
    {
        public DemoContext(DbContextOptions<DemoContext> options):base(options)
        {

        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=DemoDB;User ID=sa;Password=Jiwanyue521");
        //}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //多对多
            modelBuilder.Entity<GamePlayer>().HasKey(e => new { e.GameId, e.PlayerId });
            //一对一
            modelBuilder.Entity<Resume>().HasOne(e => e.Player).WithOne(e => e.Resume).HasForeignKey<Resume>(e => e.PlayerId);
        }
        public DbSet<Club> Clubs { get; set; }
        public DbSet<Player>  Players { get; set; }
        public DbSet<League>  Leagues { get; set; }
        public DbSet<Game>  Games { get; set; }
        public DbSet<Resume>  Resumes { get; set; }

    }
}
