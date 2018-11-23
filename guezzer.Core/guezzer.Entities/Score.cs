using System.ComponentModel.DataAnnotations;

namespace guezzer.Entities
{
    public class Score
    {
        [Key]
        public int Guid { get; set; }
        [Required]
        public int Value { get; set; }

	    public Player Player { get; set; }
        public Category Category { get; set; }
    }
}
