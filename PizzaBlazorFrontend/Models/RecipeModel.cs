using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaBlazorFrontend.Models
{
    public class RecipeModel
    {
        public int RecipeId { get; set; }
        public int ProductId { get; set; }
        public string ProductRecipe { get; set; }
        public string ProductName { get; set; }
    }
}
