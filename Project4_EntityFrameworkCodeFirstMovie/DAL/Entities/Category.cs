using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4_EntityFrameworkCodeFirstMovie.DAL.Entities
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public List<Movie> Movies { get; set;}
       
    }
}
