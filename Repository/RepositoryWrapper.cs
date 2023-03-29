using Contracts;
using Entities;

namespace Repository
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private RepositoryContext _repositoryContext;

        private IBookRepository _book;

        private IAuthorRepository _author;

        public IBookRepository Book
        {
            get
            {
                if (_book == null)
                {
                    _book = new BookRepository(_repositoryContext);
                }

                return _book;
            }
        }

        public IAuthorRepository Author
        {
            get
            {
                if (_author == null)
                {
                    _author = new AuthorRepository(_repositoryContext);
                }
                return _author;
            }

        }

    }
}
