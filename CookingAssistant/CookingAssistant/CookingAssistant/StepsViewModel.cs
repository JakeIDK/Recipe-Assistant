using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;
using System.Collections.Generic;
using System.Text;

namespace CookingAssistant
{
    class StepsViewModel
    {
        int i = 1;
        public ObservableCollection<Recipe> Steps { get; set; }
        public ICommand AddStepCommand => new Command(AddStep);
        public string NewStepInputValue { get; set; }

        public StepsViewModel()
        {
            Steps = new ObservableCollection<Recipe>();
        }
        void AddStep() 
        {
            Steps.Add(new Recipe("","Step "+i+" "+NewStepInputValue));
            i++;
        }
        void AddName()
        {
            Steps.Add(new Recipe(NewStepInputValue,""));
        }
    }

}
