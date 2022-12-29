using MyApiNetCore6.Data;

namespace MyApiNetCore6.Reponsitories
{
    public interface IBookRepository
    {
        public Task<List<Book>> getListBookAsync();
        public Task<Book> getBookAsync(int id);
        public Task<int> addBookAsync(Book book);
        public Task updateBookAsync(int id,Book book);
        public Task deleteBookAsync(int id);
    }
}
