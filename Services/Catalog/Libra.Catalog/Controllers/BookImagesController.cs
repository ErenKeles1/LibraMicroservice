using Libra.Catalog.Dtos.BookImageDtos;
using Libra.Catalog.Services.BookImageServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Libra.Catalog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookImagesController : ControllerBase
    {
        private readonly IBookImageService _BookImageService;

        public BookImagesController(IBookImageService BookImageService)
        {
            _BookImageService = BookImageService;
        }

        [HttpGet]
        public async Task<IActionResult> BookImageList()
        {
            var values = await _BookImageService.GetAllBookImageAsync();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBookImageById(string id)
        {
            var values = await _BookImageService.GetByIdBookImageAsync(id);
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> CreateBookImage(CreateBookImageDto createBookImageDto)
        {
            await _BookImageService.CreateBookImageAsync(createBookImageDto);
            return Ok("Kitap Resmi Başarıyla eklendi.");
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteBookImage(string id)
        {
            await _BookImageService.DeleteBookImageAsync(id);
            return Ok("Kitap Resmi Başarıyla Silindi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateBookImage(UpdateBookImageDto updateBookImageDto)
        {
            await _BookImageService.UpdateBookImageAsync(updateBookImageDto);
            return Ok("Kitap Resmi Başarıyla Güncellendi");
        }
    }
}
