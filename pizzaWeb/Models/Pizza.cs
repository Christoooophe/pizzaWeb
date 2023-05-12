using System.ComponentModel.DataAnnotations;

namespace pizzaWeb.Models
{
    public class Pizza
    {
        public int PizzaId { get; set; }
        [Display(Name = "Nom")]
        public string nom { get; set; }
        [Display(Name = "Prix")]
        public int prix { get; set; }
        [Display(Name = "Végétarienne")]
        public bool vege { get; set; }
        [Display(Name = "Ingrédients")]
        public string ingredients { get; set; }
    }
}
