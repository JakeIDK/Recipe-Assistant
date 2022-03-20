using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace CookingAssistant.Models
{
    class Recipe
    {
        [PrimaryKey, AutoIncrement]
        public string Recipename { get; set; }
        public string Recipesteps { get; set; }

        
    }
}
