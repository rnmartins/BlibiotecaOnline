using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BlibiotecaOnline.Models;

namespace BlibiotecaOnline.Data
{
    public class BlibiotecaOnlineContext : DbContext
    {
        public BlibiotecaOnlineContext (DbContextOptions<BlibiotecaOnlineContext> options)
            : base(options)
        {
        }

        public DbSet<BlibiotecaOnline.Models.Livro> Livro { get; set; } = default!;
    }
}
