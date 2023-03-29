using Contracts;
using Entities;
using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Repository
{
    public class BookRepository : RepositoryBase<Book>, IBookRepository
    {
        public BookRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public IEnumerable<Book> GetAllBooks()
        {
            return FindAll().ToList();
        }

        public Book GetBook(Guid Id) => FindByCondition(book => book.Id.Equals(Id))
                .Include(a => a.Authors)
                .FirstOrDefault();

        public void CreateBook(Book book)
        {
            Create(book);
        }
    }
}
