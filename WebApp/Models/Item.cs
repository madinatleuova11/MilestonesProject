﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class Item
    {
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Display(Name = "Item name")]
        public string Name { get; set; }

        [Display(Name = "Price")]
        public double Price { get; set; }
    }
}
