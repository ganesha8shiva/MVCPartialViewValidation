using MvcApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Index()
        {
            return View();
        }


        // GET: /Home/AddUserPartialView
        public PartialViewResult AddUserPartialView()
        {
            ModelState.AddModelError("AddUserViewModel", "Some Error.");
            return PartialView("AddUserPartialView", new AddUserViewModel());
        }


        // GET: /Home/AddUserInfo
        [HttpPost]
        public JsonResult AddUserInfo(AddUserViewModel model)
        {
            bool isSuccess = false;
            if (ModelState.IsValid)
            {
                isSuccess = true;
            }

            //Test Error
            //int p = 0;
            //int k = 10 / p;
            //Test Error

            return Json(new { success = isSuccess, model = model }, JsonRequestBehavior.AllowGet);
        }
    }
}
