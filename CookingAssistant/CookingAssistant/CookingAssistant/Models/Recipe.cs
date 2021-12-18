using System;
using System.Collections.Generic;
using System.Text;

namespace CookingAssistant.Models
{
   public class Recipe
    {
        public string FileName { get; set; }
        public string Steps { get; set; }
        public DateTime Date { get; set; }
    }
}
