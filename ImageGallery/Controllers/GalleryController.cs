using ImageGallery.Models.DAL;
using ImageGallery.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ImageGallery.Controllers
{
    public class GalleryController : Controller
    {
        // GET: Gallery
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult _List()
        {
            ImageGalleryEntities db = new ImageGalleryEntities();
            var list = db.Galleries.OrderBy(x => x.OrderNo)
                        .Select(x => new ImageList
                        {
                            Id = x.Id,
                            IsActive = x.IsActive,
                            OrderNo = x.OrderNo,
                            WebImageId = x.WebImageId,
                            Title = x.Title,
                            Details = x.Details,
                            Make = x.Make,
                            Modal = x.Modal,
                            Registration = x.Registration,
                            Location = x.Location,
                            DateAndTime = x.DateAndTime
                        }).ToList();

            return PartialView(list);
        }


    }
}