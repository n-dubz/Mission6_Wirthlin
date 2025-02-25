using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Builder;

namespace Mission6_Wirthlin.Models
{
    public class Movie
    {
        public int MovieId { get; set; }

        [Required]
        public string Title { get; set; } = string.Empty;

        [Required]
        public string Category { get; set; } = string.Empty;

        [Required]
        public string Director { get; set; } = string.Empty;

        [Required]
        public string Rating { get; set; } = string.Empty;  // Should be one of: G, PG, PG-13, R

        public bool Edited { get; set; }  // Yes/No option

        public string? LentTo { get; set; }

        [MaxLength(25)]
        public string? Notes { get; set; }
    }
}
