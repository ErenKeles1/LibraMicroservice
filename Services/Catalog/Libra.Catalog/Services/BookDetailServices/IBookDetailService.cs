using Libra.Catalog.Dtos.BookDetailDtos;

namespace Libra.Catalog.Services.BookDetailServices
{
    public interface IBookDetailService
    {
        Task<List<ResultBookDetailDto>> GetAllBookDetailAsync();
        Task CreateBookDetailAsync(CreateBookDetailDto createBookDetailDto);
        Task UpdateBookDetailAsync(UpdateBookDetailDto updateBookDetailDto);
        Task DeleteBookDetailAsync(string id);
        Task<GetByIdBookDetailDto> GetByIdBookDetailAsync(string id);
    }
}
