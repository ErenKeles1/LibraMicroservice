using AutoMapper;
using Kitap.Catalog.Dtos.CategoryDtos;
using Kitap.Catalog.Dtos.BookDetailDtos;
using Kitap.Catalog.Dtos.BookDtos;
using Kitap.Catalog.Dtos.BookImageDtos;
using Kitap.Catalog.Entities;

namespace Kitap.Catalog.Mapping
{
    public class GeneralMapping:Profile
    {
        public  GeneralMapping() {
            CreateMap<Category, ResultCategoryDto>().ReverseMap();
            CreateMap<Category, CreateCategoryDto>().ReverseMap();
            CreateMap<Category, UpdateCategoryDto>().ReverseMap();
            CreateMap<Category, GetByIdCategoryDto>().ReverseMap();

            CreateMap<Book, ResultBookDto>().ReverseMap();
            CreateMap<Book, CreateBookDto>().ReverseMap();
            CreateMap<Book, UpdateBookDto>().ReverseMap();
            CreateMap<Book, GetByIdBookDto>().ReverseMap();

            CreateMap<BookDetail, ResultBookDetailDto>().ReverseMap();
            CreateMap<BookDetail, CreateBookDetailDto>().ReverseMap();
            CreateMap<BookDetail, UpdateBookDetailDto>().ReverseMap();
            CreateMap<BookDetail, GetByIdBookDetailDto>().ReverseMap();

            CreateMap<BookImage, ResultBookImageDto>().ReverseMap();
            CreateMap<BookImage, CreateBookImageDto>().ReverseMap();
            CreateMap<BookImage, UpdateBookImageDto>().ReverseMap();
            CreateMap<BookImage, GetByIdBookImageDto>().ReverseMap();
        }
        
    }
}
