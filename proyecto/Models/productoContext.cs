﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace proyecto.Models
{
    public class productoContext:DbContext
    {

    
        public DbSet<producto> productos { get; set; }
       

    }


}