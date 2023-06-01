
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CupcakeMVC.Models
{
    public class DoubleMenu
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string ?Description { get; set; }
        public int Price { get; set; }
        public string ?ImageUrl { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DoubleMenuCategory DoubleMenuCategory { get; set; }

       // public List<Dessert_DoubleMenu> Dessert_DoubleMenus { get; set; }

        //drinks
        public int DrinksId { get; set; }
        [ForeignKey("DrinksId")]
        public Drinks ?Drinks { get; set; }

        //desserts
        public int DessertId { get; set; }
        [ForeignKey("DessertId")]
        public Dessert? Desserts { get; set; }
    }
}
