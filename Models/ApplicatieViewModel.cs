using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TicketSysteemMVC5.Models
{

    public class ApplicatieViewModel
    {

        public int Id { get; set; }

        [StringLength(64)]
        [Required]
        public string Naam { get; set; }

        public string BeheerderId { get; set; }

        public List<ApplicationUser> Medewerkers { get; set; }
    }
}