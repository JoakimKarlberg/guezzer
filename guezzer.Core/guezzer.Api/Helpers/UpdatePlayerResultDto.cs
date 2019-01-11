using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace guezzer.Api.Helpers
{
    public class UpdatePlayerResultDto
    {
        [Required]
        [MaxLength(10, ErrorMessage = "The Name must be between 1-10 letters")]
        public string Name { get; set; }

        [Required]
        public string Category { get; set; }

        [Required(ErrorMessage = "You need to fill in a valid Score")]
        public int Score { get; set; }
    }
}
