using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CookingAssistant
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RecipeLoad : ContentPage
    {
        public RecipeLoad()
        {
            InitializeComponent();
        }
        public async void SendRecipe(object sender, EventArgs e) 
        {

            var recipeSelection = await FilePicker.PickAsync();
            if (recipeSelection == null)
            {
                return;
            } 

        }
    }
}