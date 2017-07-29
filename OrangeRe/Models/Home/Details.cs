using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OrangeRe.Models
{
    [Table("MyIncredient")] //contain table name that we want to take data
    public class Details
    {
        /// <summary>
        /// This is the columns of the table. This must same as table.
        /// This will get the data from the table
        /// </summary>
        /// 
        [Key]
        public string Principle { get; set; }
        public string Nutrient { get; set; }
        public string Percent { get; set; }
    }
}