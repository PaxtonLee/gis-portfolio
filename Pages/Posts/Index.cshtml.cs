using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using gis_portfolio.Data;
using gis_portfolio.Models;

namespace gis_portfolio.Pages.Posts
{
    public class IndexModel : PageModel
    {
        private readonly gis_portfolio.Data.gis_portfolioContext _context;

        public IndexModel(gis_portfolio.Data.gis_portfolioContext context)
        {
            _context = context;
        }
        public IEnumerable<Post> Posts { get; set; }

        public IList<Post> Post { get;set; }

        public async Task OnGetAsync()
        {
            Post = await _context.Post.ToListAsync();
        }
    }
}
