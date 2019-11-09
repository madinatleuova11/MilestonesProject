using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class Basket
    {
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Display(Name = "User Id")]
        [ForeignKey("User")]
        public int UserId { get; set; }

        [Display(Name = "Item Id")]
        [ForeignKey("Item")]
        public int ItemId { get; set; }

    }
}
