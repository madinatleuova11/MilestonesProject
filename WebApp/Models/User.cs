using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class User
    {
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Discount card id")]
        [ForeignKey("DiscountCard")]
        public int DiscountCardId { get; set; }

        [Display(Name = "Date of birth")]
        public DateTime DateOfBirth { get; set; }

    }
}
