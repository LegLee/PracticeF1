﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PracticeF1.Models
{
    public class Stuff
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public int id_dep { get; set; }
    }
}
