using System;
using System.ComponentModel.DataAnnotations;

namespace guezzer.Entities
{
    public class Result
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public int Score { get; set; }

        [Required]
        public DateTime Updated { get; set; }

        [Required]
        public Player Player { get; set; }

        [Required]
        public Category Category { get; set; }
    }
}
