using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using petrina_ioana_colocviu.Models;

namespace petrina_ioana_colocviu.Data
{
    public class petrina_ioana_colocviuContext : DbContext
    {
        public petrina_ioana_colocviuContext (DbContextOptions<petrina_ioana_colocviuContext> options)
            : base(options)
        {
        }

        public DbSet<petrina_ioana_colocviu.Models.Coffee> Coffee { get; set; }
    }
}
