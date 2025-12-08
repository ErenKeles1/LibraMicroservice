using AutoMapper;
using Libra.Catalog.Dtos.BookDtos;
using Libra.Catalog.Entities;
using Libra.Catalog.Settings;
using MongoDB.Driver;

namespace Libra.Catalog.Services.BookServices
{
    public class BookService : IBookService
    {
        private readonly IMongoCollection<Book> _bookCollection;
        private readonly IMapper _mapper;

        public BookService(IMapper mapper, IDatabaseSettings _databaseSettings)
        {
            var client=new MongoClient(_databaseSettings.ConnectionString);
            var database = client.GetDatabase(_databaseSettings.DatabaseName);
            _bookCollection = database.GetCollection<Book>(_databaseSettings.BookCollectionName);
            _mapper = mapper;
        }

        public async Task CreateBookAsync(CreateBookDto createBookDto)
        {
            var values = _mapper.Map<Book>(createBookDto);
            await _bookCollection.InsertOneAsync(values);
        }

        public async Task DeleteBookAsync(string id)
        {
            await _bookCollection.DeleteOneAsync(x=>x.BookId==id);
        }

        public async Task<List<ResultBookDto>> GetAllBookAsync()
        {
            var values = await _bookCollection.Find(x => true).ToListAsync();
            return _mapper.Map<List<ResultBookDto>>(values);
        }

        public async Task<GetByIdBookDto> GetByIdBookAsync(string id)
        {
            var values = await _bookCollection.Find<Book>(x => x.BookId == id).FirstOrDefaultAsync();
            return _mapper.Map<GetByIdBookDto>(values);
        }

        public async Task UpdateBookAsync(UpdateBookDto updateBookDto)
        {
            var values =_mapper.Map<Book>(updateBookDto);
             await _bookCollection.FindOneAndReplaceAsync(x=>x.BookId==updateBookDto.BookId,values);
        }
    }
}
