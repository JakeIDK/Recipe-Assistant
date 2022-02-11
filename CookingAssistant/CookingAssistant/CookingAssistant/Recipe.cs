using System;
using System.Collections.Generic;
using System.Text;

namespace CookingAssistant
{
    class Recipe
    {
        public string RecipeName { get; set; }
        public string RecipeStep { get; set; }

        public Recipe(string RecipeName, string RecipeStep)
        {
            this.RecipeName = RecipeName;
            this.RecipeStep = RecipeStep;
        }
    }
}
