using AutoMapper;
using Domain;
using Domain.Entities;
using TestAppBackend.DTO.Book.AddBook;
using TestAppBackend.DTO.Book.GetBook;

namespace TestAppBackend.Services
{
    public class BookService : BaseService
    {
        private readonly IMapper mapper;

        public BookService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork)
        {
            this.mapper = mapper;
        }



        public async Task<AddBookResponse> AddBook(AddBookRequest request)
        {
            try
            {
                var entity = mapper.Map<Book>(request);
                var repository = UnitOfWork.GetRepository<Book>();
                await repository.AddAsync(entity);
                await UnitOfWork.SaveChangesAsync();
                return new AddBookResponse("Added Successfully!", true);
            }
            catch (Exception ex)
            {
                return new AddBookResponse("Error occured", false);

            }

        }

    }
}
