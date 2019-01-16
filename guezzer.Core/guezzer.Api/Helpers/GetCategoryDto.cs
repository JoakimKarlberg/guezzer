using guezzer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace guezzer.Api.Helpers
{
    public class GetCategoryDto
    {
        [Required]
        public Guid Id { get; set; }

        [Required]
        public string Type { get; set; }
        
    }
}
