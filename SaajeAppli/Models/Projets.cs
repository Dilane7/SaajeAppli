using SaajeAppli.Areas.Identity.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SaajeAppli.Models
{
    public class Projets
    {
        [Key]
        public Guid ProjetId { get; set; }

        [Required]
        [StringLength(maximumLength: 200, MinimumLength = 10)]
        [Display(Name = "Non du projet")]
        public string ProjetName { get; set; }

        [Display(Name = "Plan d'action")]
        public string PlanAction { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Date de debut")]
        public DateTime DateDebut { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Delais")]
        public DateTime DateLine { get; set; }

        [Display(Name = "Etat du projet")]
        public string EtatProjet { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Date de Cloture")]
        public DateTime DateCloture { get; set; }

        public ICollection<Commentaire> Commentaires { get; set;}

        public ICollection<Probleme> Problemes { get; set;}

        public ICollection<Tache> Taches { get; set;}


        public String? UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual AppUser AppUsers { get; set; }



    }
}
