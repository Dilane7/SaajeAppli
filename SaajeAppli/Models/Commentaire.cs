using SaajeAppli.Areas.Identity.Data;
using SaajeAppli.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SaajeAppli.Models
{
    public class Commentaire
    {
        [Key]
        public Guid CommentaireId { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Date")]
        public DateTime ComDate { get; set; }

        [DataType(DataType.MultilineText)]
        [Display(Name = "Commentaire")]
        public string ComIntitule { get; set; }

        public Guid? ProjetId { get; set; }
        [ForeignKey("ProjetId")]
        public virtual Projets Projets { get; set; }

        public String? UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual AppUser AppUsers { get; set; }

    }
}
