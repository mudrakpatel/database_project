using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for RecipeRpository
/// </summary>
public class RecipeRpository
{
    public RecipeRpository()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public List<Recipe> GetRecipes()
    {
        //context to get to the application object
        //httpContext access to all the objects your website has
        //HttpApplication is your web application 
        HttpApplication webApp = HttpContext.Current.ApplicationInstance;

        //web app can access Application["students"]
        return (List<Recipe>)webApp.Application["recipes"];
    }
}