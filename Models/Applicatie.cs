using System.ComponentModel.DataAnnotations;

namespace TicketSysteemMVC5.Models
{

    public class Applicatie
    {

        public int Id { get; set; }

        [StringLength(64)]
        [Required]
        public string Naam { get; set; }

        public ApplicationUser Beheerder { get; set; }
    }
}