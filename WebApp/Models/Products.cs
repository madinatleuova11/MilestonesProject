using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class Products
    {
        [Display(Name = "User")]
        [ForeignKey("User")]
        public int Id { get; set; }

        [Display(Name = "List of items: ")]
        public List<Item> Items { get; set; }
    }
}
