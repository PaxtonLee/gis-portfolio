using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using gis_portfolio.Models;

namespace gis_portfolio.Data
{
    public class gis_portfolioContext : DbContext
    {
        public gis_portfolioContext (DbContextOptions<gis_portfolioContext> options)
            : base(options)
        {
        }

        public DbSet<gis_portfolio.Models.Post> Post { get; set; }
    }
}
