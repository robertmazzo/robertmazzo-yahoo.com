using System;
using System.ComponentModel.DataAnnotations;
namespace GigHub.Models
{
    /// <summary>
    ///  ***NB: we need to associate this class with another class
    /// that represents a user in GigHub; see ApplicationUser in IdentityModels
    /// </summary>
    public class Gig
    {
        public int Id { get; set; }

        [Required]
        public ApplicationUser Artist { get; set; }

        public DateTime DateTime { get; set; }

        [Required]
        [StringLength(255)]
        public string Venue { get; set; }

        [Required]
        public Genre Genre
        { get; set; }
    }    
}
