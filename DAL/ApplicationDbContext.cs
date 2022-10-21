using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ApplicationDbContext
    {
        static List<Books> bookList = new List<Books> {
            new Books { Id = "9b0896fa-3880-4c2e-bfd6-925c87f22878" , Title = "CQRS for Dummies", IsReserved = false },
            new Books { Id = "0550818d-36ad-4a8d-9c3a-a715bf15de76" , Title = "Visual Studio Tips", IsReserved = false },
            new Books { Id = "8e0f11f1-be5c-4dbc-8012-c19ce8cbe8e1" , Title = "NHibernate Cookbook", IsReserved = false },
        };
        public static List<Books> BookList => bookList;
    }
}
