using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CookingAssistant.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CookingAssistant
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(RecipeCreation), typeof(RecipeCreation));
        }
    }
}