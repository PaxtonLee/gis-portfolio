using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gis_portfolio.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public Sort sort{ get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
        }

        public void OnGet()
        {

        
    }}
        
    public enum Sort
    {
        AZ,
        ZA,
        Date,
        Category


    }
}