using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PagesMovie.Models;

namespace PagesMovie.Data
{
    public class PagesMovieContext : DbContext
    {
        public PagesMovieContext (DbContextOptions<PagesMovieContext> options)
            : base(options)
        {
        }

        public DbSet<PagesMovie.Models.Movie> Movie { get; set; }
    }
}
