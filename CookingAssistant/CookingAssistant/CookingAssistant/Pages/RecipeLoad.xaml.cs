using CookingAssistant.Interface;
using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        string recipeData;
        
        public RecipeLoad()
        {     
            InitializeComponent();
        }
        public async void SendRecipe(object sender, EventArgs e) 
        {
            var bluetoothService = DependencyService.Get<IBluetoothService>();
            string SelectedDevice = bluetoothService.DeviceName();
            var recipeSelection = await FilePicker.PickAsync();
            if (recipeSelection == null)
            {
                return;
            }
            recipeData = recipeSelection.ToString();
            await bluetoothService.Send(SelectedDevice, recipeData);
            await Navigation.PushAsync(new RecipeController());
        }
    }
}