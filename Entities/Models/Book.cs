using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    [Table("Book")]
    public class Book
    {
        [Column("BookId")]
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Title is required")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Author is required")]
        public List<Author> Authors { get; set; }
    }
}
