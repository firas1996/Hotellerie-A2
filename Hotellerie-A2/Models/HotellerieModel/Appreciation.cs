using System.ComponentModel.DataAnnotations;

namespace Hotellerie_A2.Models.HotellerieModel
{
    public class Appreciation
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "The NomPers property is required !!!")]
        [Display(Name = "Nom Personne")]
        public int NomPers { get; set; }
        [Required(ErrorMessage = "The Commentaire property is required !!!")]
        [DataType(DataType.MultilineText)]
        public string Commentaire { get; set; }
        public int HotelId { get; set; }
        public virtual Hotel? Hotel { get; set; } = null!;
    }
}
