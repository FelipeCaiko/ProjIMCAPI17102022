using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjAPI17102022.Models;

namespace ProjAPI17102022.Data
{
    public class ProjAPI17102022Context : DbContext
    {
        public ProjAPI17102022Context (DbContextOptions<ProjAPI17102022Context> options)
            : base(options)
        {
        }

        public DbSet<ProjAPI17102022.Models.Person> Person { get; set; }
    }
}
