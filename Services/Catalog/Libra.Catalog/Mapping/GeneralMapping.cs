using AutoMapper;
using Libra.Catalog.Dtos.CategoryDtos;
using Libra.Catalog.Dtos.BookDetailDtos;
using Libra.Catalog.Dtos.BookDtos;
using Libra.Catalog.Dtos.BookImageDtos;
using Libra.Catalog.Entities;

namespace Libra.Catalog.Mapping
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
