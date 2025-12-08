using Libra.Catalog.Dtos.BookDetailDtos;
using Libra.Catalog.Services.BookDetailServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Libra.Catalog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookDetailsController : ControllerBase
    {
        private readonly IBookDetailService _BookDetailService;

        public BookDetailsController(IBookDetailService BookDetailService)
        {
            _BookDetailService = BookDetailService;
        }

        [HttpGet]
        public async Task<IActionResult> BookDetailList()
        {
            var values = await _BookDetailService.GetAllBookDetailAsync();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBookDetailById(string id)
        {
            var values = await _BookDetailService.GetByIdBookDetailAsync(id);
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> CreateBookDetail(CreateBookDetailDto createBookDetailDto)
        {
            await _BookDetailService.CreateBookDetailAsync(createBookDetailDto);
            return Ok("Kitap Detayı Başarıyla eklendi.");
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteBookDetail(string id)
        {
            await _BookDetailService.DeleteBookDetailAsync(id);
            return Ok("Kitap Detayı Başarıyla Silindi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateBookDetail(UpdateBookDetailDto updateBookDetailDto)
        {
            await _BookDetailService.UpdateBookDetailAsync(updateBookDetailDto);
            return Ok("Kitap Detayı Başarıyla Güncellendi");
        }
    }
}
