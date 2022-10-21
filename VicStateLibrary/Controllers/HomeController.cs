using DAL.CQRS.Handlers.QueryHandler;
using DAL.CQRS.Queries.Request;
using DAL.CQRS.Queries.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VicStateLibrary.Controllers
{
    public class HomeController : Controller
    {
        GetAllBooksQueryHandler _getAllBooksQueryHandler;
        public HomeController()
        {
            GetAllBooksQueryHandler getAllBooksQueryHandler = new GetAllBooksQueryHandler();
            _getAllBooksQueryHandler = getAllBooksQueryHandler;
        }
        public ActionResult Index(GetAllBooksQueryRequest requestModel)
        {
            List<GetAllBooksQueryResponse> allBooks = _getAllBooksQueryHandler.GetAllBooks(requestModel);
            return View(allBooks);
        }           
    }
}