using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CookingAssistant
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RecipeCreation : ContentPage
    {
        public RecipeCreation()
        {
            InitializeComponent();
        }
        async void EndRecipe(object sender, EventArgs e)
            {
            string title = await DisplayPromptAsync("What would you like to name the Recipe?","");
            }
    }
}