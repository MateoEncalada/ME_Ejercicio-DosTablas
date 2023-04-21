using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ME_Ejercicio_DosTablas.Models;

namespace ME_Ejercicio_DosTablas.Data
{
    public class ME_DBContext : DbContext
    {
        public ME_DBContext (DbContextOptions<ME_DBContext> options)
            : base(options)
        {
        }

        public DbSet<ME_Ejercicio_DosTablas.Models.Burger> Burger { get; set; } = default!;

        public DbSet<ME_Ejercicio_DosTablas.Models.Promo>? Promo { get; set; }
    }
}
