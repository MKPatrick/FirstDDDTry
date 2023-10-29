using AutoMapper;
using Domain.Entities;
using TestAppBackend.DTO.Book.AddBook;
using TestAppBackend.DTO.Book.GetBook;

namespace TestAppBackend.Mapping
{
    public class DefaultMapping : Profile
    {

        public DefaultMapping()
        {
            CreateMap<Book, AddBookRequest>();
            CreateMap<AddBookRequest, Book>();
            
            CreateMap<IEnumerable<GetBookResponse>, List<Book>>();
            CreateMap< IEnumerable<Book>, List<GetBookResponse>>();
        }

    }
}
