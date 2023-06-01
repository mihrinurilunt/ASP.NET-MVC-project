using System.ComponentModel.DataAnnotations;

namespace CupcakeMVC.Models
{
    public class Dessert
    {
        [Key]
        public int DessertId { get; set; }
        public string ?DessertPhotoURL { get; set; }
       
        public string? Name { get; set; }
        
        public string? Description { get; set; }
       
        public int Price { get; set; }
        
        public List<DoubleMenu>? DoubleMenus { get; set; }
        
    }   
}
