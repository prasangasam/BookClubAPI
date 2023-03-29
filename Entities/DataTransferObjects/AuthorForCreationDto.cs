using System.ComponentModel.DataAnnotations;

namespace Entities.DataTransferObjects
{
    public class AuthorForCreationDto
    {
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
