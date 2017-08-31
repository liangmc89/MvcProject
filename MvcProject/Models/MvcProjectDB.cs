using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MvcProject.Models
{
    public class MvcProjectDB:DbContext
    {
        public MvcProjectDB() : base("DefaultConnection") {
        }
        public DbSet<Album> Albums { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Genre> Genres { get; set; }
    }
}