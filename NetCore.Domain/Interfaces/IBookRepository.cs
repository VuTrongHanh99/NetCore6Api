using NetCore.Domain.Entities;

namespace NetCore.Domain.Interfaces
{
    public interface IBookRepository
    {
        public Task<List<BookModelEntity>> GetAllBooksAsync();
        public Task<BookModelEntity> GetBookAsync(int id);
        public Task<int> AddBookAsync(BookModelEntity model);
        public Task UpdateBookAsync(int id, BookModelEntity model);
        public Task DeleteBookAsync(int id);
    }
}
