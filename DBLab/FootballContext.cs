using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBLab
{
    public class FootballContext : DbContext
    {
        public FootballContext() : base("DbConnection") { }
        public DbSet<Player> Players { get; set; }
        public DbSet<Coach> Coaches { get; set; }
        public DbSet<Team> Teams { get; set; }
    }
}
