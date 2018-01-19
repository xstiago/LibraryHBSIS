using LibraryHBSIS.DataAccess.Contracts;
using LibraryHBSIS.Entities;
using System.Data.Entity;

namespace LibraryHBSIS.DataAccess
{
    public class BookRepository : BaseRepository<Book>, IBookRepository
    {
        private readonly DbContext _dbContext;

        public BookRepository(DbContext dbContext) 
            : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
