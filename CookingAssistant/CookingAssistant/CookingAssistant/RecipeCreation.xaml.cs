using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using CookingAssistant.Models;
using Xamarin.Forms.Xaml;

namespace CookingAssistant
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [QueryProperty(nameof(RecipeId), nameof(RecipeId))]
    public partial class RecipeCreation : ContentPage
    {
        public string title;
        public string RecipeId
        {
            set 
            {
                LoadRecipe(value);
            }
        }
        public RecipeCreation()
        {
            InitializeComponent();

            BindingContext = new Recipe();
        }
        void LoadRecipe(string recipename)
        {
            Recipe recipe = new Recipe
            {
                Recipename = recipename,
                Recipesteps = File.ReadAllText(recipename)
            };
            BindingContext = recipe;
        }
        async void EndRecipe(object sender, EventArgs e)
            {
             title = await DisplayPromptAsync("What would you like to name the Recipe?","");
            var recipe = (Recipe)BindingContext;
            if (string.IsNullOrEmpty(recipe.Recipename))
            {
                var recipename = Path.Combine(App.FolderPath, $"{Path.GetRandomFileName()}.recipe.txt");
            }
            else 
            {
                File.WriteAllText(recipe.Recipename, recipe.Recipesteps);
            }
            await Shell.Current.GoToAsync(" ");
            }
    }
}