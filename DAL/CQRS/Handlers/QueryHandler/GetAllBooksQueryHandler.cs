using DAL.CQRS.Queries.Request;
using DAL.CQRS.Queries.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.CQRS.Handlers.QueryHandler
{
    public class GetAllBooksQueryHandler
    {
        public List<GetAllBooksQueryResponse> GetAllBooks(GetAllBooksQueryRequest getAllBooksQueryRequest)
        {
            return ApplicationDbContext.BookList.Select(book => new GetAllBooksQueryResponse
            {
                Id = book.Id,
                Title = book.Title,
                IsReserved = book.IsReserved,
            }).ToList();
        }
    }
}
