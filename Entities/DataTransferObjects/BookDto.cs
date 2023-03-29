namespace Entities.DataTransferObjects
{
    public class BookDto
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public List<AuthorDto> Authors { get; set; }
    }
}
