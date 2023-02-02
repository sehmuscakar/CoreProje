﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.conrete
{
  public  class Experience
    {
        [Key]
        public int ExprerienceID { get; set; }

        public string Name { get; set; }

        public string Date { get; set; }

        public string ImageUrl { get; set; }

        public string Description { get; set; }


    }
}
