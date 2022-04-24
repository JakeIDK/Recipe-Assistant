using System;
using CookingAssistant.Interface;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Xamarin.Forms;
using Xamarin.Essentials;
using Xamarin.Forms.Xaml;
using Newtonsoft.Json;

namespace CookingAssistant
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RecipeCreation : ContentPage
    {
        string title;
        public RecipeCreation()
        {
            InitializeComponent();

        }
        public async void EndRecipe(object sender, EventArgs e)
            {
            title = await DisplayPromptAsync("What would you like to name the Recipe?","");
            var data = JsonConvert.SerializeObject(Recipe.BindingContext, Formatting.Indented);
            DependencyService.Get<IFileService>().CreateFile(title,data);
            await Navigation.PushAsync(new RecipeLoad());
        }
    }
}