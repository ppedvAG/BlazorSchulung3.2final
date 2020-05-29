using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorSchulung3._2final.Data
{
    public class AufgabenContext:DbContext
    {
        public DbSet<Aufgabe2> Aufgabe2 { get; set; }

        public AufgabenContext(DbContextOptions<AufgabenContext> options ):base(options)
        {

        }
    }
}
