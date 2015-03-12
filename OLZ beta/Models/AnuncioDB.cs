using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OLZ_beta.Models
{
    public class AnuncioDB : DbContext
    {
        public AnuncioDB()
            : base("DefaultConnection")
        {
        
        }

        public DbSet<Anuncio> Anuncios { get; set; }
    }
}