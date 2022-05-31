using DurkayaRecipe.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DurkayaRecipe.WebUI.Models
{
    public class FoodModel
    {
        public int FoodId { get; set; }

        [Required(ErrorMessage = "Yemek ismi zorunludur!")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Ürün ismi 5-50 karakter uzunluğunda olmalıdır!")]
        public string FoodName { get; set; }
        public string ImageUrl { get; set; }

        [Required(ErrorMessage = "Malzeme zorunludur!")]
        [StringLength(500, MinimumLength = 20, ErrorMessage = "Açıklama 20-500 karakter uzunluğunda olmalıdır!")]
        public string FoodMaterial { get; set; }

        [Required(ErrorMessage = "Açıklama zorunludur!")]
        [StringLength(500, MinimumLength = 20, ErrorMessage = "Açıklama 20-900 karakter uzunluğunda olmalıdır!")]
        public string FoodDescription { get; set; }
        public string Url { get; set; }
        public bool IsApproved { get; set; }
        public bool IsHome { get; set; }
        public List<Category> SelectedCategories { get; set; }

    }
}
