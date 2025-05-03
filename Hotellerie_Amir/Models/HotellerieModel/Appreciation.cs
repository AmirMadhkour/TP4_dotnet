using System.ComponentModel.DataAnnotations;

namespace Hotellerie_Amir.Models.HotellerieModel
{
    public class Appreciation
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Nom Personne")]
        public String NomPers { get; set; } = null!;
        [Required]
        [DataType(DataType.MultilineText)]
        public String Commentaire { get; set; } = null!;

        public int HotelId { get; set; }

        [Required]
        [Range(1, 10, ErrorMessage = "La note doit être comprise entre 1 et 10")]
        public int Note { get; set; }

        public virtual Hotel? Hotel { get; set; }


    }
}
