using StoreApi.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace StoreApi.DB
{
    public class DataContext : DbContext
    {
        public DataContext()
            : base("DbConnection")
        { }

        public DbSet<Person> Users { get; set; }
        public DbSet<Store> Stores { get; set; }
    }
   


    
}