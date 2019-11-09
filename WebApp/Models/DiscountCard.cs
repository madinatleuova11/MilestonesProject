using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class DiscountCard
    {
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Display(Name = "type")]
        public int type { get; set; }

    }
}
