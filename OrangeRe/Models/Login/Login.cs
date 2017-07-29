using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OrangeRe.Models.Recipes
{
    [Table("Login")]
    public class Login
    {
        public int LoginID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string UserType { get; set; }
        public virtual ICollection<Recipes> Recipe { get; set; }
    }
}