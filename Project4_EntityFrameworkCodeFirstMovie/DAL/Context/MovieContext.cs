using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Security.Cryptography.X509Certificates;
using Project4_EntityFrameworkCodeFirstMovie.DAL.Entities;


namespace Project4_EntityFrameworkCodeFirstMovie.DAL.Context
{
    public class MovieContext:DbContext
    {
       public DbSet<Movie> Movies { get; set; }
       public DbSet<Category> Categories { get; set; }

    }
}
