using Model;
using System;
using System.Collections.Generic;
using System.Data.Common; // für DbConnection
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class BreakAwayContext : DbContext
    {
        public BreakAwayContext() { }

        public BreakAwayContext(string databaseName) : base(databaseName) { }

        public BreakAwayContext(DbConnection connection) : base(connection, contextOwnsConnection: false) { }

        public DbSet<Destination> Destinations { get; set; }
        public DbSet<Lodging> Lodgings { get; set; }
        public DbSet<Trip> Trips { get; set; }
        public DbSet<Person> People { get; set; }
    }
}
