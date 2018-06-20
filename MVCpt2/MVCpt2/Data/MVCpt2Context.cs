using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MVCpt2.Models
{
    public class MVCpt2Context : DbContext
    {
        public MVCpt2Context (DbContextOptions<MVCpt2Context> options)
            : base(options)
        {
        }

        public DbSet<MVCpt2.Models.Movie> Movie { get; set; }
    }
}
