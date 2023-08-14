using System.ComponentModel.DataAnnotations;

namespace bookStore.Models.Dominz
{
    public class Genre
    {
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }    
    }
}
