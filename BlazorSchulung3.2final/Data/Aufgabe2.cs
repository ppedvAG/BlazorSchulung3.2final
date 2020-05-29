﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorSchulung3._2final.Data
{
    public class Aufgabe2
    {
        public int ID { get; set; }
        public string Text { get; set; }
        public bool Erledigt { get; set; }
        [NotMapped]
        public bool IsEdit { get; set; }
    }
}
