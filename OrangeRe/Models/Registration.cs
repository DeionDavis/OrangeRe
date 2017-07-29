using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Trio.DAL;
using OrangeRe.Models.Recipes;

namespace Trio.BAL
{
    public class Registration
    {

        #region VARIABLES
        DBService ObjDB = new DBService();
        #endregion

        #region Insert
        public DataTable Proc_Orange_RecipeInsert(Recipes res)
        {
            DataTable dtEmpDetails = new DataTable();
            ObjDB.command.Parameters.Clear();
            ObjDB.command.Parameters.AddWithValue("@RecipesName", res.RecipesName);
            ObjDB.command.Parameters.AddWithValue("@Description", res.Description);
            ObjDB.command.Parameters.AddWithValue("@RecipesImg", res.RecipesImg);
            dtEmpDetails.Clear();
            dtEmpDetails = ObjDB.GetDataTableSP("Proc_Orange_RecipeInsert");
            return dtEmpDetails;
        }
 
        #endregion
    }
}
