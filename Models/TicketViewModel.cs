using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TicketSysteemMVC5.Models
{

    public class TicketViewModel
    {

        public int Id { get; set; }

        public string KlantId { get; set; }

        public ApplicationUser Klant { get; set; }

        [Required]
        public int ApplicatieId { get; set; }

        public List<Applicatie> Applicaties { get; set; }

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
        
        //ticketnummer 1020 categorieen aanmaken
        public TicketCategorie Categorie { get; set; } = TicketCategorie.Open;

        //einde ticketnummer 1020
    }
}