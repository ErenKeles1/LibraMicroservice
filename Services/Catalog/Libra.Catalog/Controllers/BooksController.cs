using Libra.Catalog.Dtos.BookDtos;
using Libra.Catalog.Services.BookServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Libra.Catalog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBookService _BookService;

        public BooksController(IBookService BookService)
        {
            _BookService = BookService;
        }

        [HttpGet]
        public async Task<IActionResult> BookList()
        {
            var values = await _BookService.GetAllBookAsync();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBookById(string id)
        {
            var values = await _BookService.GetByIdBookAsync(id);
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> CreateBook(CreateBookDto createBookDto)
        {
            await _BookService.CreateBookAsync(createBookDto);
            return Ok("Kitap Başarıyla eklendi.");
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteBook(string id)
        {
            await _BookService.DeleteBookAsync(id);
            return Ok("Kitap Başarıyla Silindi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateBook(UpdateBookDto updateBookDto)
        {
            await _BookService.UpdateBookAsync(updateBookDto);
            return Ok("Kitap Başarıyla Güncellendi");
        }
    }
}
