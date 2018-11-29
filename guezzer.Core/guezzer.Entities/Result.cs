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

        public DateTime Updated { get; set; }

        public Player Player { get; set; }
        public Category Category { get; set; }
    }
}
