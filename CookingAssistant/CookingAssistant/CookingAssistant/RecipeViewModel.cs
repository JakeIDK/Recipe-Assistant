using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text;

namespace CookingAssistant
{
    class RecipeViewModel
    {
        public ObservableCollection<Recipe> Recipes { get; set; }

        public RecipeViewModel() 
        {
            Recipes = new ObservableCollection<Recipe>();
        }
    }
}
