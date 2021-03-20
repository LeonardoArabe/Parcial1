﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Parcial1_LeonardoArabe.Models
{
    public class DataContext : DbContext
    {
        public DataContext():base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<Parcial1_LeonardoArabe.Models.Product> Products { get; set; }
    }
}