using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace proyecto.Models
{
    public class clienteContext:DbContext
    {
        public DbSet<cliente> clientes { get; set; }

    }
}