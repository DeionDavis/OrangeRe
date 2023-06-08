using System.Data;
using Trio.DAL;
using OrangeRe.Models.Recipes;

namespace Trio.BAL
{
    public class Registration
    {
        DBService ObjDB = new DBService();

        /// <summary>
        /// Method to insert recipe
        /// </summary>
        /// <param name="res"><see cref="Recipes"/></param>
        /// <returns>Return employ details</returns>
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
    }
}
