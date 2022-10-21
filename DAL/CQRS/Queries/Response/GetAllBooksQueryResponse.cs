using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.CQRS.Queries.Response
{
    public class GetAllBooksQueryResponse
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public bool IsReserved { get; set; }
    }
}
