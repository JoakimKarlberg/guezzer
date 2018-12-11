using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace guezzer.Entities
{
    public class Category
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Type { get; set; }

        public IList<Result> Results { get; set; }
    }
}
