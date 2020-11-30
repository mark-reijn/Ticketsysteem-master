using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace TicketSysteemMVC5.Models
{

    public class ApplicationUser : IdentityUser
    {

        [StringLength(64)]
        [Required]
        public string Voornaam { get; set; }

        [StringLength(32)]
        public string Tussenvoegsel{ get; set; }

        [StringLength(64)]
        [Required]
        public string Achternaam { get; set; }

        [StringLength(11)]
        public string Telefoonnummer { get; set; }

        public bool ChangePassword { get; set; } = false;

        [NotMapped]
        public string Naam => $"{Voornaam} {Tussenvoegsel} {Achternaam}";

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {

            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);

            return userIdentity;
        }

        public virtual ICollection<Ticket> Tickets { get; set; }

        public virtual ICollection<Applicatie> Applicaties { get; set; }
    }
}