using LibraryHBSIS.Business.Contracts;
using LibraryHBSIS.DataAccess.Contracts;
using LibraryHBSIS.Entities;
using System.Collections.Generic;
using System.Linq;

namespace LibraryHBSIS.Business
{
    public class BookDomain : IBookDomain
    {
        private IBookRepository _bookRepository;

        public BookDomain(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public IList<Book> Get()
        {
            return _bookRepository
                .Get(o => o.BookID > 0)
                .ToList();
        }

        public Book GetById(int id)
        {
            return _bookRepository
                .Get(o => o.BookID == id)
                .FirstOrDefault();
        }

        public void Save(Book book)
        {
            var bookGet = this.GetById(book.BookID);

            if (bookGet == null)
            {
                _bookRepository.Add(book);
            }
            else
            {
                //TODO Upade
            }
        }
    }
}
