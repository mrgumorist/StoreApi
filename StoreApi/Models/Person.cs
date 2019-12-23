using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StoreApi.Models
{
    public class Person
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Inizialu { get; set; }
        public string Login { get; set; }
        public string PassWord { get; set; }
        public string Type { get; set; } = "Seller";//Admin, Owner 
        public DateTime LastLogin { get; set; }
        public virtual Store Store { get; set; }
    }
}