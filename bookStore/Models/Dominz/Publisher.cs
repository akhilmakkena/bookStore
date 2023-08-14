using System.ComponentModel.DataAnnotations;

namespace bookStore.Models.Dominz
{
    public class Publisher
    {
        public int Id { get; set; }

        [Required]
        public string? PublisherName { get; set; }    
    }
}
