using System.ComponentModel.DataAnnotations;

namespace Hotellerie_Amir.Models.HotellerieModel
{
    public class Hotel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Ce Champ est obligatoire ! ")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "longeur entre 3 et 20 !")]
        public String Nom { get; set; } = null!;

        [Range(1 , 5 , ErrorMessage = " valeur entre 1 et 5 ")]
        public int Etoiles { get; set; }

        [Required(ErrorMessage = "Ville obligatoire")]
        public String Ville { get; set; } = null!;

        public String Pays { get; set; } = null!;

        public int Tel { get; set; }

        [Required]
        [Url]
        [Display(Name = "Site Web")]
        public string SiteWeb { get; set; } = null!;

        public virtual ICollection<Appreciation>? Appreciations { get; set; }

    }
}
