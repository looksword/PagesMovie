using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PagesMovie.Data;
using PagesMovie.Models;

namespace PagesMovie.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly PagesMovie.Data.PagesMovieContext _context;

        public IndexModel(PagesMovie.Data.PagesMovieContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
