using Libra.Catalog.Dtos.BookDtos;

namespace Libra.Catalog.Services.BookServices
{
    public interface IBookService 
    {
        Task<List<ResultBookDto>> GetAllBookAsync();
        Task CreateBookAsync(CreateBookDto createBookDto);
        Task UpdateBookAsync(UpdateBookDto updateBookDto);
        Task DeleteBookAsync(string id);
        Task<GetByIdBookDto> GetByIdBookAsync(string id);
    }
}
