using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using CookingAssistant.Views;

namespace CookingAssistant
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        public async void RecipeCreate(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new RecipeCreation());
        }
        public async void RecipeLoad(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new RecipeLoad());
        }
        
    }
}
