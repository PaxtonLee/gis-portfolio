
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gis_portfolio.Models
{
    public class Post
    {
        public int ID { get; set; }
        public string Title { get; set; }
        [Display(Name = "Description")]
        public string short_desc { get; set; }
        [Display(Name = "Date")]
        [DataType(DataType.Date)]
        public DateTime date { get; set; }
        [Display(Name = "Author")]
        public string author { get; set; }
        public string long_desc { get; set; }
        public string photo { get; set; }


    }
}