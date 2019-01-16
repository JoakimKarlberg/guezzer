using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace guezzer.Api.Helpers
{
    public class UpdateResultDto
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Category { get; set; }

        [Required(ErrorMessage = "You need to fill in a valid Score")]
        public int Score { get; set; }
    }
}
