using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace guezzer.Api.Helpers
{
    public class UpdatePlayerDto
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        public int TimesPlayed { get; set; }
    }
}
