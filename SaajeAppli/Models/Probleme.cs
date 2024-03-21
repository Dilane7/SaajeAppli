using SaajeAppli.Areas.Identity.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SaajeAppli.Models
{
    public class Probleme
    {
        [Key]
        public Guid ProblemeId { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Date")]
        public DateTime PbDate { get; set; }

        [DataType(DataType.MultilineText)]
        [Display(Name = "Probleme")]
        public string PbIntitule { get; set; }

        public Guid? ProjetId { get; set; }
        [ForeignKey("ProjetId")]
        public virtual Projets Projets { get; set; }


        public String? UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual AppUser AppUsers { get; set; }
    }
}
