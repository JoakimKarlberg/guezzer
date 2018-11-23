using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace guezzer.Entities
{
    public class Category
    {
        [Key]
        public Guid Id{ get; set; }
        public string Type { get; set; }

        public IList<Score> Scores { get; set; }
    }
}
