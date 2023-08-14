using System.ComponentModel.DataAnnotations;

namespace bookStore.Models.Dominz
{
    public class Author
    {
        public int Id { get; set; }
        [Required]
        public string? AuthorName { get; set; }    
    }
}
