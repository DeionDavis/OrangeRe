using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace OrangeRe.Models.Recipes
{
    [Table("MyRecipes")]
    public class Recipes:DbContext
    {
        /// <summary>
        /// This is used to display the recorded recipes into the web page
        /// </summary>
        public int RecipesID { get; set; }
        public string RecipesName { get; set; }
        public string Description { get; set; }
        public string RecipesImg { get; set; }
    }
}