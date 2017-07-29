using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using OrangeRe.Models.Recipes;

namespace OrangeRe.Models
{
    public class Connection : DbContext
    {
        /// <summary>
        /// This make connection possible to the database. 
        /// The name of this class name same as the name of the connection in web.config
        /// </summary>
        public DbSet<Details> details { get; set; }
        
       public System.Data.Entity.DbSet<OrangeRe.Models.Recipes.Recipes> Recipes { get; set; }


    }
}