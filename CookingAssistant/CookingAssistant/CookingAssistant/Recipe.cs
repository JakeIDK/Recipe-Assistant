using System;
using System.Collections.Generic;
using System.Text;

namespace CookingAssistant
{
    public class Recipe
    {
        public string RecipeStep { get; set; }

        public Recipe( string RecipeStep)
        {
            this.RecipeStep = RecipeStep;
        }
    }
}
