using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace guezzer.Entities
{
    public class Player
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(10, ErrorMessage = "The Name must be between 1-10 letters")]
        public string Name { get; set; }

        [Required]
        public int TimesPlayed { get; set; }

        public IList<Result> Results { get; set; }
    }
}
