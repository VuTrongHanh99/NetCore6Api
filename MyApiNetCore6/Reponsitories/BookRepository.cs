using AutoMapper;
using Data.SqlServer.Context;
using Data.SqlServer.Data;
using Microsoft.EntityFrameworkCore;
using NetCore.Domain.Entities;

namespace MyApiNetCore6.Reponsitories
{
    public class BookRepository : IBookRepository
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public BookRepository(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public Task<int> AddBookAsync(BookModelEntity model)
        {
            throw new NotImplementedException();
        }

        public Task DeleteBookAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<BookModelEntity>> GetAllBooksAsync()
        {
            var books = await _context.Books!.ToListAsync();
            return _mapper.Map<List<BookModelEntity>>(books);
        }

        public Task<BookModelEntity> GetBookAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateBookAsync(int id, BookModelEntity model)
        {
            throw new NotImplementedException();
        }
    }
}
