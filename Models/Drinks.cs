using System.ComponentModel.DataAnnotations;

namespace CupcakeMVC.Models
{
    public class Drinks
    {
        [Key]
        public int DrinksId { get; set; }
        public string? DrinkPhotoURL { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int Price { get; set; }
        public List<DoubleMenu>? DoubleMenus { get; set; }
    }
}
