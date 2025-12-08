using AutoMapper;
using Libra.Catalog.Dtos.BookDetailDtos;
using Libra.Catalog.Entities;
using Libra.Catalog.Settings;
using MongoDB.Driver;

namespace Libra.Catalog.Services.BookDetailServices
{
    public class BookDetailService : IBookDetailService
    {
        private readonly IMongoCollection<BookDetail> _bookDetailCollection;
        private readonly IMapper _mapper;

        public BookDetailService(IMapper mapper,IDatabaseSettings _databaseSettings)
        {
            var client = new MongoClient(_databaseSettings.ConnectionString);
            var database = client.GetDatabase(_databaseSettings.DatabaseName);
            _bookDetailCollection = database.GetCollection<BookDetail>(_databaseSettings.BookDetailCollectionName);
            _mapper = mapper;
        }

        public async Task CreateBookDetailAsync(CreateBookDetailDto createBookDetailDto)
        {
            var values = _mapper.Map<BookDetail>(createBookDetailDto);
            await _bookDetailCollection.InsertOneAsync(values);
        }

        public async Task DeleteBookDetailAsync(string id)
        {
            await _bookDetailCollection.DeleteOneAsync(x => x.BookDetailId == id);
        }

        public async Task<List<ResultBookDetailDto>> GetAllBookDetailAsync()
        {
            var values = await _bookDetailCollection.Find(x => true).ToListAsync();
            return _mapper.Map<List<ResultBookDetailDto>>(values);
        }

        public async Task<GetByIdBookDetailDto> GetByIdBookDetailAsync(string id)
        {
            var values =await _bookDetailCollection.Find(X=>X.BookDetailId==id).FirstOrDefaultAsync();
            return _mapper.Map<GetByIdBookDetailDto>(values);
        }

        public Task UpdateBookDetailAsync(UpdateBookDetailDto updateBookDetailDto)
        {
            var values = _mapper.Map<BookDetail>(updateBookDetailDto);
            return _bookDetailCollection.FindOneAndReplaceAsync(x => x.BookDetailId == updateBookDetailDto.BookDetailId, values);
        }
    }
}
