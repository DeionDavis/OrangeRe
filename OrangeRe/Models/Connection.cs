using System.Data.Entity;

namespace OrangeRe.Models
{
    public class Connection : DbContext
    {
        /// <summary>
        /// This make connection possible to the database. 
        /// The name of this class name same as the name of the connection in web.config
        /// </summary>
        public DbSet<Details> details { get; set; }
        /// <summary>
        /// Recipes Db set
        /// </summary>
        public DbSet<Recipes.Recipes> Recipes { get; set; }
    }
}