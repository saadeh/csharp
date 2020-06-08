using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoMVC.Models
{
    public class Context : DbContext 
    {
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Produto> produtos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=TMDC1DB02\BIZAGIDEV;Database=Cursomvc;User ID=sabizagi; Password=Bpm@2014; Trusted_Connection=False;");

        }
    }
}
