using Covid19Tracker.Core.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covid19Tracker.Core.Database
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("name=DbConnection") { }
        public virtual DbSet<County> County { get; set; }
        public virtual DbSet<Town> Town { get; set; }
        public virtual DbSet<CovidCase> CovidCase { get; set; }
    }
}
