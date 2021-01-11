using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Proiect_Robert.Models;

namespace Proiect_Robert.Data
{
    public class Proiect_RobertContext : DbContext
    {
        public Proiect_RobertContext (DbContextOptions<Proiect_RobertContext> options)
            : base(options)
        {
        }

        public DbSet<Proiect_Robert.Models.Game> Game { get; set; }
    }
}
