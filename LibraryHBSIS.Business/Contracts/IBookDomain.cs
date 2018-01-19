using LibraryHBSIS.Entities;
using System.Collections.Generic;

namespace LibraryHBSIS.Business.Contracts
{
    public interface IBookDomain
    {
        IList<Book> Get();
        Book GetById(int id);
        void Save(Book book);
    }
}
