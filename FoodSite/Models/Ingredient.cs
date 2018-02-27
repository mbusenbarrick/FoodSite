using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodSite.Models
{
    public class Ingredient
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int ServingSize { get; set; }
        public string ServingSizeUnit { get; set; }
        public int Calories { get; set; }
        public int Protein { get; set; }
        public int Carbs { get; set; }
        public int Fat{ get; set;}
    }

}
