using Libra.Catalog.Dtos.BookImageDtos;

namespace Libra.Catalog.Services.BookImageServices
{
    public interface IBookImageService
    {
        Task<List<ResultBookImageDto>> GetAllBookImageAsync();
        Task CreateBookImageAsync(CreateBookImageDto createBookImageDto);
        Task UpdateBookImageAsync(UpdateBookImageDto updateBookImageDto);
        Task DeleteBookImageAsync(string id);
        Task<GetByIdBookImageDto> GetByIdBookImageAsync(string id);
    }
}
