using DAL.CQRS.Commands.Request;
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
        [HttpPost]
        public JsonResult ReserveBook()
        {
            try
            {
                var id = Request["id"];
                var bookingNumber = Guid.NewGuid();

                ReserveBookCommandRequest book = new ReserveBookCommandRequest
                {
                    Id = id,
                    IsReserved = true,
                    BookingNumber = bookingNumber,
                };
                return Json(book, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}