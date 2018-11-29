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
        [StringLength(50)]
        public string Name { get; set; }

        public IList<Result> Results { get; set; }
    }
}
