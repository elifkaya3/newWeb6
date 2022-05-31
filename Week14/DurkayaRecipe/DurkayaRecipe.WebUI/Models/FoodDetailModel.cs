using DurkayaRecipe.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DurkayaRecipe.WebUI.Models
{
    public class FoodDetailModel
    {
        public Food Food { get; set; }
        public List<Category> Categories { get; set; }
    }
}
