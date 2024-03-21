using SaajeAppli.Areas.Identity.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SaajeAppli.Models
{
    public class Tache
    {
        [Key] 
        public Guid TacheId { get; set; 
        }
        [DataType(DataType.Date)]
        [Display(Name = "Date")]
        public string TacheDate { get; set; }

        [DataType(DataType.MultilineText)]
        [Display(Name = "Tache")]
        public string TacheDescription { get; set;}

        public Guid? ProjetId { get; set; }
        [ForeignKey("ProjetId")]
        public virtual Projets Projets { get; set; }

        public String? UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual AppUser AppUsers { get; set; }

    }
}
