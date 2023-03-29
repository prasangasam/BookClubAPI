using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    [Table("Author")]
    public class Author
    {
        [Column("AuthorId")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "First Name required")]
        [MinLength(1, ErrorMessage = "Required minimum lenth is 3 characters")]
        [MaxLength(20, ErrorMessage = "Required minimum lenth is 3 characters")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "First Name required")]
        [MinLength(3, ErrorMessage = "Required minimum lenth is 3 characters")]
        [MaxLength(50, ErrorMessage = "Required minimum lenth is 3 characters")]
        public string LastName { get; set; }
    }
}
