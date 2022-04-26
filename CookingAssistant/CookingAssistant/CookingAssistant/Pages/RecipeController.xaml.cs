using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CookingAssistant.Interface;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CookingAssistant
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RecipeController : ContentPage
    {
        string command;
        
        public RecipeController()
        {
            InitializeComponent();
        }

        public async void NextStep(object sender, EventArgs e)
        {
            var bluetoothService = DependencyService.Get<IBluetoothService>();
            string SelectedDevice = bluetoothService.DeviceName();
            command = "Next";
            await bluetoothService.Send(SelectedDevice, command);
        }
        public async void RepeatStep(object sender, EventArgs e)
        {
            var bluetoothService = DependencyService.Get<IBluetoothService>();
            string SelectedDevice = bluetoothService.DeviceName();
            command = "Repeat";
            await bluetoothService.Send(SelectedDevice, command);
        }
        public async void StopRecipe(object sender, EventArgs e)
        {
            var bluetoothService = DependencyService.Get<IBluetoothService>();
            string SelectedDevice = bluetoothService.DeviceName();
            command = "Stop";
            await bluetoothService.Send(SelectedDevice, command);
        }
    }
}