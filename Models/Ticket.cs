using System;
using System.ComponentModel.DataAnnotations;

namespace TicketSysteemMVC5.Models
{
    public enum TicketStatus
    {
        //ticketnummer 1010 wijzigen van ticket statussen.
        Nieuw,
        [Display(Name="In behandeling")]
        InBehandeling,
        Bezet,
        Doorgevoerd,
        Retour,
        Incompleet,
        Test,
        Beheer,
        Afgerond
    }

    //Ticketnummer 1020 categorieen aanmaken
    public enum TicketCategorie
    {
        Open,
        [Display(Name ="Open")]
        Spoed,
        Wens,
        Project,
        Onuitvoerbaar
    }

    //einde ticketnummer 1020

    public class Ticket
    {

        public int Id { get; set; }

        [Required]
        public ApplicationUser Klant { get; set; }

        [Required]
        public Applicatie Applicatie { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}")]
        public DateTime Datum { get; set; }

        [StringLength(128)]
        [Required]
        public string Onderwerp { get; set;  }

        [StringLength(512)]
        public string Omschrijving { get; set; }

        public TicketStatus Status { get; set; } = TicketStatus.Nieuw;

        public TicketCategorie Categorie {get; set;} =TicketCategorie.Open;
    }
}