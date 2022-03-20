using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;
using System.Collections.Generic;
using CookingAssistant.Models;
using System.Text;

namespace CookingAssistant
{
    class StepsViewModel
    {
       
        public ObservableCollection<Recipe> Steps { get; set; }
        public ICommand AddStepCommand => new Command(AddStep);
        public string NewStepInputValue { get; set; }

        public StepsViewModel()
        {
            Steps = new ObservableCollection<Recipe>();
        }
        void AddStep() 
        {
           Console.WriteLine("Step "+(Steps.Count+1)+" "+NewStepInputValue);
           
        }
        
    }

}
