using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Con_FIA35_DAL
{
    internal interface IData
    {
        List<Author> SelectAllAuthors();
        Author SelectAuthorById(int Id);
        int InsertAuthor(Author author);
        bool DeleteAuthor(Author author);
        bool DeleteAuthorById(int Id);
        bool UpdateAuthor(Author author);
    }
}
