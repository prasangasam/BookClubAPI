using AutoMapper;
using Contracts;
using Entities.DataTransferObjects;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookClubAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly ILogger<BooksController> _logger;
        private readonly IRepositoryWrapper _repositoryWrapper;
        private readonly IMapper _mapper;

        public BooksController(ILogger<BooksController> logger, IRepositoryWrapper repositoryWrapper, IMapper mapper) : base()
        {
            _logger = logger;
            _repositoryWrapper = repositoryWrapper;
            _mapper = mapper;
        }

        // GET: api/<BooksController>
        /// <summary>
        /// GET: api/Books
        /// </summary>
        /// <returns>Books</returns>
        [HttpGet]
        public IActionResult GetAllBooks()
        {
            try
            {

                if (_repositoryWrapper.Book == null)
                {
                    return NotFound();

                }

                var books = _repositoryWrapper.Book.FindAll();

                if (books == null)
                {
                    return NotFound();

                }

                var booksResult = _mapper.Map<IEnumerable<BookDto>>(books);

                return Ok(booksResult);

            }
            catch (Exception ex)
            {
                _logger.LogError($"error occured in {nameof(this.GetAllBooks)} with error id - {HttpContext.TraceIdentifier} {ex.Message}");
                return StatusCode(500, $"Internal Server error id - {HttpContext.TraceIdentifier}");
            }


        }

        // GET api/<BooksController>/5
        [HttpGet("{id}")]
        public IActionResult GetBook(Guid id)
        {
            try
            {
                var book = _repositoryWrapper.Book.FindByCondition(b => b.Id == id).FirstOrDefault();

                if (book is null)
                {
                    _logger.LogError($"error occured in {nameof(this.GetBook)} with id:{id}hasn't been found");
                    return NotFound();
                }
                else
                {
                    var bookResult = _mapper.Map<BookDto>(book);
                    return Ok(bookResult);
                }


            }
            catch (Exception ex)
            {
                _logger.LogError($"error occured in {nameof(this.GetAllBooks)} with error id - {HttpContext.TraceIdentifier} {ex.Message}");
                return StatusCode(500, $"Internal Server error id - {HttpContext.TraceIdentifier}");
            }
        }
    }
}
