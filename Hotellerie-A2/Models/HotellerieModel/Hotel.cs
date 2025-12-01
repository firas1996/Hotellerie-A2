using System.ComponentModel.DataAnnotations;

namespace Hotellerie_A2.Models.HotellerieModel
{
    public class Hotel
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="The Nom property is required !!!")]
        [StringLength(20,MinimumLength =3,ErrorMessage ="....")]
        public string Nom { get; set; }
        [Range(1,5,ErrorMessage ="The Etoiles property must be between 1 and 5 !!!")]
        public int Etoiles { get; set; }
        [Required(ErrorMessage ="The Ville property is required !!!")]
        public string Ville { get; set; }
        [Required]
        [Display(Name ="Site Web")]
        [RegularExpression(@"^(http|https)://([\w-]+.)[\w-]+(/[\w- ./?%&=]*)?$", ErrorMessage = "The SiteWeb property must be a valid URL")]
        public string SiteWeb { get; set; }
        public string Tel { get; set; }
        public virtual ICollection<Appreciation>? Appreciations { get; set; } = new List<Appreciation>();
    }
}
