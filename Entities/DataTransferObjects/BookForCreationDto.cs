using System.ComponentModel.DataAnnotations;

namespace Entities.DataTransferObjects
{
    public  class BookForCreationDto
    {
        [Required(ErrorMessage = "Title is required")]
        public string Title { get; set; }
        [Required(ErrorMessage = "AuthorIds required")]
        public List<AuthorDto> Authors { get; set; }
    }
}
