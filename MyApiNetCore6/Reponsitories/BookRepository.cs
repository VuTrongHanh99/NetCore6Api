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

        public async Task<int> AddBookAsync(BookModelEntity model)
        {
            var newBook = _mapper.Map<Book>(model);
            _context.Books!.Add(newBook);
            await _context.SaveChangesAsync();

            return newBook.Id;
        }

        public async Task DeleteBookAsync(int id)
        {
            var deleteBook = _context.Books!.SingleOrDefault(b => b.Id == id);
            if (deleteBook != null)
            {
                _context.Books!.Remove(deleteBook);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<List<BookModelEntity>> GetAllBooksAsync()
        {
            var books = await _context.Books!.ToListAsync();
            return _mapper.Map<List<BookModelEntity>>(books);
        }

        public async Task<BookModelEntity> GetBookAsync(int id)
        {
            var book = await _context.Books!.FindAsync(id);
            return _mapper.Map<BookModelEntity>(book);
        }

        public async Task UpdateBookAsync(int id, BookModelEntity model)
        {
            if (id == model.Id)
            {
                var updateBook = _mapper.Map<Book>(model);
                _context.Books!.Update(updateBook);
                await _context.SaveChangesAsync();
            }
        }
    }
}
