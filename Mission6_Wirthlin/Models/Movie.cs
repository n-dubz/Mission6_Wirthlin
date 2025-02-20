#nullable enable

using System.ComponentModel.DataAnnotations;
namespace Mission6_Wirthlin.Models
{
    public class Movie
    {
        public int MovieId { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Category { get; set; }  // e.g., Genre

        [Required]
        public string Director { get; set; }

        [Required]
        public string Rating { get; set; } // Dropdown options: G, PG, PG-13, R

        [Required]
        public bool Edited { get; set; }  // Yes/No option

        // These fields are optional
        public string? LentTo { get; set; }

        [MaxLength(25)]
        public string? Notes { get; set; }
    }
}