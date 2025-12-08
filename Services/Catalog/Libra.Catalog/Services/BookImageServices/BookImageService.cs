using AutoMapper;
using Libra.Catalog.Dtos.BookImageDtos;
using Libra.Catalog.Entities;
using Libra.Catalog.Settings;
using MongoDB.Driver;

namespace Libra.Catalog.Services.BookImageServices
{
    public class BookImageService : IBookImageService
    {
        private readonly IMongoCollection<BookImage> _bookImageCollection;
        private readonly IMapper _mapper;

        public BookImageService(IMapper mapper,IDatabaseSettings _databaseSettings)
        {
            var client = new MongoClient(_databaseSettings.ConnectionString);
            var database = client.GetDatabase(_databaseSettings.DatabaseName);
            _bookImageCollection = database.GetCollection<BookImage>(_databaseSettings.BookImageCollectionName);
            _mapper = mapper;
        }

        public async Task CreateBookImageAsync(CreateBookImageDto createBookImageDto)
        {
            var values = _mapper.Map<BookImage>(createBookImageDto);
            await _bookImageCollection.InsertOneAsync(values);
        }

        public async Task DeleteBookImageAsync(string id)
        {
            await _bookImageCollection.DeleteOneAsync(x => x.BookImageId == id);
        }

        public async Task<List<ResultBookImageDto>> GetAllBookImageAsync()
        {
            var values = await _bookImageCollection.Find(x => true).ToListAsync();
            return _mapper.Map<List<ResultBookImageDto>>(values);
        }

        public async Task<GetByIdBookImageDto> GetByIdBookImageAsync(string id)
        {
            var values = await _bookImageCollection.Find(x => x.BookImageId == id).FirstOrDefaultAsync();
            return _mapper.Map<GetByIdBookImageDto>(values);
        }

        public async Task UpdateBookImageAsync(UpdateBookImageDto updateBookImageDto)
        {
            var values = _mapper.Map<BookImage>(updateBookImageDto);
            await _bookImageCollection.FindOneAndReplaceAsync(x => x.BookImageId == updateBookImageDto.BookImageId, values);
        }
    }
}
