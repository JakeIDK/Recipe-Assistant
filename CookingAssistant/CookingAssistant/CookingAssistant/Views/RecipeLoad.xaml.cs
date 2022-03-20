using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using CookingAssistant.Models;
using Xamarin.Forms.Xaml;

namespace CookingAssistant.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RecipeLoad : ContentPage
    {
        public RecipeLoad()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            var recipes = new List<Recipe>();
            var files = Directory.EnumerateFiles(App.FolderPath, "*.notes.txt");
            foreach (var recipename in files)
            {
                recipes.Add(new Recipe
                {
                    Recipename = recipename,
                    Recipesteps = File.ReadAllText(recipename),
                });
                collectionView.ItemsSource = recipes.ToList();
            }
            }
        async void RecipeChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection != null)
            {
                Recipe recipe = (Recipe)e.CurrentSelection.FirstOrDefault();
                await Shell.Current.GoToAsync($"{nameof(RecipeCreation)}?{nameof(RecipeCreation.RecipeId)}={recipe.Recipename}");
            }
        }
    }
}