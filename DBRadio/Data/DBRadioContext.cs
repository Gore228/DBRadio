using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BDRadio.Models;

namespace DBRadio.Data
{
    public class DBRadioContext : DbContext
    {
        public DBRadioContext (DbContextOptions<DBRadioContext> options)
            : base(options)
        {
        }

        public DbSet<BDRadio.Models.Dolzhnosti> Dolzhnosti { get; set; }

        public DbSet<BDRadio.Models.GrafikRaboti> GrafikRaboti { get; set; }

        public DbSet<BDRadio.Models.Ispolniteli> Ispolniteli { get; set; }

        public DbSet<BDRadio.Models.Sotrudniki> Sotrudniki { get; set; }

        public DbSet<BDRadio.Models.Zapisi> Zapisi { get; set; }

        public DbSet<BDRadio.Models.Zhanri> Zhanri { get; set; }
    }
}
